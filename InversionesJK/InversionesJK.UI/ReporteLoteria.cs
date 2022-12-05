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
    }
}
