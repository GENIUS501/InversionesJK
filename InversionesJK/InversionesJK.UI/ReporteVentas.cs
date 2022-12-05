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
    public partial class ReporteVentas : Form
    {
        public string Usuario { get; set; }
       // public int IdUsuario { get; set; }
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            try
            {
                NVentas Negocios = new NVentas();
                this.dat_principal.DataSource = Negocios.Mostrar();
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
                if(this.txt_maquina.Text!="")
                {
                    NVentas Negocios = new NVentas();
                    int IdVenta = int.Parse(this.txt_maquina.Text);
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x=>x.ID_venta==IdVenta).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtp_fecha_maq.Text != "")
                {
                    NVentas Negocios = new NVentas();
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.fecha_venta==Convert.ToDateTime(dtp_fecha_maq.Value.ToString())).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                NVentas Negocios = new NVentas();
                Renderizar(Negocios.Mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(List<EVentas> Lista)
        {
            VisorReporteVentas frm = new VisorReporteVentas();
            frm.Usuario = Usuario;
            frm.Lista = Lista;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
