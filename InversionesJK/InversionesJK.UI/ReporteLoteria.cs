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
    public partial class ReporteLoteria : Form
    {
        public string Usuario { get; set; }
        public ReporteLoteria()
        {
            InitializeComponent();
        }

        private void ReporteLoteria_Load(object sender, EventArgs e)
        {
            try
            {
                NLoterias Negocios = new NLoterias();
                this.dat_principal.DataSource = Negocios.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_id_loteria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_loteria.Text != "")
                {
                    NLoterias Negocios = new NLoterias();
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Nombre_loteria.Contains(this.txt_loteria.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_id_loteria.Text != "")
                {
                    int Id = int.Parse(this.txt_id_loteria.Text);
                    NLoterias Negocios = new NLoterias();
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.ID_loteria == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                NLoterias Negocios = new NLoterias();
                Renderizar(Negocios.Mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(List<ELoterias> Lista)
        {
            VisorReporteLoteria frm = new VisorReporteLoteria();
            frm.Usuario = Usuario;
            frm.MdiParent = this.MdiParent;
            frm.Lista = Lista;
            frm.Show();
        }

        private void btn_imprimir_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_loteria.Text != "")
                {
                    NLoterias Negocios = new NLoterias();
                    Renderizar(Negocios.Mostrar().Where(x => x.Nombre_loteria.Contains(this.txt_loteria.Text)).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_id_loteria.Text != "")
                {
                    int Id = int.Parse(this.txt_id_loteria.Text);
                    NLoterias Negocios = new NLoterias();
                    Renderizar(Negocios.Mostrar().Where(x => x.ID_loteria == Id).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
