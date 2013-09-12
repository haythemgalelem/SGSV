using System.Data;

namespace SGSV.DAL
{
    class EmpleadoDAL : ClsDAL
    {
        #region TipoEmpleado

        public static DataTable GetTiposEmpleado()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoEmpleado", true).Tables[0];
        }

        public static DataTable GetTiposEmpleado(string nombre)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoEmpleado", true, "@nombre", DALAux.GetValue(nombre)).Tables[0];
        }

        public static DataRow GetTipoEmpleado(int idTipoEmpleado)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_TipoEmpleado", true, "@idTipoEmpleado", DALAux.GetValue(idTipoEmpleado)).Tables[0].Rows[0];
        }

        public static void GuardarTipoEmpleado(int idTipoEmpleado, string nombre)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_TipoEmpleado", true,
                "@idTipoEmpleado", idTipoEmpleado,
                "@nombre", DALAux.GetValue(nombre));
        }

        #endregion TipoEmpleado

        #region Empleado

        public static DataTable GetEmpleados()
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Empleado", true).Tables[0];
        }

        public static DataTable GetEmpleados(int idTipoEmpleado, int idSucursal, string nombre, string apellido, string telefono, string email, int dni)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Empleado", true,
                "@idTipoEmpleado", DALAux.GetValue(idTipoEmpleado),
                "@idSucursal", DALAux.GetValue(idSucursal),
                "@nombre", DALAux.GetValue(nombre),
                "@apellido", DALAux.GetValue(apellido),
                "@telefono", DALAux.GetValue(telefono),
                "@email", DALAux.GetValue(email),
                "@dni", DALAux.GetValue(dni)).Tables[0];
        }

        public static DataRow GetEmpleado(int idEmpleado)
        {
            return Exec<DataSet>("dbo_sgsv.P_S_Empleado", true, "@idEmpleado", DALAux.GetValue(idEmpleado)).Tables[0].Rows[0];
        }

        public static void GuardarEmpleado(int idEmpleado, int idTipoEmpleado, int idSucursal, string nombre, string apellido, string telefono, string email, int dni)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_Empleado", true,
                "@idEmpleado", idEmpleado,
                "@idTipoEmpleado", idTipoEmpleado,
                "@idSucursal", idSucursal,
                "@nombre", nombre,
                "@apellido", apellido,
                "@telefono", telefono,
                "@email", email,
                "@dni", dni);
        }

        #endregion Empleado

    }
}
