using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGSV.DAL;

namespace SGSV.Entidades.Sucursal
{
    class Sucursal
    {

        public int idSucursal { get; set; }
        public int idLocalidad { get; set; }
        public string nombre  { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string codigoPostal { get; set; }
        public string localidad { get; set; }
        public string inhabilitado { get; set; }

        public void guardarSucursal()
        {
            SucursalDAL.Guardar(idSucursal,nombre,direccion,idLocalidad,telefono,email,codigoPostal);
        }

        public static IEnumerable<Sucursal> GetSucursalesSinFiltro()
        {
            return SucursalDAL.GetLocalidadesSinFiltro();
        }

        public static IEnumerable<Sucursal> GetSucursalesConFiltro(int idLocalidad, char flagInhabilitado)
        {
            return SucursalDAL.GetLocalidadesConFiltro(idLocalidad, flagInhabilitado);
        }

        public static void BajaLogicaSucursal(int idSucursal)
        {
            SucursalDAL.BajaLogicaSucursal(idSucursal);
        }

        public static void RealizarCambiosSucursal(int idSucursal, int idLocalidad, string nombre, string direccion, string telefono, string codigoPostal, string email)
        {
            SucursalDAL.Guardar(idSucursal, nombre, direccion, idLocalidad, telefono, email, codigoPostal);
        }
    }
}
