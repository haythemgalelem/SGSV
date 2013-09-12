using System.Data;

namespace SGSV.DAL
{
    class SucursalDAL : ClsDAL
    {
        public static DataTable GetSucursales()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true).Tables[0];
        }

        public static DataTable GetSucursales(int idLocalidad, string nombre, string direccion, string telefono, string email, string codigoPostal)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true,
                "@idLocalidad", DALAux.GetValue(idLocalidad),
                "@nombre", DALAux.GetValue(nombre),
                "@direccion", DALAux.GetValue(direccion),
                "@telefono", DALAux.GetValue(telefono),
                "@email", DALAux.GetValue(email),
                "@codigoPostal", DALAux.GetValue(codigoPostal)).Tables[0];
        }

        public static DataRow GetSucursal(int idSucursal)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true, "@idSucursal", DALAux.GetValue(idSucursal)).Tables[0].Rows[0];
        }

        public static void GuardarSucursal(int idSucursal, int idLocalidad, string nombre, string direccion, string telefono, string email, string codigoPostal)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_Sucursal", true,
                "@idSucursal", idSucursal,
                "@idLocalidad", idLocalidad,
                "@nombre", nombre,
                "@direccion", direccion,
                "@telefono", telefono,
                "@email", email,
                "@codigoPostal", codigoPostal);
        }
    }
}
