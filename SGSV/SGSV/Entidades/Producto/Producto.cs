namespace SGSV.Entidades.Producto
{
    class Producto
    {
        public int IdProducto { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public int IdTipoProcucto { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
    }
}
