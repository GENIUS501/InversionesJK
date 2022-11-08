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
    public partial class AgregarMaquinas : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        #endregion
        public AgregarMaquinas()
        {
            InitializeComponent();
        }
        private void llenar()
        {
            NMaquinas Negocios = new NMaquinas();
            EMaquinas Obj = new EMaquinas();
            Obj = Negocios.Mostrar().Where(x => x.ID_maquina == Id).FirstOrDefault();
            if (Obj != null)
            {
                this.txt_codigo_maquina.Text = Obj.ID_maquina.ToString();
                this.txt_nombre_maquina.Text = Obj.Nombre_maquina;
                this.txt_ubicacion_maq.Text = Obj.Ubicacion_maquina;
                this.dtp_fecha_maq.Text = Obj.fecha_maquina.ToString();
            }
        }
        private void AgregarMaquinas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    this.LblMaquina.Visible = false;
                    this.txt_codigo_maquina.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    this.Text = "Modificar Loteria";
                    this.txt_codigo_maquina.Enabled = false;
                    llenar();
                    if (Accion == "C")
                    {
                        this.Text = "Consultar Loteria";
                        this.GrpMaquina.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_nombre_maquina.Text == "")
                {
                    errorProvider1.SetError(txt_nombre_maquina, "Debe llenar este campo!");
                    ok = true;
                }
                if (this.txt_ubicacion_maq.Text == "")
                {
                    errorProvider1.SetError(txt_ubicacion_maq, "Debe llenar este campo!");
                    ok = true;
                }
                //
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ok;
        }
        private void borrar_error()
        {
            try
            {
                errorProvider1.SetError(txt_nombre_maquina, "");
                errorProvider1.SetError(txt_ubicacion_maq, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "C")
                {
                    this.Close();
                }
                borrar_error();
                if (!validar())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        EMaquinas obj = new EMaquinas();
                        obj.Nombre_maquina = this.txt_nombre_maquina.Text;
                        obj.Ubicacion_maquina = this.txt_ubicacion_maq.Text;
                        obj.fecha_maquina = Convert.ToDateTime(this.dtp_fecha_maq.Text);
                        NMaquinas Negocios = new NMaquinas();
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Se agrego la maquina", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("La maquina se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo agregar la maquina!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            obj.ID_maquina = int.Parse(this.txt_codigo_maquina.Text);
                            FilasAfectadas = Negocios.Modificar(obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("maquina modificada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("La maquina se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo modificar la maquina!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
