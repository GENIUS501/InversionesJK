using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NUsuarios
    {
        #region Agregar
        public int Agregar(EUsuarios obj, int IdUsuario)
        {
            try
            {
                DUsuarios db = new DUsuarios();
                return db.Agregar(obj, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EUsuarios obj, int IdUsuario)
        {
            try
            {
                DUsuarios db = new DUsuarios();
                return db.Modificar(obj, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar

        public int Eliminar(int ID, int IdUsuario)
        {
            try
            {
                DUsuarios db = new DUsuarios();
                return db.Eliminar(ID, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar varios.
        public List<EUsuarios> Mostrar()
        {
            try
            {
                DUsuarios db = new DUsuarios();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EUsuarios Login(string User, string Pass)
        {
            try
            {
                DUsuarios db = new DUsuarios();
                return db.Login(User, Pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
