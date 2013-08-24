using System;

namespace SGSV.DAL
{
    class DALAux : ClsDAL
    {
        internal static object GetValue(int valor)
        {
            if (valor == 0)
                return DBNull.Value;
            return valor;
        }

        internal static object GetValue(string valor)
        {
            if (valor == string.Empty)
                return DBNull.Value;
            return valor;
        }
    }
}
