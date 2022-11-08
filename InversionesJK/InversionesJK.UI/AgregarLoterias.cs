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
    public partial class AgregarLoterias : Form
    {
        #region Variables
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        #endregion
        public AgregarLoterias()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_nombre_loteria.Text == "")
                {
                    errorProvider1.SetError(txt_nombre_loteria, "Debe ingresar el nombre");
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
                errorProvider1.SetError(txt_nombre_loteria, "");
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
                        ELoterias obj = new ELoterias();
                        obj.Nombre_loteria = this.txt_nombre_loteria.Text;
                        NLoterias Negocios = new NLoterias();
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(obj,Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Se agrego la loteria", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("La loteria se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo agregar la loteria!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            obj.ID_loteria = int.Parse(this.txt_codigo_loteria.Text);
                            FilasAfectadas = Negocios.Modificar(obj,Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Loteria modificada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("La loteria se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo modificar la loteria!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void llenar()
        {
            NLoterias Negocios = new NLoterias();
            ELoterias Obj = new ELoterias();
            Obj = Negocios.Mostrar().Where(x=>x.ID_loteria==Id).FirstOrDefault();
            if (Obj != null)
            {
                this.txt_codigo_loteria.Text = Obj.ID_loteria.ToString();
                this.txt_nombre_loteria.Text = Obj.Nombre_loteria;
            }
        }
        private void AgregarLoterias_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    this.LblCodigoLoteria.Visible = false;
                    this.txt_codigo_loteria.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    this.Text = "Modificar Loteria";
                    this.txt_codigo_loteria.Enabled = false;
                    llenar();
                    if (Accion == "C")
                    {
                        this.Text = "Consultar Loteria";
                        this.GrpLoteria.Enabled = false;
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
