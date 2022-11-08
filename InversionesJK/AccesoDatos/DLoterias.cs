using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccesoDatos
{
    public class DLoterias
    {
        InversionesJKEntities db = new InversionesJKEntities();
        public int Agregar(ELoterias obj)
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
    }
}
