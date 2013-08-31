using System;
using System.Collections.Generic;
using SGSV.DAL;

namespace SGSV.Entidades.Localidad
{
    class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }

        public Localidad()
        {
        }

        public Localidad(int idLocalidad)
        {
            Cargar(idLocalidad);
        }

        public void Cargar(int idLocalidad)
        {
            var localidad = LocalidadDAL.GetLocalidad(idLocalidad);
            IdLocalidad = Convert.ToInt32(localidad["idLocalidad"].ToString());
            Nombre = localidad["idLocalidad"].ToString();
        }

        public static IEnumerable<Localidad> GetLocalidades()
        {
            return LocalidadDAL.GetLocalidades();
        }

        public void Guardar()
        {
            LocalidadDAL.Guardar(IdLocalidad, Nombre);
        }
    }
}
