using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversionesJK.UI
{
    public partial class MostrarUsuarios : Form
    {
        int valorcelda = -1;
        public int Usuario { get; set; }
        public int Id_Rol { get; set; }
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                NUsuarios Negocios = new NUsuarios();
                dat_principal.DataSource = Negocios.Mostrar();
                valorcelda = -1;
                this.dat_principal.ReadOnly = true;
                //NRol NegociosRoles = new NRol();
                //List<EPermisos> perm = new List<EPermisos>();
                //perm = NegociosRoles.llenar_Permisos(Id_Rol, "Categoria");
                //if (perm.Where(x => x.Accion == "Agregar").FirstOrDefault() != null)
                //{
                this.btn_agregar.Enabled = true;
                //}
                //if (perm.Where(x => x.Accion == "Modificar").FirstOrDefault() != null)
                //{
                this.btn_editar.Enabled = true;
                //}
                //if (perm.Where(x => x.Accion == "Eliminar").FirstOrDefault() != null)
                //{
                this.btn_eliminar.Enabled = true;
                //}
                //if (perm.Where(x => x.Accion == "Consultar").FirstOrDefault() != null)
                //{
                this.btn_consultar.Enabled = true;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("M");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorcelda != -1)
                {
                    DialogResult dr = MessageBox.Show("Realmente desea eliminar el usuario?", "Eliminar el usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Int32 FilasAfectadas = 0;
                        NRoles Negocios = new NRoles();
                        Negocios.AgregarPermisos(new List<Entidades.EPermisos>(), valorcelda);
                        FilasAfectadas = Negocios.Eliminar(valorcelda, Usuario);
                        if (FilasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado satisfactoriamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (FilasAfectadas == -1)
                            {
                                MessageBox.Show("Usuario eliminado satisfactoriamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        valorcelda = -1;
                        MostrarUsuarios_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El registro que esta tratando de eliminar esta relacionado con otro.\nPor favor verifique antes de borrar este registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Renderizar("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    MostrarUsuarios_Load(null, null);
                }
                else
                {
                    valorcelda = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(string Accion)
        {
            try
            {

                if (Accion != "A" && Accion == "M" && valorcelda != -1 || Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
                {
                    //valorcelda = dat_usuarios.CurrentRow.Index;
                    AgregarRolesyPermisos frm = new AgregarRolesyPermisos();
                    frm.Accion = Accion;
                    frm.Id = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    MostrarUsuarios_Load(null, null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        AgregarRolesyPermisos frm = new AgregarRolesyPermisos();
                        frm.Accion = Accion;
                        frm.Id = valorcelda;
                        frm.Usuario = Usuario;
                        frm.ShowDialog();
                        valorcelda = -1;
                        MostrarUsuarios_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
