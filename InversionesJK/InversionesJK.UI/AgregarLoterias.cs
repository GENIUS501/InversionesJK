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
        public AgregarLoterias()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (/*this.txt_codigo_loteria.Text != "" &&*/ this.txt_nombre_loteria.Text != "")
                {
                    ELoterias obj = new ELoterias();
                    obj.Nombre_loteria = this.txt_nombre_loteria.Text;
                    NLoterias Negocios = new NLoterias();
                    if(Negocios.Agregar(obj)>0)
                    {
                        MessageBox.Show("Se agrego la loteria", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("No se pudo agregar la loteria!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarLoterias_Load(object sender, EventArgs e)
        {
            try
            {
                this.LblCodigoLoteria.Visible = false;
                this.txt_codigo_loteria.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
