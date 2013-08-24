using System;
using System.Collections.Generic;
using System.Data;
using SGSV.DAL;

namespace SGSV.Entidades.Producto
{
    class Marca
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }

        public static IEnumerable<Marca> GetMarcas()
        {
            var lista = new List<Marca>();//DAL.Marca.GetMarcas();
            foreach (DataRow marca in ProductoDAL.GetMarcas().Rows)
            {
                lista.Add(new Marca { IdMarca = Convert.ToInt32(marca["id_Marca"].ToString()), Nombre = marca["nombre"].ToString() });
            }

            return lista;
        }

        public void Guardar()
        {
            ProductoDAL.GuardarMarca(IdMarca, Nombre);
        }
    }
}