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
    public partial class MostrarVentas : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public int Id_Rol { get; set; }
        int valorcelda = -1;
        #endregion
        public MostrarVentas()
        {
            InitializeComponent();
        }

        private void MostrarVentas_Load(object sender, EventArgs e)
        {
            try
            {
                NVentas Negocios = new NVentas();
                NLoterias NegociosLoterias = new NLoterias();
                NMaquinas NegociosMaquinas = new NMaquinas();
                NUsuarios NegociosUsuarios = new NUsuarios();
                //EVentas Entidad = new EVentas();
                this.cbo_maquina.DisplayMember = "Text";
                this.cbo_maquina.ValueMember = "Value";

                this.cbo_maquina.DataSource = NegociosMaquinas.Mostrar().Select(x => new
                {
                    Text = x.Nombre_maquina,
                    Value = x.ID_maquina
                }
                ).ToArray();
                dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                {
                    Id_Venta = x.ID_venta,
                    Apuesta = x.Apuesta,
                    Cantidad_de_venta = x.Cantidad_de_Venta,
                    Fecha_Venta = x.fecha_venta,
                    Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                    Porcentaje_Ganancia = x.Porcentaje_Ganancia + "%",
                    Premio_a_pagar = x.Premio_a_pagar,
                    Loteria = NegociosLoterias.Mostrar().Where(y => y.ID_loteria == x.ID_loteria).Select(y => y.Nombre_loteria).FirstOrDefault(),
                    Maquina = NegociosMaquinas.Mostrar().Where(y => y.ID_maquina == x.ID_maquina).Select(y => y.Nombre_maquina).FirstOrDefault(),
                    Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).Select(y => y.Usuario).FirstOrDefault()
                }
                ).ToList();
                valorcelda = -1;
                this.dat_principal.ReadOnly = true;
                NRoles NegociosRoles = new NRoles();
                List<EPermisos> perm = new List<EPermisos>();
                perm = NegociosRoles.llenar_Permisos(Id_Rol, "Ventas");
                if (perm.Where(x => x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    this.btn_agregar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Modificar").FirstOrDefault() != null)
                {
                    this.btn_editar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Eliminar").FirstOrDefault() != null)
                {
                    this.btn_eliminar.Enabled = true;
                }
                if (perm.Where(x => x.Accion == "Consultar").FirstOrDefault() != null)
                {
                    this.btn_consultar.Enabled = true;
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
                    AgregarVentas frm = new AgregarVentas();
                    frm.Accion = Accion;
                    frm.Id = valorcelda;
                    frm.Usuario = Usuario;
                    frm.ShowDialog();
                    valorcelda = -1;
                    MostrarVentas_Load(null, null);
                }
                else
                {
                    if (Accion == "A")
                    {
                        AgregarVentas frm = new AgregarVentas();
                        frm.Accion = Accion;
                        frm.Id = valorcelda;
                        frm.Usuario = Usuario;
                        frm.ShowDialog();
                        valorcelda = -1;
                        MostrarVentas_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una venta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DialogResult dr = MessageBox.Show("Realmente desea eliminar la venta?", "Eliminar la venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            Int32 FilasAfectadas = 0;
                            NMaquinas Negocios = new NMaquinas();
                            FilasAfectadas = Negocios.Eliminar(valorcelda, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Venta eliminada satisfactoriamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la venta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            valorcelda = -1;
                            MostrarVentas_Load(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una venta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MostrarVentas_Load(null, null);
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
                if (this.txt_buscar_venta.Text != "")
                {
                    NVentas Negocios = new NVentas();
                    NLoterias NegociosLoterias = new NLoterias();
                    NMaquinas NegociosMaquinas = new NMaquinas();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = int.Parse(this.txt_buscar_venta.Text);
                    dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                    {
                        Id_Venta = x.ID_venta,
                        Apuesta = x.Apuesta,
                        Cantidad_de_venta = x.Cantidad_de_Venta,
                        Fecha_Venta = x.fecha_venta,
                        Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                        Porcentaje_Ganancia = x.Porcentaje_Ganancia + "%",
                        Premio_a_pagar = x.Premio_a_pagar,
                        Loteria = NegociosLoterias.Mostrar().Where(y => y.ID_loteria == x.ID_loteria).Select(y => y.Nombre_loteria).FirstOrDefault(),
                        Maquina = NegociosMaquinas.Mostrar().Where(y => y.ID_maquina == x.ID_maquina).Select(y => y.Nombre_maquina).FirstOrDefault(),
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).Select(y => y.Usuario).FirstOrDefault()
                    }).Where(l => l.Id_Venta == Id).ToList();
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
                if (this.cbo_maquina.Text != "")
                {
                    NVentas Negocios = new NVentas();
                    NLoterias NegociosLoterias = new NLoterias();
                    NMaquinas NegociosMaquinas = new NMaquinas();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = int.Parse(this.cbo_maquina.SelectedValue.ToString());
                    dat_principal.DataSource = Negocios.Mostrar().Where(l => l.ID_maquina == Id).Select(x => new
                    {
                        Id_Venta = x.ID_venta,
                        Apuesta = x.Apuesta,
                        Cantidad_de_venta = x.Cantidad_de_Venta,
                        Fecha_Venta = x.fecha_venta,
                        Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                        Porcentaje_Ganancia = x.Porcentaje_Ganancia + "%",
                        Premio_a_pagar = x.Premio_a_pagar,
                        Loteria = NegociosLoterias.Mostrar().Where(y => y.ID_loteria == x.ID_loteria).Select(y => y.Nombre_loteria).FirstOrDefault(),
                        Maquina = NegociosMaquinas.Mostrar().Where(y => y.ID_maquina == x.ID_maquina).Select(y => y.Nombre_maquina).FirstOrDefault(),
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).Select(y => y.Usuario).FirstOrDefault()
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
