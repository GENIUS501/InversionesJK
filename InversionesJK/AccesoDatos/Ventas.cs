//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
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
    
        public virtual Loterias Loterias { get; set; }
        public virtual Maquinas Maquinas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}