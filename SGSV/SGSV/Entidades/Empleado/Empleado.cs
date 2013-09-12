using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using SGSV.DAL;

namespace SGSV.Entidades.Empleado
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public Entidades.Sucursal.Sucursal Sucursal { get; set; }
        [DisplayName("Sucursal")]
        public string NombreSucursal { get { return Sucursal != null ? Sucursal.Nombre : ""; } }
        public TipoEmpleado TipoEmpleado { get; set; }
        [DisplayName("Tipo de Empleado")]
        public string NombreTipoEmpleado { get { return TipoEmpleado != null ? TipoEmpleado.Nombre : ""; } }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }

        public Empleado()
        {
        }

        public Empleado(int idEmpleado)
        {
            Cargar(idEmpleado);
        }

        public void Cargar(int idEmpleado)
        {
            var producto = EmpleadoDAL.GetEmpleado(idEmpleado);
            IdEmpleado = Convert.ToInt32(producto["idEmpleado"].ToString());
            Sucursal = new Sucursal(Convert.ToInt32(producto["idSucursal"].ToString()));
            TipoEmpleado = new TipoEmpleado(Convert.ToInt32(producto["idTipoEmpleado"].ToString()));
            Nombre = producto["nombre"].ToString();
            Observaciones = producto["observaciones"].ToString();
        }

        public static IEnumerable<Empleado> GetEmpleados()
        {
            return (from DataRow producto in EmpleadoDAL.GetEmpleados().Rows
                    select
                        new Empleado(Convert.ToInt32(producto["idEmpleado"].ToString()))).ToList();
        }

        public static IEnumerable<Empleado> GetEmpleados(int idSucursal, int idTipoEmpleado, string nombre, string observaciones)
        {
            return (from DataRow producto in EmpleadoDAL.GetEmpleados(idSucursal, idTipoEmpleado, nombre, observaciones).Rows
                    select
                        new Empleado(Convert.ToInt32(producto["idEmpleado"].ToString()))).ToList();
        }

        public void Guardar()
        {
            EmpleadoDAL.GuardarEmpleado(IdEmpleado, Sucursal.IdSucursal, TipoEmpleado.IdTipoEmpleado, Nombre, Observaciones);
        }
    }
}
