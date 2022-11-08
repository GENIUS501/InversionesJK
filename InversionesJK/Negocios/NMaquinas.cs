using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NMaquinas
    {
        public int Agregar(EMaquinas obj, int Id_Usuario)
        {
            try
            {
                DMaquinas db = new DMaquinas();
                return db.Agregar(obj, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Modificar(EMaquinas obj, int Id_Usuario)
        {
            try
            {
                DMaquinas db = new DMaquinas();
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
                DMaquinas db = new DMaquinas();
                return db.Eliminar(Id, Id_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EMaquinas> Mostrar()
        {
            try
            {
                DMaquinas db = new DMaquinas();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
