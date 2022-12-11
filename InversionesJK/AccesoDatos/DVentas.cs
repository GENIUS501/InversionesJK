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
    public class DVentas
    {
        InversionesJKEntities db = new InversionesJKEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EVentas obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Ventas Objbd = new Ventas();
                    Objbd.Apuesta = obj.Apuesta;
                    Objbd.Cantidad_de_Venta = obj.Cantidad_de_Venta;
                    Objbd.fecha_venta = obj.fecha_venta;
                    Objbd.ID_loteria = obj.ID_loteria;
                    Objbd.ID_maquina = obj.ID_maquina;
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Multiplicar_Apuesta = obj.Multiplicar_Apuesta;
                    Objbd.Premio_a_pagar = obj.Premio_a_pagar;
                    Objbd.Porcentaje_Ganancia = obj.Porcentaje_Ganancia;
                    db.Ventas.Add(Objbd);

                    int Resultado = db.SaveChanges();

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Ventas";
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
        public List<EVentas> Mostrar()
        {
            try
            {
                List<EVentas> Lista = new List<EVentas>();
                Lista = db.Ventas
                .Select(x => new EVentas
                {
                    ID_venta = x.ID_venta,
                    ID_maquina = x.ID_maquina,
                    Apuesta = x.Apuesta,
                    Cantidad_de_Venta = x.Cantidad_de_Venta,
                    fecha_venta = x.fecha_venta,
                    ID_loteria = x.ID_loteria,
                    Id_Usuario = x.Id_Usuario,
                    Multiplicar_Apuesta = x.Multiplicar_Apuesta,
                    Premio_a_pagar = x.Premio_a_pagar,
                    Porcentaje_Ganancia = x.Porcentaje_Ganancia
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
        public int Modificar(EVentas obj, int Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Ventas.Where(x => x.ID_venta == obj.ID_venta).FirstOrDefault();
                    Objbd.Apuesta = obj.Apuesta;
                    Objbd.Cantidad_de_Venta = obj.Cantidad_de_Venta;
                    Objbd.fecha_venta = obj.fecha_venta;
                    Objbd.ID_loteria = obj.ID_loteria;
                    Objbd.ID_maquina = obj.ID_maquina;
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Multiplicar_Apuesta = obj.Multiplicar_Apuesta;
                    Objbd.Premio_a_pagar = obj.Premio_a_pagar;
                    Objbd.Porcentaje_Ganancia = obj.Porcentaje_Ganancia;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Ventas";
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
                    var Sesiones = db.Bitacora_ingreso_salida.Where(x => x.Id_Usuario == ID).FirstOrDefault();
                    if(Sesiones != null) db.Entry(Sesiones).State = EntityState.Deleted;
                    var Movimientosa = db.Bitacora_movimientos.Where(x => x.Id_Usuario == ID).FirstOrDefault();
                    if (Movimientosa != null) db.Entry(Movimientosa).State = EntityState.Deleted;
                    var Objbd = db.Ventas.Where(x => x.ID_venta == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Ventas";
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
