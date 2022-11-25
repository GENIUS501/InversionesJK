using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccesoDatos
{
    public class DUsuarios
    {
        InversionesJKEntities db = new InversionesJKEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EUsuarios obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Usuarios Objbd = new Usuarios();
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Usuario = obj.Usuario;
                    Objbd.Clave = obj.Clave;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.Correo = "";
                    Objbd.Id_Rol = obj.Id_Rol;
                    db.Entry(Objbd).State = EntityState.Added;
                    //db.Tab_Usuarios.Add(Objbd);

                    db.SaveChanges();

                    int Resultado = Objbd.Id_Usuario;

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Usuarios";
                        Entidad_Movimientos.tipo_movimiento = "Agregar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    else
                    {
                        Ts.Dispose();
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EUsuarios obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Usuarios.Where(x => x.Id_Usuario == obj.Id_Usuario).FirstOrDefault();
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Usuario = obj.Usuario;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.Id_Rol = obj.Id_Rol;
                    if (obj.Clave == "")
                    {

                    }
                    else
                    {
                        Objbd.Clave = obj.Clave;
                    }
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Usuarios";
                        Entidad_Movimientos.tipo_movimiento = "Modificar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Usuarios.Where(x => x.Id_Usuario == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Usuarios";
                        Entidad_Movimientos.tipo_movimiento = "Eliminar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Mostrar varios
        public List<EUsuarios> Mostrar()
        {
            try
            {
                List<EUsuarios> Lista = new List<EUsuarios>();
                Lista = db.Usuarios
                .Select(x => new EUsuarios
                {
                    Cedula = x.Cedula,
                    Clave = x.Clave,
                    Id_Rol = x.Id_Rol,
                    Id_Usuario=x.Id_Usuario,
                    Usuario=x.Usuario,
                    Nombre = x.Nombre
            }).ToList();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Login
        public EUsuarios Login(string User, string Pass)
        {
            try
            {
                EUsuarios Obj = new EUsuarios();
                Obj = db.Usuarios
                .Select(x => new EUsuarios
                {
                    Cedula = x.Cedula,
                    Clave = x.Clave,
                    Id_Rol = x.Id_Rol,
                    Id_Usuario = x.Id_Usuario,
                    Usuario = x.Usuario,
                    Nombre = x.Nombre
                }).Where(x => x.Usuario == User && x.Clave == Pass).FirstOrDefault();
                return Obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
