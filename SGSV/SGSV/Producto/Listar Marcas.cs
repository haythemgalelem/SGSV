using System;
using System.Windows.Forms;
using SGSV.Producto;

namespace SGSV.Producto
{
    public partial class frmListarMarcas : Form
    {
        public frmListarMarcas()
        {
            InitializeComponent();
        }

        protected void Cargar()
        {
            dgvMarcas.DataSource = Entidades.Producto.Marca.GetMarcas();
            dgvMarcas.Columns[0].Visible = false;
            dgvMarcas.Columns[1].Width = dgvMarcas.Width - 45;
        }

        private void Listar_Marcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void mnuModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                new frmEditarMarca(Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
                
            }
        }

        private void mnuCrearMarca_Click(object sender, EventArgs e)
        {
            new frmEditarMarca().ShowDialog();
            Cargar();
        }

    }
}
