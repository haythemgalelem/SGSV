using System.Collections.Generic;
using SGSV.DAL;

namespace SGSV.Entidades.Localidad
{
    class Localidad
    {
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }

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
