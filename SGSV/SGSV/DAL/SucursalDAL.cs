using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SGSV.DAL
{
    class SucursalDAL : ClsDAL
    {

        public static void Guardar(int idSucursal, string nombre, string direccion, int idLocalidad, string telefono, string email, string codigoPostal)
        {
            Exec<DataSet>("dbo_sgsv.P_IU_Sucursal", true, "@idSucursal", idSucursal,
                                                          "@nombre", nombre,
                                                          "@direccion", direccion,
                                                          "@idLocalidad", idLocalidad, 
                                                          "@telefono", telefono,
                                                          "@email", email,
                                                          "@codigo_postal", codigoPostal);
        }

        public static IEnumerable<Entidades.Sucursal.Sucursal> GetLocalidadesSinFiltro()
        {
            return (from DataRow sucursal in Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true, "@inhabilitado", '0').Tables[0].Rows
                    select new Entidades.Sucursal.Sucursal
                    {   idSucursal = Convert.ToInt32(sucursal["idSucursal"].ToString()),
                        idLocalidad = Convert.ToInt32(sucursal["idLocalidad"].ToString()),
                        nombre = sucursal["nombreSucursal"].ToString(),
                        direccion = sucursal["direccion"].ToString(),
                        localidad = sucursal["nombreLocalidad"].ToString(),
                        telefono = sucursal["telefono"].ToString(),
                        codigoPostal = sucursal["codigoPostal"].ToString(),
                        email = sucursal["email"].ToString(),
                        inhabilitado = sucursal["inhabilitado"].ToString()
                    }).ToList();
        }

        public static IEnumerable<Entidades.Sucursal.Sucursal> GetLocalidadesConFiltro(int idLocalidad, char flagInhabilitado)
        {
            if(flagInhabilitado == '0')
            {
                return
                    (from DataRow sucursal in Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true, "@idLocalidad", idLocalidad,
                                                            "@inhabilitado", flagInhabilitado).Tables[0].Rows
                     select new Entidades.Sucursal.Sucursal
                                {
                                    idSucursal = Convert.ToInt32(sucursal["idSucursal"].ToString()),
                                    idLocalidad = Convert.ToInt32(sucursal["idLocalidad"].ToString()),
                                    nombre = sucursal["nombreSucursal"].ToString(),
                                    direccion = sucursal["direccion"].ToString(),
                                    localidad = sucursal["nombreLocalidad"].ToString(),
                                    telefono = sucursal["telefono"].ToString(),
                                    codigoPostal = sucursal["codigoPostal"].ToString(),
                                    email = sucursal["email"].ToString(),
                                    inhabilitado = sucursal["inhabilitado"].ToString()
                                }).ToList();

            }else
            {
                return
                    (from DataRow sucursal in Exec<DataSet>("dbo_sgsv.P_S_Sucursal", true, "@idLocalidad", idLocalidad).Tables[0].Rows
                     select new Entidades.Sucursal.Sucursal
                     {
                         idSucursal = Convert.ToInt32(sucursal["idSucursal"].ToString()),
                         idLocalidad = Convert.ToInt32(sucursal["idLocalidad"].ToString()),
                         nombre = sucursal["nombreSucursal"].ToString(),
                         direccion = sucursal["direccion"].ToString(),
                         localidad = sucursal["nombreLocalidad"].ToString(),
                         telefono = sucursal["telefono"].ToString(),
                         codigoPostal = sucursal["codigoPostal"].ToString(),
                         email = sucursal["email"].ToString(),
                         inhabilitado = sucursal["inhabilitado"].ToString()
                     }).ToList();                
            }
        }

        public static void BajaLogicaSucursal(int idSucursal)
        {
            Exec<DataSet>("dbo_sgsv.P_B_Sucursal", true, "@idSucursal", idSucursal);
        }

    }
}
