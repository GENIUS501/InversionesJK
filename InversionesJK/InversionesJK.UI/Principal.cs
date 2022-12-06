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
                addSales.Accion = "A";
                addSales.Usuario = UsuarioLogueado.Id_Usuario;
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
                showSales.Usuario = UsuarioLogueado.Id_Usuario;
                showSales.Id_Rol = UsuarioLogueado.Id_Rol;
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
                addReportMachines.Usuario = UsuarioLogueado.Usuario;
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
                addReportSales.Usuario = UsuarioLogueado.Usuario;
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
                addReportLotteries.Usuario = UsuarioLogueado.Usuario;
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
                EBitacora_Sesiones Ses = new EBitacora_Sesiones();
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                Int32 FilasAfectadas;
                Ses.codigo_ingreso_salida = Idsession;
                Ses.fecha_hora_salida = DateTime.Now;
                FilasAfectadas = Negocios.Modificar(Ses);
                if (FilasAfectadas > 0)
                {
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }
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
                Cerrar();
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
                maquinasToolStripMenuItem1.Visible = false;
                loteriasToolStripMenuItem.Visible = false;
                ingresoYSalidasUsuariosToolStripMenuItem.Visible = false;
                movimientosToolStripMenuItem.Visible = false;
                agregarToolStripMenuItem2.Visible = false;
                agregarToolStripMenuItem3.Visible = false;
                agregarToolStripMenuItem1.Visible = false;
                agregarToolStripMenuItem.Visible = false;
                agregarToolStripMenuItem4.Visible = false;
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
                if (perm.Where(x => x.Modulo == "ReporteVentas" || x.Modulo == "ReporteMaquinas" || x.Modulo == "ReporteLoterias" || x.Modulo == "BitacoraSesiones" || x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    reportesToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteVentas").FirstOrDefault() != null)
                {
                    ventasToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteMaquinas").FirstOrDefault() != null)
                {
                    maquinasToolStripMenuItem1.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "ReporteLoterias").FirstOrDefault() != null)
                {
                    loteriasToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    ingresoYSalidasUsuariosToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    movimientosToolStripMenuItem.Visible = true;
                }   
                if (perm.Where(x => x.Modulo == "Loterias" && x.Accion=="Agregar").FirstOrDefault() != null)
                {
                    agregarToolStripMenuItem2.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Maquinas" && x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    agregarToolStripMenuItem3.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Roles" && x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    agregarToolStripMenuItem1.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Usuarios" && x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    agregarToolStripMenuItem.Visible = true;
                }
                if (perm.Where(x => x.Modulo == "Ventas" && x.Accion == "Agregar").FirstOrDefault() != null)
                {
                    agregarToolStripMenuItem4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void ingresoYSalidasUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora_Ingresos frm = new Bitacora_Ingresos();
                frm.Usuario = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cerrar()
        {
            try
            {
                EBitacora_Sesiones Ses = new EBitacora_Sesiones();
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                Int32 FilasAfectadas;
                Ses.codigo_ingreso_salida = Idsession;
                Ses.fecha_hora_salida = DateTime.Now;
                FilasAfectadas = Negocios.Modificar(Ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora_Movimientos frm = new Bitacora_Movimientos();
                frm.Usuario = UsuarioLogueado.Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
