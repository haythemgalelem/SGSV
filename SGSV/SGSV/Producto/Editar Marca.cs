using System;
using System.Windows.Forms;

namespace SGSV.Producto
{
    public partial class frmEditarMarca : MasterForm
    {
        private Entidades.Producto.Marca marca;

        public frmEditarMarca()
        {
            InitializeComponent();
            marca = new Entidades.Producto.Marca();
        }

        public frmEditarMarca(int idMarca)
        {
            InitializeComponent();
            marca = new Entidades.Producto.Marca(idMarca);
            txtNombre.Text = marca.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            marca.Nombre = txtNombre.Text;
            marca.Guardar();
            Close();
        }
    }
}
