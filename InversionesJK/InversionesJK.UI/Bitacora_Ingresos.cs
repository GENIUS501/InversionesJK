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
    public partial class Bitacora_Ingresos : Form
    {
        public string Usuario { get; set; }
        public Bitacora_Ingresos()
        {
            InitializeComponent();
        }

        private void Bitacora_Ingresos_Load(object sender, EventArgs e)
        {
            try
            {
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                NUsuarios NegociosUsuarios = new NUsuarios();
                this.dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                {
                    x.codigo_ingreso_salida,
                    x.fecha_hora_ingreso,
                    x.fecha_hora_salida,
                    Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(List<EBitacora_Sesiones> Lista)
        {
            Visor_Bitacora_Ingresos frm = new Visor_Bitacora_Ingresos();
            frm.Usuario = Usuario;
            frm.Lista = Lista;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                Renderizar(Negocios.Mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = NegociosUsuarios.Mostrar().Where(y => y.Usuario.Contains(this.txt_usuario.Text)).FirstOrDefault().Id_Usuario;
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Id_Usuario == Id).Select(x => new
                    {
                        x.codigo_ingreso_salida,
                        x.fecha_hora_ingreso,
                        x.fecha_hora_salida,
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_fecha_ini.Text != "" && this.txt_fecha_fin.Text != "")
                {
                    NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var FechaIni = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    var FechaFin = Convert.ToDateTime(this.txt_fecha_fin.Text).AddHours(23).AddMinutes(59).AddSeconds(59);
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.fecha_hora_ingreso >= FechaIni && x.fecha_hora_ingreso <= FechaFin).Select(x => new
                    {
                        x.codigo_ingreso_salida,
                        x.fecha_hora_ingreso,
                        x.fecha_hora_salida,
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = NegociosUsuarios.Mostrar().Where(y => y.Usuario.Contains(this.txt_usuario.Text)).FirstOrDefault().Id_Usuario;
                    Renderizar(Negocios.Mostrar().Where(x => x.Id_Usuario == Id).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_fechas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_fecha_ini.Text != "" && this.txt_fecha_fin.Text != "")
                {
                    NBitacora_Sesiones Negocios = new NBitacora_Sesiones();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var FechaIni = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    var FechaFin = Convert.ToDateTime(this.txt_fecha_fin.Text).AddHours(23).AddMinutes(59).AddSeconds(59);
                    Renderizar(Negocios.Mostrar().Where(x => x.fecha_hora_ingreso >= FechaIni && x.fecha_hora_ingreso <= FechaFin).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
