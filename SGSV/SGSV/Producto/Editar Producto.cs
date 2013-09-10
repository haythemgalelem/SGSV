using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGSV.Producto
{
    public partial class frmEditarProducto : MasterForm
    {
        private Entidades.Producto.Producto producto;
        private IEnumerable<Entidades.Producto.Marca> listaMarcas;
        private IEnumerable<Entidades.Producto.TipoProducto> listaTiposProducto;

        public frmEditarProducto()
        {
            InitializeComponent();
            producto = new Entidades.Producto.Producto();
        }

        public frmEditarProducto(int idProducto)
        {
            InitializeComponent();
            producto = new Entidades.Producto.Producto(idProducto);
            txtMarca.Text = producto.Marca.Nombre;
            txtTipoProducto.Text = producto.TipoProducto.Nombre;
            txtNombre.Text = producto.Nombre;
            txtObservaciones.Text = producto.Observaciones;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.Marca = listaMarcas.FirstOrDefault(m => m.Nombre == txtMarca.Text);
            producto.TipoProducto = listaTiposProducto.FirstOrDefault(m => m.Nombre == txtTipoProducto.Text);
            producto.Nombre = txtNombre.Text;
            producto.Observaciones = txtObservaciones.Text;
            producto.Guardar();
            Close();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            listaMarcas = Entidades.Producto.Marca.GetMarcas();
            txtMarca.AutoCompleteCustomSource.AddRange(listaMarcas.Select(m => m.Nombre).ToArray());
            listaTiposProducto = Entidades.Producto.TipoProducto.GetTiposProducto();
            txtTipoProducto.AutoCompleteCustomSource.AddRange(listaTiposProducto.Select(m => m.Nombre).ToArray());
        }
    }
}
