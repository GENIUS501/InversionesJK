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
        public int Agregar(ELoterias obj,int Id_Usuario)
        {
            try
            {
                DLoterias db = new DLoterias();
                return db.Agregar(obj,Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Modificar(ELoterias obj, int Id_Usuario)
        {
            try
            {
                DLoterias db = new DLoterias();
                return db.Modificar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Eliminar(int Id, int Id_Usuario)
        {
            try
            {
                DLoterias db = new DLoterias();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ELoterias> Mostrar()
        {
            try
            {
                DLoterias db = new DLoterias();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
