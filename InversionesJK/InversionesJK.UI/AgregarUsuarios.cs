using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversionesJK.UI
{
    public partial class AgregarUsuarios : Form
    {
        public string Accion { get; set; }
        public int Id { get; set; }
        public int Usuario { get; set; }
        private string Clave = string.Empty;
        public AgregarUsuarios()
        {
            InitializeComponent();
        }
        private void llenar()
        {
            NUsuarios Negocios = new NUsuarios();
            EUsuarios Obj = new EUsuarios();
            Obj = Negocios.Mostrar().Where(x=>x.Id_Usuario==Id).FirstOrDefault();
            this.txt_cedula.Text = Obj.Cedula.ToString();
            this.txt_nombre.Text = Obj.Nombre;
            this.txt_correo.Text = Obj.Correo;
            this.txt_clave.Text = Obj.Clave;
            this.txt_user.Text = Obj.Usuario;
            this.cbo_rol.SelectedValue = Obj.Id_Rol.ToString();
            Clave = Obj.Clave;
        }
        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'inversionesJKDataSet.Roles' Puede moverla o quitarla según sea necesario.
                this.rolesTableAdapter.Fill(this.inversionesJKDataSet.Roles);
                if (Accion == "M" || Accion == "C")
                {
                    this.txt_cclave.Visible = false;
                    this.lbl_cclave.Visible = false;
                    //llenar();
                    if (Accion == "C")
                    {
                        this.groupBox1.Enabled = false;
                        //  this.groupBox3.Enabled = false;
                        // this.lst_telefono.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_cedula.Text.Length < 9)
                {
                    errorProvider1.SetError(this.txt_cedula, "Formato de cedula invalido.");
                    ok = true;
                }
                if (this.txt_user.Text == "")
                {
                    errorProvider1.SetError(this.txt_user, "Debe ingresar el nombre de usuario");
                    ok = true;
                }
                if (this.txt_nombre.Text == "")
                {
                    errorProvider1.SetError(this.txt_nombre, "Debe ingresar el nombre");
                    ok = true;
                }
                if (this.txt_correo.Text == "")
                {
                    errorProvider1.SetError(this.txt_correo, "Debe ingresar el correo");
                    ok = true;
                }
                if (this.txt_clave.Text != this.txt_cclave.Text && Accion == "A")
                {
                    errorProvider1.SetError(this.txt_cclave, "Las contraseñas no coinciden.");
                    ok = true;
                }
                Regex Regexa = new Regex(@"^(?=.*[\d])(?=.*[A-Z])(?=.*[a-z])[\w\d]{8,}$");
                Match Match = Regexa.Match(this.txt_clave.Text);
                if (Match.Success)
                {

                }
                else
                {
                    errorProvider1.SetError(this.txt_clave, "La contraseña debe de tener un mínimo de 8 caracteres, con lo siguiente: " +
                    "\n Al menos una mayúscula" +
                    "\n Al menos una minúscula" +
                    "\n Al menos un número" +
                    "\n No debe tener caracteres especiales ni espacios");
                    ok = true;
                }
                String expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(this.txt_correo.Text, expresion))
                {
                    if (Regex.Replace(this.txt_correo.Text, expresion, String.Empty).Length == 0)
                    {

                    }
                    else
                    {
                        errorProvider1.SetError(this.txt_correo, "Formato de correo invalido");
                        ok = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(this.txt_correo, "Formato de correo invalido");
                    ok = true;
                }
                //
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ok;
        }
        private void borrar_error()
        {
            try
            {
                errorProvider1.SetError(txt_cedula, "");
                errorProvider1.SetError(txt_nombre, "");
                errorProvider1.SetError(txt_clave, "");
                errorProvider1.SetError(txt_cclave, "");
                errorProvider1.SetError(txt_correo, "");
                errorProvider1.SetError(txt_user, "");
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
                if (Accion == "C")
                {
                    this.Close();
                }
                borrar_error();
                if (!validar())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        NUsuarios Negocios = new NUsuarios();
                        EUsuarios Obj = new EUsuarios();
                        Obj.Cedula = int.Parse(this.txt_cedula.Text);
                        Obj.Usuario = this.txt_user.Text;
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.Id_Rol = int.Parse(this.cbo_rol.SelectedValue.ToString());
                        Obj.Correo = this.txt_correo.Text;
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.Clave = Helper.EncodePassword(string.Concat(this.txt_user.Text.ToString(), this.txt_clave.ToString()));
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el Usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            Obj.Id_Usuario= Id;
                            if (this.txt_clave.Text != Clave)
                            {
                                Obj.Clave = Helper.EncodePassword(string.Concat(this.txt_user.Text.ToString(), this.txt_clave.ToString()));
                            }
                            else
                            {
                                Obj.Clave = "";
                            }
                            FilasAfectadas = Negocios.Modificar(Obj, Usuario);
                            MessageBox.Show("Usuario modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el Usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    #endregion

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
