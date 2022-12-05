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
    }
}
