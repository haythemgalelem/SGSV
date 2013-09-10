using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SGSV.Properties;

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
            producto.Marca = listaMarcas.FirstOrDefault(m => m.Nombre.ToLower() == txtMarca.Text.ToLower());
            producto.TipoProducto = listaTiposProducto.FirstOrDefault(m => m.Nombre.ToLower() == txtTipoProducto.Text.ToLower());
            producto.Nombre = txtNombre.Text;
            producto.Observaciones = txtObservaciones.Text;
            if (!SonDatosValidos()) return;
            producto.Guardar();
            MessageBox.Show(Resources.OperaciónExitosa, Resources.Guardar, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            listaMarcas = Entidades.Producto.Marca.GetMarcas();
            txtMarca.AutoCompleteCustomSource.AddRange(listaMarcas.Select(m => m.Nombre).ToArray());
            listaTiposProducto = Entidades.Producto.TipoProducto.GetTiposProducto();
            txtTipoProducto.AutoCompleteCustomSource.AddRange(listaTiposProducto.Select(m => m.Nombre).ToArray());
        }

        protected bool SonDatosValidos()
        {
            if(producto.Marca == null)
            {
                MessageBox.Show(Resources.IngresarMarca, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (producto.TipoProducto == null)
            {
                MessageBox.Show(Resources.IngresarTipoProducto, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (producto.Nombre == string.Empty)
            {
                MessageBox.Show(Resources.IngresarNombre, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
