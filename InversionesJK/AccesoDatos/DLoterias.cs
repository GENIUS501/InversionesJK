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
    public class DLoterias
    {
        InversionesJKEntities db = new InversionesJKEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(ELoterias obj,int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Loterias Objbd = new Loterias();
                    Objbd.ID_loteria = obj.ID_loteria;
                    Objbd.Nombre_loteria = obj.Nombre_loteria;
                    db.Loterias.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Loterias";
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
        public List<ELoterias> Mostrar()
        {
            try
            {
                List<ELoterias> Lista = new List<ELoterias>();
                Lista = db.Loterias
                .Select(x => new ELoterias
                {
                    ID_loteria = x.ID_loteria,
                    Nombre_loteria = x.Nombre_loteria,
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
        public int Modificar(ELoterias obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Loterias.Where(x => x.ID_loteria == obj.ID_loteria).FirstOrDefault();
                    Objbd.ID_loteria = obj.ID_loteria;
                    Objbd.Nombre_loteria = obj.Nombre_loteria;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Loterias";
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
                    var Objbd = db.Loterias.Where(x => x.ID_loteria == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Loterias";
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
