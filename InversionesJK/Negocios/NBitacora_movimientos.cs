using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NBitacora_movimientos
    {
        public List<EBitacora_movimientos> Mostrar()
        {
            try
            {
                DBitacora_movimientos db = new DBitacora_movimientos();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
