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
    public partial class Principal : Form
    {
        public int Idsession { get; set; }
        public EUsuarios UsuarioLogueado { get; set; }

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
                addUsers.Accion = "A";
                addUsers.Usuario = UsuarioLogueado.Id_Usuario;
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
                showUsers.Usuario = UsuarioLogueado.Id_Usuario;
                showUsers.Id_Rol = UsuarioLogueado.Id_Rol;
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
                addRols.Accion = "A";
                addRols.Usuario = UsuarioLogueado.Id_Usuario;
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
                showRols.Usuario = UsuarioLogueado.Id_Usuario;
                showRols.Id_Rol = UsuarioLogueado.Id_Rol;
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
                addLotteries.Accion = "A";
                addLotteries.Usuario = UsuarioLogueado.Id_Usuario;
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
                showLotteries.Usuario = UsuarioLogueado.Id_Usuario;
                showLotteries.Id_Rol = UsuarioLogueado.Id_Rol;
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
                addMachines.Usuario = UsuarioLogueado.Id_Usuario;
                addMachines.Accion = "A";
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
                showMachines.Usuario = UsuarioLogueado.Id_Usuario;
                showMachines.Id_Rol = UsuarioLogueado.Id_Rol;
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
                Acercade Frm = new Acercade();
                Frm.MdiParent = this;
                Frm.Show();
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
                txt_usuario.Text = UsuarioLogueado.Usuario;
                List<EPermisos> perm = new List<EPermisos>();
                NRoles Negocios = new NRoles();
                usuariosToolStripMenuItem.Visible = false;
                rolesYPermisosToolStripMenuItem.Visible = false;
                registroLoteriaToolStripMenuItem.Visible = false;
                maquinasToolStripMenuItem.Visible = false;
                registroVentasToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                ventasToolStripMenuItem.Visible = false;
                perm = Negocios.llenar_Permisos(UsuarioLogueado.Id_Rol);
                if (perm.Where(x => x.Modulo == "Usuarios").FirstOrDefault() != null)
                {
                    usuariosToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Roles").FirstOrDefault() != null)
                {
                    rolesYPermisosToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Loterias").FirstOrDefault() != null)
                {
                    registroLoteriaToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Ventas").FirstOrDefault() != null)
                {
                    registroVentasToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Maquinas").FirstOrDefault() != null)
                {
                    maquinasToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteVentas").FirstOrDefault() != null)
                {
                    ventasToolStripMenuItem.Visible = true;
                }
                //UsuarioLogueado = new EUsuarios();
                //UsuarioLogueado.Id_Usuario = 1;
                //UsuarioLogueado.Id_Rol = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
