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
    public partial class AgregarRolesyPermisos : Form
    {
        public int Usuario { get; set; }
        public int Id { get; set; }
        public string Accion { get; set; }
        public AgregarRolesyPermisos()
        {
            InitializeComponent();
        }

        #region llenar Permisos
        private void Llenar()
        {
            try
            {
                NRoles Negocios = new NRoles();
                List<EPermisos> Permisos = new List<EPermisos>();
                ERoles Rol = new ERoles();
                Permisos = Negocios.llenar_Permisos(Id);
                Rol = Negocios.Mostrar().Where(x=>x.Id_Rol==Id).FirstOrDefault();
                this.txt_id_perfil.Text = Rol.Id_Rol.ToString();
                this.txt_nombre_perfil.Text = Rol.Nombre_rol.ToString();
                #region Roles 1
                ////////Roles//1////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Roles").FirstOrDefault() != null)
                {
                    this.grp_roles.Enabled = true;
                    this.chb_rol.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_rol_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_rol_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_rol_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Roles" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_rol_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_rol_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Usuarios 2
                ////////Usuarios//2////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Usuarios").FirstOrDefault() != null)
                {
                    this.grp_usuarios.Enabled = true;
                    this.chb_usuarios.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Usuarios" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_usuarios_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_usuarios_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Ventas 3
                ////////Ventas//3////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Ventas").FirstOrDefault() != null)
                {
                    this.grp_ventas.Enabled = true;
                    this.chb_ventas.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Ventas" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_ventas_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_ventas_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Ventas" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_ventas_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_ventas_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Ventas" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_ventas_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_ventas_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Ventas" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_ventas_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_ventas_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Loterias
                ////////Loterias//////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Loterias").FirstOrDefault() != null)
                {
                    this.grp_loterias.Enabled = true;
                    this.chb_loterias.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Loterias" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_loterias_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_loterias_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Loterias" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_loterias_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_loterias_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Loterias" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_loterias_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_loterias_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Loterias" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_loterias_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_loterias_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Maquinas 5
                ////////Maquinas//5////////////////////////////////////
                if (Permisos.Where(x => x.Modulo == "Maquinas").FirstOrDefault() != null)
                {
                    this.grp_maquinas.Enabled = true;
                    this.chb_maquinas.Checked = true;
                    if (Permisos.Where(x => x.Modulo == "Maquinas" && x.Accion == "Agregar").FirstOrDefault() != null)
                    {
                        this.chk_maquinas_agregar.Checked = true;
                    }
                    else
                    {
                        this.chk_maquinas_agregar.Checked = false;
                    }
                    ///
                    if (Permisos.Where(x => x.Modulo == "Maquinas" && x.Accion == "Consultar").FirstOrDefault() != null)
                    {
                        this.chk_maquinas_consultar.Checked = true;
                    }
                    else
                    {
                        this.chk_maquinas_consultar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Maquinas" && x.Accion == "Eliminar").FirstOrDefault() != null)
                    {
                        this.chk_maquinas_eliminar.Checked = true;
                    }
                    else
                    {
                        this.chk_maquinas_eliminar.Checked = false;
                    }
                    /////
                    if (Permisos.Where(x => x.Modulo == "Maquinas" && x.Accion == "Modificar").FirstOrDefault() != null)
                    {
                        this.chk_maquinas_modificar.Checked = true;
                    }
                    else
                    {
                        this.chk_maquinas_modificar.Checked = false;
                    }
                }
                else
                {

                }
                #endregion
                #region Reporte de ventas
                if (Permisos.Where(x => x.Modulo == "ReporteVentas").FirstOrDefault() != null)
                {
                    this.chb_ventas_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de maquinas
                if (Permisos.Where(x => x.Modulo == "ReporteMaquinas").FirstOrDefault() != null)
                {
                    this.chb_maquinas_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Reporte de cantidad
                if (Permisos.Where(x => x.Modulo == "ReporteLoterias").FirstOrDefault() != null)
                {
                    this.chb_loteria_reporte.Checked = true;
                }
                else
                {

                }
                #endregion
                #region Bitacora de sesiones
                if (Permisos.Where(x => x.Modulo == "BitacoraSesiones").FirstOrDefault() != null)
                {
                    this.chb_bit_sesiones.Checked = true;
                }
                else
                {

                }
                #endregion              
                #region Bitacora de Movimientos
                if (Permisos.Where(x => x.Modulo == "BitacoraMovimientos").FirstOrDefault() != null)
                {
                    this.chb_bit_movimientos.Checked = true;
                }
                else
                {

                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Agregar Permisos
        private List<EPermisos> Permisos(int Id_Rol)
        {
            try
            {
                List<EPermisos> Lista_Permisos = new List<EPermisos>();
                EPermisos Permisos = new EPermisos();
                ///////////////////Roles/////////////////////////////////////////////////////////////////////////////
                if (this.chb_rol.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Roles";
                    Permisos.Accion = "Roles";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_roles.Enabled == true)
                    {
                        if (chk_rol_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_rol_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Roles";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }

                /////////Usuarios/////////////////////////////////////////////////////////////////////////////
                if (this.chb_usuarios.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Usuarios";
                    Permisos.Accion = "Usuarios";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_usuarios.Enabled == true)
                    {
                        if (chk_usuarios_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_usuarios_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Usuarios";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Loterias//////3///////////////////////////////////////////////////////////////////////
                if (this.chb_loterias.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Loterias";
                    Permisos.Accion = "Loterias";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_loterias.Enabled == true)
                    {
                        if (chk_loterias_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Loterias";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_loterias_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Loterias";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_loterias_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Loterias";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_loterias_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Loterias";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Maquinas/////////////////////////////////////////////////////////////////////////////
                if (this.chb_maquinas.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Maquinas";
                    Permisos.Accion = "Maquinas";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_maquinas.Enabled == true)
                    {
                        if (chk_maquinas_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Maquinas";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_maquinas_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Maquinas";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_maquinas_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Maquinas";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_maquinas_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Maquinas";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                /////////Ventas//////5///////////////////////////////////////////////////////////////////////
                if (this.chb_ventas.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "Ventas";
                    Permisos.Accion = "Ventas";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                    if (this.grp_ventas.Enabled == true)
                    {
                        if (chk_ventas_agregar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Ventas";
                            Permisos.Accion = "Agregar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_ventas_modificar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Ventas";
                            Permisos.Accion = "Modificar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_ventas_eliminar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Ventas";
                            Permisos.Accion = "Eliminar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                        if (chk_ventas_consultar.Checked == true)
                        {
                            Permisos.Id_Rol = Id_Rol;
                            Permisos.Modulo = "Ventas";
                            Permisos.Accion = "Consultar";
                            Lista_Permisos.Add(Permisos);
                            Permisos = new EPermisos();
                        }
                    }
                }
                if (this.chb_ventas_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteVentas";
                    Permisos.Accion = "ReporteVentas";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reportes_Maquinas////10//////////////////////////////////////////////////////////////////////////////////
                if (this.chb_maquinas_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteMaquinas";
                    Permisos.Accion = "ReporteMaquinas";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Reporte_Loterias//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_loteria_reporte.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "ReporteLoterias";
                    Permisos.Accion = "ReporteLoterias";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_sesiones//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_sesiones.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraSesiones";
                    Permisos.Accion = "BitacoraSesiones";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                ////////Bitacora_movimientos//////////////////////////////////////////////////////////////////////////////////////
                if (this.chb_bit_movimientos.Checked == true)
                {
                    Permisos.Id_Rol = Id_Rol;
                    Permisos.Modulo = "BitacoraMovimientos";
                    Permisos.Accion = "BitacoraMovimientos";
                    Lista_Permisos.Add(Permisos);
                    Permisos = new EPermisos();
                }
                return Lista_Permisos;
            }
            catch (Exception)
            {
                return new List<EPermisos>();
            }
        }
        #endregion
        private void BorrarMensajesError()
        {
            try
            {
                errorProvider1.SetError(txt_nombre_perfil, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        private bool ValidarCampos()
        {
            try
            {
                bool ok = true;

                if (txt_nombre_perfil.Text == "")
                {
                    ok = false;
                    errorProvider1.SetError(txt_nombre_perfil, "Ingrese el nombre del perfil");
                }

                return ok;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    BorrarMensajesError();
                    if (this.ValidarCampos())
                    {
                        if (Accion == "A" || Accion == "M")
                        {
                            NRoles Negocios = new NRoles();
                            ERoles Rol = new ERoles();
                            Int32 FilasAfectadas = 0;
                            Rol.Nombre_rol = this.txt_nombre_perfil.Text;
                            if (Accion == "A")
                            {
                                FilasAfectadas = Negocios.Agregar(Rol, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    var Permi = Permisos(FilasAfectadas);
                                    Negocios.AgregarPermisos(Permi, FilasAfectadas);
                                    MessageBox.Show("Rol agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (Accion == "M")
                            {
                                Rol.Id_Rol = int.Parse(this.txt_id_perfil.Text);
                                FilasAfectadas = Negocios.Modificar(Rol, Usuario);
                                var Permi = Permisos(int.Parse(this.txt_id_perfil.Text));
                                Negocios.AgregarPermisos(Permi, int.Parse(this.txt_id_perfil.Text));
                                MessageBox.Show("Rol modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        if (Accion == "C")
                        {
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarRolesyPermisos_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    this.Lbl_Perfil.Visible = false;
                    this.txt_id_perfil.Visible = false;
                }
                if (Accion == "M" || Accion == "C")
                {
                    Llenar();
                    this.txt_id_perfil.Enabled = false;
                    if (Accion == "C")
                    {
                        this.groupBox1.Enabled = false;
                        this.groupBox2.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_rol_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_rol.Checked == true)
                {
                    grp_roles.Enabled = true;
                }
                else
                {
                    grp_roles.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_usuarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_usuarios.Checked == true)
                {
                    grp_usuarios.Enabled = true;
                }
                else
                {
                    grp_usuarios.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_loterias_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_loterias.Checked == true)
                {
                    grp_loterias.Enabled = true;
                }
                else
                {
                    grp_loterias.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_maquinas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_maquinas.Checked == true)
                {
                    grp_maquinas.Enabled = true;
                }
                else
                {
                    grp_maquinas.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_ventas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_ventas.Checked == true)
                {
                    grp_ventas.Enabled = true;
                }
                else
                {
                    grp_ventas.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
