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
                this.dat_principal.DataSource = Negocios.Mostrar().Select(x => new
                {
                    ID_venta = x.codigo_ingreso_salida,
                    fecha_venta = x.fecha_hora_ingreso,
                    Cantidad_de_Venta = x.fecha_hora_salida,
                    Multiplicar_Apuesta = x.Id_Usuario
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
