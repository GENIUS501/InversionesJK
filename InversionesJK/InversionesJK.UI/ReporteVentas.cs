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
                NLoterias NegociosLoterias = new NLoterias();
                NMaquinas NegociosMaquinas = new NMaquinas();
                NUsuarios NegociosUsuarios = new NUsuarios();
                this.dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                {
                    ID_venta = x.ID_venta,
                    fecha_venta = x.fecha_venta,
                    Cantidad_de_Venta = x.Cantidad_de_Venta,
                    Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                    Apuesta = x.Apuesta,
                    Porcentaje_Ganancia = x.Porcentaje_Ganancia + "%",
                    Premio_a_pagar = x.Premio_a_pagar,
                    Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).Select(y => y.Usuario).FirstOrDefault(),
                    Nombre_loteria = NegociosLoterias.Mostrar().Where(y => y.ID_loteria == x.ID_loteria).Select(y => y.Nombre_loteria).FirstOrDefault(),
                    Nombre_maquina = NegociosMaquinas.Mostrar().Where(y => y.ID_maquina == x.ID_maquina).Select(y => y.Nombre_maquina).FirstOrDefault(),
                    Comision = x.Cantidad_de_Venta * x.Porcentaje_Ganancia / 100
                }
                    ).ToList();
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
                if (this.txt_maquina.Text != "")
                {
                    NVentas Negocios = new NVentas();
                    int IdVenta = int.Parse(this.txt_maquina.Text);
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.ID_venta == IdVenta).ToList();
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
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.fecha_venta == Convert.ToDateTime(dtp_fecha_maq.Value.ToString())).ToList();
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
