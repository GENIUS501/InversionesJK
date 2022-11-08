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

        private AcercaDe addAbout;
        private Ayuda addHelp;

        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUsers = new AgregarUsuarios();
            addUsers.MdiParent = this;
            addUsers.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUsers = new MostrarUsuarios();
            showUsers.MdiParent = this;
            showUsers.Show();

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addRols = new AgregarRolesyPermisos();
            addRols.MdiParent = this;
            addRols.Show();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showRols = new MostrarRolesyPermisos();
            showRols.MdiParent = this;
            showRols.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addLotteries = new AgregarLoterias();
            addLotteries.MdiParent = this;
            addLotteries.Show();
        }

        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            showLotteries = new MostrarLoterias();
            showLotteries.MdiParent = this;
            showLotteries.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            addMachines = new AgregarMaquinas();
            addMachines.MdiParent = this;
            addMachines.Show();
        }

        private void mostrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            showMachines = new MostrarMaquinas();
            showMachines.MdiParent = this;
            showMachines.Show();
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            addSales = new AgregarVentas();
            addSales.MdiParent = this;
            addSales.Show();
        }

        private void mostrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            showSales = new MostrarVentas();
            showSales.MdiParent = this;
            showSales.Show();
        }

        private void maquinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addReportMachines = new ReporteMaquinas();
            addReportMachines.MdiParent = this;
            addReportMachines.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addReportSales = new ReporteVentas();
            addReportSales.MdiParent = this;
            addReportSales.Show();
        }

        private void loteriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addReportLotteries = new ReporteLoteria();
            addReportLotteries.MdiParent = this;
            addReportLotteries.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAbout = new AcercaDe();
            addAbout.MdiParent = this;
            addAbout.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addHelp = new Ayuda();
            addHelp.MdiParent = this;
            addHelp.Show();
        }

        private void reingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
