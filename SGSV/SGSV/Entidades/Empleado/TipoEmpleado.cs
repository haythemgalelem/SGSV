using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SGSV.DAL;

namespace SGSV.Entidades.Empleado
{
    class TipoEmpleado
    {
        public int IdTipoEmpleado { get; set; }
        public string Nombre { get; set; }

        public TipoEmpleado()
        {
        }

        public TipoEmpleado(int idTipoEmpleado)
        {
            Cargar(idTipoEmpleado);
        }

        public void Cargar(int idTipoEmpleado)
        {
            var tipoEmpleado = EmpleadoDAL.GetTipoEmpleado(idTipoEmpleado);
            IdTipoEmpleado = Convert.ToInt32(tipoEmpleado["idTipoEmpleado"].ToString());
            Nombre = tipoEmpleado["nombre"].ToString();
        }

        public static IEnumerable<TipoEmpleado> GetTiposEmpleado()
        {
            return (from DataRow tipoEmpleado in EmpleadoDAL.GetTiposEmpleado().Rows
                    select
                        new TipoEmpleado
                            {
                                IdTipoEmpleado = Convert.ToInt32(tipoEmpleado["idTipoEmpleado"].ToString()),
                                Nombre = tipoEmpleado["nombre"].ToString()
                            }).ToList();
        }

        public void Guardar()
        {
            EmpleadoDAL.GuardarTipoEmpleado(IdTipoEmpleado, Nombre);
        }
    }
}
