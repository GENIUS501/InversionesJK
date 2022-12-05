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
    public partial class ReporteMaquinas : Form
    {
        public string Usuario { get; set; }
        public ReporteMaquinas()
        {
            InitializeComponent();
        }

        private void ReporteMaquinas_Load(object sender, EventArgs e)
        {
            try
            {
                NMaquinas Negocios = new NMaquinas();
                this.dat_principal.DataSource = Negocios.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text!="")
                {
                    NMaquinas Negocios = new NMaquinas();
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x=>x.Nombre_maquina.Contains(this.txt_nombre.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_ubicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_ubi_maq.Text != "")
                {
                    NMaquinas Negocios = new NMaquinas();
                    this.dat_principal.DataSource = Negocios.Mostrar().Where(x => x.Ubicacion_maquina.Contains(this.txt_ubi_maq.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_todo_Click(object sender, EventArgs e)
        {
            try
            {
                NMaquinas Negocios = new NMaquinas();
                var Maquinas = Negocios.Mostrar();
                VisorReporteMaquinas FRM = new VisorReporteMaquinas();
                FRM.Usuario = Usuario;
                FRM.Lista = Negocios.Mostrar();
                FRM.MdiParent = this.MdiParent;
                FRM.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_maquina_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "")
                {
                    NMaquinas Negocios = new NMaquinas();
                    Renderizar(Negocios.Mostrar().Where(x => x.Nombre_maquina.Contains(this.txt_nombre.Text)).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Renderizar(List<EMaquinas> Lista)
        {
            VisorReporteMaquinas FRM = new VisorReporteMaquinas();
            FRM.Usuario = Usuario;
            FRM.Lista = Lista;
            FRM.MdiParent = this.MdiParent;
            FRM.Show();
        }

        private void btn_ubicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_ubi_maq.Text != "")
                {
                    NMaquinas Negocios = new NMaquinas();
                    Renderizar(Negocios.Mostrar().Where(x => x.Ubicacion_maquina.Contains(this.txt_ubi_maq.Text)).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
