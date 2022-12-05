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
    public partial class Visor_Bitacora_Ingresos : Form
    {
        public string Usuario { get; set; }
        public List<EBitacora_Sesiones> Lista { get; set; }
        public Visor_Bitacora_Ingresos()
        {
            InitializeComponent();
        }

        private void Visor_Bitacora_Ingresos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Lista.Count > 0)
                {
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var datasource = Lista.Select(x => new
                    {
                        codigo_ingreso_salida = x.codigo_ingreso_salida.ToString(),
                        fecha_hora_ingreso = x.fecha_hora_ingreso,
                        fecha_hora_salida = x.fecha_hora_salida,
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                    }
                    ).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                }
                ReportParameter[] parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("Usuario", Usuario.ToString());
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
