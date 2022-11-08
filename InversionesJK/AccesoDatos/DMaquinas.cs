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
    public class DMaquinas
    {
        InversionesJKEntities db = new InversionesJKEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EMaquinas obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Maquinas Objbd = new Maquinas();
                    Objbd.Nombre_maquina = obj.Nombre_maquina;
                    Objbd.Ubicacion_maquina = obj.Ubicacion_maquina;
                    Objbd.fecha_maquina = obj.fecha_maquina;
                    db.Maquinas.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Maquinas";
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

        #region Mostrar
        public List<EMaquinas> Mostrar()
        {
            try
            {
                List<EMaquinas> Lista = new List<EMaquinas>();
                Lista = db.Maquinas
                .Select(x => new EMaquinas
                {
                    ID_maquina = x.ID_maquina,
                    Nombre_maquina = x.Nombre_maquina,
                    Ubicacion_maquina = x.Ubicacion_maquina,
                    fecha_maquina = x.fecha_maquina
                }).ToList();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EMaquinas obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Maquinas.Where(x => x.ID_maquina == obj.ID_maquina).FirstOrDefault();
                    Objbd.Nombre_maquina = obj.Nombre_maquina;
                    Objbd.Ubicacion_maquina = obj.Ubicacion_maquina;
                    Objbd.fecha_maquina = obj.fecha_maquina;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Maquinas";
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
                    var Objbd = db.Maquinas.Where(x => x.ID_maquina == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Maquinas";
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
    }
}
