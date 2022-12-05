﻿using Entidades;
using Microsoft.Reporting.WinForms;
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
    public partial class VisorReporteMaquinas : Form
    {
        public string Usuario { get; set; }
        public List<EMaquinas> Lista { get; set; }
        public VisorReporteMaquinas()
        {
            InitializeComponent();
        }

        private void VisorReporteMaquinas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Lista.Count > 0)
                {
                    ReportDataSource Rds = new ReportDataSource("DataSet1", Lista);
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