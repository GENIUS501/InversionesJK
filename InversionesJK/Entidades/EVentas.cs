using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EVentas
    {
        public int ID_venta { get; set; }
        public System.DateTime fecha_venta { get; set; }
        public double Cantidad_de_Venta { get; set; }
        public double Premio_a_pagar { get; set; }
        public double Apuesta { get; set; }
        public int Multiplicar_Apuesta { get; set; }
        public int ID_maquina { get; set; }
        public int Id_Usuario { get; set; }
        public int ID_loteria { get; set; }
    }
}
