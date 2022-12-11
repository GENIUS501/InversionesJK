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
    public partial class AgregarVentas : Form
    {
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public int UsuarioRegistroVenta { get; set; }
        public AgregarVentas()
        {
            InitializeComponent();
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_multiplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_apuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Validar_Calculos()
        {
            bool respuesta = true;
            if (this.txt_apuesta.Text == "")
            {
                errorProvider1.SetError(this.txt_apuesta, "Debe llenar el campo");
                respuesta = false;
            }
            if (this.txt_multiplicador.Text == "")
            {
                errorProvider1.SetError(this.txt_multiplicador, "Debe llenar el campo");
                respuesta = false;
            }
            if (this.txt_porcentaje_ganancia.Text == "")
            {
                errorProvider1.SetError(this.txt_porcentaje_ganancia, "Debe llenar el campo");
                respuesta = false;
            }
            if (this.txt_venta.Text == "")
            {
                errorProvider1.SetError(this.txt_venta, "Debe llenar el campo");
                respuesta = false;
            }
            return respuesta;
        }
        private void Limpiar_Calculos()
        {
            errorProvider1.SetError(this.txt_apuesta, "");
            errorProvider1.SetError(this.txt_multiplicador, "");
            errorProvider1.SetError(this.txt_venta, "");
            errorProvider1.SetError(this.txt_porcentaje_ganancia, "");
        }
        private void Calcular()
        {
            this.txt_premio.Text = (int.Parse(this.txt_apuesta.Text) * int.Parse(this.txt_multiplicador.Text)).ToString();
            this.txt_comision_ganancia.Text = (int.Parse(this.txt_venta.Text) * int.Parse(this.txt_porcentaje_ganancia.Text) / 100).ToString();
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Calculos();
                if (Validar_Calculos())
                {
                    Calcular();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_porcentaje_ganancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (Accion == "C")
                    {
                        this.Close();
                    }
                    Limpiar_Calculos();
                    if (Validar_Calculos())
                    {
                        if (Accion == "A" || Accion == "M")
                        {
                            EVentas Obj = new EVentas();
                            Obj.Apuesta = double.Parse(this.txt_apuesta.Text);
                            Obj.Multiplicar_Apuesta=int.Parse(this.txt_multiplicador.Text);
                            Obj.Porcentaje_Ganancia=int.Parse(this.txt_porcentaje_ganancia.Text);
                            Obj.Cantidad_de_Venta=int.Parse(this.txt_venta.Text);
                            Obj.Premio_a_pagar=int.Parse(this.txt_premio.Text);
                            Obj.ID_loteria=int.Parse(this.cbo_loteria.SelectedValue.ToString());
                            Obj.ID_maquina=int.Parse(this.cbo_maquina.SelectedValue.ToString());
                            Obj.Id_Usuario = Usuario;
                            Obj.fecha_venta=Convert.ToDateTime(this.dtp_fecha_maq.Text);
                            NVentas Negocios = new NVentas();
                            Int32 FilasAfectadas = 0;
                            #region Agregar
                            if (Accion == "A")
                            {
                                FilasAfectadas = Negocios.Agregar(Obj, Usuario);

                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Se agrego la venta", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("La venta se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo agregar la venta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            #endregion

                            #region Modificar
                            if (Accion == "M")
                            {
                                Obj.ID_venta = int.Parse(this.txt_codigo_venta.Text);
                                Obj.Id_Usuario = UsuarioRegistroVenta;
                                FilasAfectadas = Negocios.Modificar(Obj, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Venta modificada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("La venta se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo modificar la venta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            #endregion
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LlenarCombos()
        {
            NMaquinas NegociosMaquinas = new NMaquinas();
            this.cbo_maquina.DisplayMember = "Text";
            this.cbo_maquina.ValueMember = "Value";

            this.cbo_maquina.DataSource = NegociosMaquinas.Mostrar().Select(x => new
            {
                Text = x.Nombre_maquina,
                Value = x.ID_maquina
            }
            ).ToArray();
            NLoterias NegociosLoterias = new NLoterias();
            this.cbo_loteria.DisplayMember = "Text";
            this.cbo_loteria.ValueMember = "Value";
            this.cbo_loteria.DataSource = NegociosLoterias.Mostrar().Select(x => new
            {
                Text = x.Nombre_loteria,
                Value = x.ID_loteria
            }
            ).ToArray();
        }
        private void llenar()
        {
            NVentas Negocios = new NVentas();
            EVentas Obj = new EVentas();
            Obj = Negocios.Mostrar().Where(x => x.ID_venta == Id).FirstOrDefault();
            if (Obj != null)
            {
                this.txt_apuesta.Text = Obj.Apuesta.ToString();
                this.txt_codigo_venta.Text = Obj.ID_venta.ToString();
                this.txt_multiplicador.Text = Obj.Multiplicar_Apuesta.ToString();
                this.txt_porcentaje_ganancia.Text = Obj.Porcentaje_Ganancia.ToString();
                this.txt_venta.Text = Obj.Cantidad_de_Venta.ToString();
                this.txt_premio.Text = Obj.Premio_a_pagar.ToString();
                this.cbo_loteria.SelectedValue = Obj.ID_loteria;
                this.cbo_maquina.SelectedValue = Obj.ID_maquina;
                this.dtp_fecha_maq.Text = Obj.fecha_venta.ToString();
                UsuarioRegistroVenta = Obj.Id_Usuario;
                Calcular();
            }
        }
        private void AgregarVentas_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCombos();
                if (Accion == "A")
                {
                    this.lbl_codigo_venta.Visible = false;
                    this.txt_codigo_venta.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    this.Text = "Modificar Venta";
                    this.txt_codigo_venta.Enabled = false;
                    llenar();
                    if (Accion == "C")
                    {
                        this.Text = "Consultar Venta";
                        this.groupBox1.Enabled = false;
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
