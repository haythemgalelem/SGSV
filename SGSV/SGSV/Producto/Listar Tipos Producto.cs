using System;
using System.Windows.Forms;
using SGSV.Producto;

namespace SGSV.Producto
{
    public partial class frmListarTiposProducto : MasterForm
    {
        public frmListarTiposProducto()
        {
            InitializeComponent();
        }

        protected void Cargar()
        {
            dgvTiposProducto.DataSource = Entidades.Producto.TipoProducto.GetTiposProducto();
            dgvTiposProducto.Columns[0].Visible = false;
            dgvTiposProducto.Columns[1].Width = dgvTiposProducto.Width - 45;
        }

        private void Listar_TiposProducto_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void mnuModificarTipoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                new frmEditarTipoProducto(Convert.ToInt32(dgvTiposProducto.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
                
            }
        }

        private void mnuCrearTipoProducto_Click(object sender, EventArgs e)
        {
            new frmEditarTipoProducto().ShowDialog();
            Cargar();
        }

    }
}
