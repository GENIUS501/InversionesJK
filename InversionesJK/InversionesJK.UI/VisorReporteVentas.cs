using Entidades;
using Microsoft.Reporting.WinForms;
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
    public partial class VisorReporteVentas : Form
    {
        public string Usuario { get; set; }
        public List<EVentas> Lista { get; set; }
        public VisorReporteVentas()
        {
            InitializeComponent();
        }

        private void VisorReporteVentas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Lista.Count > 0)
                {
                    NLoterias NegociosLoterias = new NLoterias();
                    NMaquinas NegociosMaquinas = new NMaquinas();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var datasource = Lista.Select(x => new
                    {
                        ID_venta = x.ID_venta,
                        Apuesta = x.Apuesta,
                        Cantidad_de_Venta = x.Cantidad_de_Venta,
                        fecha_venta = x.fecha_venta,
                        Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                        Porcentaje_Ganancia = x.Porcentaje_Ganancia + "%",
                        Premio_a_pagar = x.Premio_a_pagar,
                        Nombre_loteria = NegociosLoterias.Mostrar().Where(y => y.ID_loteria == x.ID_loteria).Select(y => y.Nombre_loteria).FirstOrDefault(),
                        Nombre_maquina = NegociosMaquinas.Mostrar().Where(y => y.ID_maquina == x.ID_maquina).Select(y => y.Nombre_maquina).FirstOrDefault(),
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).Select(y => y.Usuario).FirstOrDefault(),
                        Comision= x.Cantidad_de_Venta*x.Porcentaje_Ganancia/100
                    }
                    ).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                }
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
