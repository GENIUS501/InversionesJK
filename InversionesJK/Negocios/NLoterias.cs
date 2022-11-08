using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NLoterias
    {
        public int Agregar(ELoterias obj)
        {
            try
            {
                DLoterias db = new DLoterias();
                return db.Agregar(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
