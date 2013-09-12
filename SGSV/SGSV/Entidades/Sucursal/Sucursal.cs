using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using SGSV.DAL;

namespace SGSV.Entidades.Sucursal
{
    class Sucursal
    {
        public int IdSucursal { get; set; }
        public Localidad.Localidad Localidad { get; set; }
        [DisplayName("Localidad")]
        public string NombreLocalidad { get { return Localidad != null ? Localidad.Nombre : ""; } }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CodigoPostal { get; set; }

        public Sucursal()
        {
        }

        public Sucursal(int idSucursal)
        {
            Cargar(idSucursal);
        }

        public void Cargar(int idSucursal)
        {
            var sucursal = SucursalDAL.GetSucursal(idSucursal);
            IdSucursal = Convert.ToInt32(sucursal["idSucursal"].ToString());
            Localidad = new Localidad.Localidad(Convert.ToInt32(sucursal["idLocalidad"].ToString()));
            Nombre = sucursal["nombre"].ToString();
            Direccion = sucursal["direccion"].ToString();
            Telefono = sucursal["telefono"].ToString();
            Email = sucursal["email"].ToString();
            CodigoPostal = sucursal["codigoPostal"].ToString();
        }

        public static IEnumerable<Sucursal> GetSucursales()
        {
            return (from DataRow sucursal in SucursalDAL.GetSucursales().Rows
                    select
                        new Sucursal(Convert.ToInt32(sucursal["idSucursal"].ToString()))).ToList();
        }

        public static IEnumerable<Sucursal> GetSucursales(int idLocalidad, string nombre, string direccion, string telefono, string email, string codigoPostal)
        {
            return (from DataRow sucursal in SucursalDAL.GetSucursales(idLocalidad, nombre, direccion, telefono, email, codigoPostal).Rows
                    select
                        new Sucursal(Convert.ToInt32(sucursal["idSucursal"].ToString()))).ToList();
        }

        public void Guardar()
        {
            SucursalDAL.GuardarSucursal(IdSucursal, Localidad.IdLocalidad, Nombre, Direccion, Telefono, Email, CodigoPostal);
        }
    }
}
