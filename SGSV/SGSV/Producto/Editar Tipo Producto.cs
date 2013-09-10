using System;
using System.Windows.Forms;

namespace SGSV.Producto
{
    public partial class frmEditarTipoProducto : MasterForm
    {
        private Entidades.Producto.TipoProducto tipoProducto;

        public frmEditarTipoProducto()
        {
            InitializeComponent();
            tipoProducto = new Entidades.Producto.TipoProducto();
        }

        public frmEditarTipoProducto(int idTipoProducto)
        {
            InitializeComponent();
            tipoProducto = new Entidades.Producto.TipoProducto(idTipoProducto);
            txtNombre.Text = tipoProducto.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tipoProducto.Nombre = txtNombre.Text;
            tipoProducto.Guardar();
            Close();
        }
    }
}
