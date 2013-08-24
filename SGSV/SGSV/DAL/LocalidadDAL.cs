using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SGSV.DAL
{
    class LocalidadDAL : ClsDAL
    {
        public static IEnumerable<Entidades.Localidad.Localidad> GetLocalidades()
        {
            return (from DataRow localidad in Exec<DataSet>("dbo.P_S_Localidad", true).Tables[0].Rows
                    select new Entidades.Localidad.Localidad
                    {
                        IdLocalidad = Convert.ToInt32(localidad["idLocalidad"].ToString()),
                        Nombre = localidad["nombre"].ToString()
                    }).ToList();
        }
        public static DataTable GetLocalidades(string nombre)
        {
            return Exec<DataSet>("dbo.P_S_Localidad", true, "@nombre", DALAux.GetValue(nombre)).Tables[0];
        }

        public static DataTable GetLocalidad(int idLocalidad)
        {
            return Exec<DataSet>("dbo.P_S_Localidad", true, "@idLocalidad", DALAux.GetValue(idLocalidad)).Tables[0];
        }

        public static void Guardar(int idLocalidad, string nombre)
        {
            Exec<DataSet>("dbo.P_IU_Localidad", true, "@idLocalidad", DALAux.GetValue(idLocalidad), "@nombre", DALAux.GetValue(nombre));
        }
    }
}
