using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class EUsuarios
    {
        public int Id_Usuario { get; set; }
        public int Cedula { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int Id_Rol { get; set; }
    }
}
