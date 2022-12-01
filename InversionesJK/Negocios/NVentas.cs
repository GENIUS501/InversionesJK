using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NVentas
    {
        public int Agregar(EVentas obj, int Id_Usuario)
        {
            try
            {
                DVentas db = new DVentas();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Modificar(EVentas obj, int Id_Usuario)
        {
            try
            {
                DVentas db = new DVentas();
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
                DVentas db = new DVentas();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EVentas> Mostrar()
        {
            try
            {
                DVentas db = new DVentas();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
