using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SGSV.DAL;

namespace SGSV.Entidades.Producto
{
    class TipoProducto
    {
        public int IdTipoProducto { get; set; }
        public string Nombre { get; set; }

        public TipoProducto()
        {
        }

        public TipoProducto(int idTipoProducto)
        {
            Cargar(idTipoProducto);
        }

        public void Cargar(int idTipoProducto)
        {
            var tipoProducto = ProductoDAL.GetTipoProducto(idTipoProducto);
            IdTipoProducto = Convert.ToInt32(tipoProducto["idTipoProducto"].ToString());
            Nombre = tipoProducto["nombre"].ToString();
        }

        public static IEnumerable<TipoProducto> GetTiposProducto()
        {
            return (from DataRow tipoProducto in ProductoDAL.GetTiposProducto().Rows
                    select
                        new TipoProducto
                            {
                                IdTipoProducto = Convert.ToInt32(tipoProducto["idTipoProducto"].ToString()),
                                Nombre = tipoProducto["nombre"].ToString()
                            }).ToList();
        }

        public void Guardar()
        {
            ProductoDAL.GuardarTipoProducto(IdTipoProducto, Nombre);
        }
    }
}