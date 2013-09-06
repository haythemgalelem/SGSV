using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SGSV.DAL;

namespace SGSV.Entidades.Producto
{
    class Marca
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }

        public Marca()
        {
        }

        public Marca(int idMarca)
        {
            Cargar(idMarca);
        }

        public void Cargar(int idMarca)
        {
            var marca = ProductoDAL.GetMarca(idMarca);
            IdMarca = Convert.ToInt32(marca["idMarca"].ToString());
            Nombre = marca["nombre"].ToString();
        }

        public static IEnumerable<Marca> GetMarcas()
        {
            return (from DataRow marca in ProductoDAL.GetMarcas().Rows
                    select
                        new Marca
                            {
                                IdMarca = Convert.ToInt32(marca["idMarca"].ToString()),
                                Nombre = marca["nombre"].ToString()
                            }).ToList();
        }

        public void Guardar()
        {
            ProductoDAL.GuardarMarca(IdMarca, Nombre);
        }
    }
}