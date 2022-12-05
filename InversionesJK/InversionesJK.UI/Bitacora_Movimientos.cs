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
    public partial class Bitacora_Movimientos : Form
    {
        public string Usuario { get; set; }
        public Bitacora_Movimientos()
        {
            InitializeComponent();
        }

        private void Bitacora_Movimientos_Load(object sender, EventArgs e)
        {
            try
            {
                NBitacora_movimientos Negocios = new NBitacora_movimientos();
                NUsuarios NegociosUsuarios = new NUsuarios();
                this.dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                {
                    x.codigo_movimiento_usuario,
                    x.fecha_hora_movimiento,
                    x.modulo,
                    x.tipo_movimiento,
                    Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                NBitacora_movimientos Negocios = new NBitacora_movimientos();
                Renderizar(Negocios.Mostrar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(List<EBitacora_movimientos> Lista)
        {
            Visor_Bitacora_Movimientos frm = new Visor_Bitacora_Movimientos();
            frm.Usuario = Usuario;
            frm.Lista = Lista;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txt_usuario.Text!="")
                {
                    NBitacora_movimientos Negocios = new NBitacora_movimientos();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = NegociosUsuarios.Mostrar().Where(y => y.Usuario.Contains(this.txt_usuario.Text)).FirstOrDefault().Id_Usuario;
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(j=>j.Id_Usuario==Id).Select(x => new
                    {
                        x.codigo_movimiento_usuario,
                        x.fecha_hora_movimiento,
                        x.modulo,
                        x.tipo_movimiento,
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    NBitacora_movimientos Negocios = new NBitacora_movimientos();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    int Id = NegociosUsuarios.Mostrar().Where(y => y.Usuario.Contains(this.txt_usuario.Text)).FirstOrDefault().Id_Usuario;
                    Renderizar(Negocios.Mostrar().Where(j => j.Id_Usuario == Id).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_accion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_Accion.SelectedItem.ToString()!="")
                {
                    if(this.cbo_Accion.SelectedItem.ToString()=="Todas")
                    {
                        NBitacora_movimientos Negocios = new NBitacora_movimientos();
                        NUsuarios NegociosUsuarios = new NUsuarios();
                        this.dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                        {
                            x.codigo_movimiento_usuario,
                            x.fecha_hora_movimiento,
                            x.modulo,
                            x.tipo_movimiento,
                            Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                        }).ToList();
                    }
                    else
                    {
                        NBitacora_movimientos Negocios = new NBitacora_movimientos();
                        NUsuarios NegociosUsuarios = new NUsuarios();
                        this.dat_principal.DataSource = Negocios.Mostrar().Where(j=>j.tipo_movimiento==this.cbo_Accion.SelectedItem.ToString()).Select(x => new
                        {
                            x.codigo_movimiento_usuario,
                            x.fecha_hora_movimiento,
                            x.modulo,
                            x.tipo_movimiento,
                            Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                        }).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_accion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_Accion.SelectedItem.ToString() != "")
                {
                    if (this.cbo_Accion.SelectedItem.ToString() == "Todas")
                    {
                        NBitacora_movimientos Negocios = new NBitacora_movimientos();
                        NUsuarios NegociosUsuarios = new NUsuarios();
                        Renderizar(Negocios.Mostrar());
                    }
                    else
                    {
                        NBitacora_movimientos Negocios = new NBitacora_movimientos();
                        NUsuarios NegociosUsuarios = new NUsuarios();
                        Renderizar(Negocios.Mostrar().Where(j => j.tipo_movimiento == this.cbo_Accion.SelectedItem.ToString()).ToList());
                    }
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
                    NBitacora_movimientos Negocios = new NBitacora_movimientos();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var FechaIni = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    var FechaFin = Convert.ToDateTime(this.txt_fecha_fin.Text).AddHours(23).AddMinutes(59).AddSeconds(59);
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.fecha_hora_movimiento >= FechaIni && x.fecha_hora_movimiento <= FechaFin).Select(x => new
                    {
                        x.codigo_movimiento_usuario,
                        x.fecha_hora_movimiento,
                        x.modulo,
                        x.tipo_movimiento,
                        Usuario = NegociosUsuarios.Mostrar().Where(y => y.Id_Usuario == x.Id_Usuario).FirstOrDefault().Usuario
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_fecha_ini.Text != "" && this.txt_fecha_fin.Text != "")
                {
                    NBitacora_movimientos Negocios = new NBitacora_movimientos();
                    NUsuarios NegociosUsuarios = new NUsuarios();
                    var FechaIni = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    var FechaFin = Convert.ToDateTime(this.txt_fecha_fin.Text).AddHours(23).AddMinutes(59).AddSeconds(59);
                    Renderizar(Negocios.Mostrar().Where(x => x.fecha_hora_movimiento >= FechaIni && x.fecha_hora_movimiento <= FechaFin).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
