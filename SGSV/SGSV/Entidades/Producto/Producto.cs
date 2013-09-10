using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using SGSV.DAL;

namespace SGSV.Entidades.Producto
{
    class Producto
    {
        public int IdProducto { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Marca")]
        public string NombreMarca { get { return Marca != null ? Marca.Nombre : ""; } }
        public TipoProducto TipoProducto { get; set; }
        [DisplayName("Tipo de Producto")]
        public string NombreTipoProducto { get { return TipoProducto != null ? TipoProducto.Nombre : ""; } }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto)
        {
            Cargar(idProducto);
        }

        public void Cargar(int idProducto)
        {
            var producto = ProductoDAL.GetProducto(idProducto);
            IdProducto = Convert.ToInt32(producto["idProducto"].ToString());
            Marca = new Marca(Convert.ToInt32(producto["idMarca"].ToString()));
            TipoProducto = new TipoProducto(Convert.ToInt32(producto["idTipoProducto"].ToString()));
            Nombre = producto["nombre"].ToString();
            Observaciones = producto["observaciones"].ToString();
        }

        public static IEnumerable<Producto> GetProductos()
        {
            return (from DataRow producto in ProductoDAL.GetProductos().Rows
                    select
                        new Producto(Convert.ToInt32(producto["idProducto"].ToString()))).ToList();
        }

        public static IEnumerable<Producto> GetProductos(int idMarca, int idTipoProducto, string nombre)
        {
            return (from DataRow producto in ProductoDAL.GetProductos(idMarca, idTipoProducto, nombre).Rows
                    select
                        new Producto(Convert.ToInt32(producto["idProducto"].ToString()))).ToList();
        }

        public void Guardar()
        {
            ProductoDAL.GuardarProducto(IdProducto, Marca.IdMarca, TipoProducto.IdTipoProducto, Nombre, Observaciones);
        }
    }
}
