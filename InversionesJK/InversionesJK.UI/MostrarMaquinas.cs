using Entidades;
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
    public partial class MostrarMaquinas : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public int Id_Rol { get; set; }
        int valorcelda = -1;
        #endregion
        public MostrarMaquinas()
        {
            InitializeComponent();
        }

        private void MostrarMaquinas_Load(object sender, EventArgs e)
        {
            try
            {
                NMaquinas Negocios = new NMaquinas();
                EMaquinas Entidad = new EMaquinas();
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
        private void Renderizar(string Accion)
        {
            try
            {

                if (Accion != "A" && Accion == "M" && valorcelda != -1 || Accion != "A" && Accion == "E" && valorcelda != -1 || Accion != "A" && Accion == "C" && valorcelda != -1)
                {
                    //valorcelda = dat_usuarios.CurrentRow.Index;
                    AgregarMaquinas frm = new AgregarMaquinas();
                    frm.Accion = Accion;
                    frm.Id = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    MostrarMaquinas_Load(null, null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        AgregarMaquinas frm = new AgregarMaquinas();
                        frm.Accion = Accion;
                        frm.Id = valorcelda;
                        frm.Usuario = Usuario;
                        frm.ShowDialog();
                        valorcelda = -1;
                        MostrarMaquinas_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una maquina!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                try
                {
                    if (valorcelda != -1)
                    {
                        DialogResult dr = MessageBox.Show("Realmente desea eliminar la maquina?", "Eliminar la loteria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            Int32 FilasAfectadas = 0;
                            NMaquinas Negocios = new NMaquinas();
                            FilasAfectadas = Negocios.Eliminar(valorcelda, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Maquina eliminada satisfactoriamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la maquina!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            valorcelda = -1;
                            MostrarMaquinas_Load(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una maquina!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El registro que esta tratando de eliminar esta relacionado con otro.\nPor favor verifique antes de borrar este registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MostrarMaquinas_Load(null, null);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txt_buscar_maquina, "");
                if (this.txt_buscar_maquina.Text != "")
                {
                    var Id = int.Parse(this.txt_buscar_maquina.Text);
                    NMaquinas Negocios = new NMaquinas();
                    dat_principal.DataSource = Negocios.Mostrar().Where(x => x.ID_maquina == Id).ToList();
                }
                else
                {
                    errorProvider1.SetError(txt_buscar_maquina, "Debe llenar este campo!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txt_nombre, "");
                if (this.txt_nombre.Text != "")
                {
                    NMaquinas Negocios = new NMaquinas();
                    dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Nombre_maquina.Contains(this.txt_nombre.Text)).ToList();
                }
                else
                {
                    errorProvider1.SetError(txt_nombre, "Debe llenar este campo!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
