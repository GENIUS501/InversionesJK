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
    public partial class Principal : Form
    {
        private AgregarUsuarios addUsers;
        private MostrarUsuarios showUsers;

        private AgregarRolesyPermisos addRols;
        private MostrarRolesyPermisos showRols;

        private AgregarLoterias addLotteries;
        private MostrarLoterias showLotteries;

        private AgregarMaquinas addMachines;
        private MostrarMaquinas showMachines;

        private AgregarVentas addSales;
        private MostrarVentas showSales;

        private ReporteMaquinas addReportMachines;
        private ReporteVentas addReportSales;
        private ReporteLoteria addReportLotteries;

        //private AcercaDe addAbout;
        private Ayuda addHelp;

        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addUsers = new AgregarUsuarios();
                addUsers.MdiParent = this;
                addUsers.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                showUsers = new MostrarUsuarios();
                showUsers.MdiParent = this;
                showUsers.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                addRols = new AgregarRolesyPermisos();
                addRols.MdiParent = this;
                addRols.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                showRols = new MostrarRolesyPermisos();
                showRols.MdiParent = this;
                showRols.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                addLotteries = new AgregarLoterias();
                addLotteries.MdiParent = this;
                addLotteries.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                showLotteries = new MostrarLoterias();
                showLotteries.MdiParent = this;
                showLotteries.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                addMachines = new AgregarMaquinas();
                addMachines.MdiParent = this;
                addMachines.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                showMachines = new MostrarMaquinas();
                showMachines.MdiParent = this;
                showMachines.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                addSales = new AgregarVentas();
                addSales.MdiParent = this;
                addSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                showSales = new MostrarVentas();
                showSales.MdiParent = this;
                showSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maquinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                addReportMachines = new ReporteMaquinas();
                addReportMachines.MdiParent = this;
                addReportMachines.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addReportSales = new ReporteVentas();
                addReportSales.MdiParent = this;
                addReportSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loteriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addReportLotteries = new ReporteLoteria();
                addReportLotteries.MdiParent = this;
                addReportLotteries.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                addHelp = new Ayuda();
                addHelp.MdiParent = this;
                addHelp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
