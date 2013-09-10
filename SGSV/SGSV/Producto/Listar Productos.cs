using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SGSV.DAL;
using SGSV.Producto;
using SGSV.Utils;

namespace SGSV.Producto
{
    public partial class frmListarProductos : MasterForm
    {
        private IEnumerable<Entidades.Producto.Marca> listaMarcas;
        private IEnumerable<Entidades.Producto.TipoProducto> listaTiposProducto;

        public frmListarProductos()
        {
            InitializeComponent();
            listaMarcas = Entidades.Producto.Marca.GetMarcas();
            txtMarca.AutoCompleteCustomSource.AddRange(listaMarcas.Select(m => m.Nombre).ToArray());
            listaTiposProducto = Entidades.Producto.TipoProducto.GetTiposProducto();
            txtTipoProducto.AutoCompleteCustomSource.AddRange(listaTiposProducto.Select(m => m.Nombre).ToArray());
            Cargar();
        }

        protected void Cargar()
        {
            dgvProductos.DataSource = Entidades.Producto.Producto.GetProductos();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[2].Width = 150;
            dgvProductos.Columns[4].Width = 150;
            dgvProductos.Columns[5].Width = 200;
            dgvProductos.Columns[6].Width = 400;
        }

        private void mnuModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                new frmEditarProducto(Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
                
            }
        }

        private void mnuCrearProducto_Click(object sender, EventArgs e)
        {
            new frmEditarProducto().ShowDialog();
            Cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var marca = listaMarcas.FirstOrDefault(m => m.Nombre == txtMarca.Text);
            var tipoProducto = listaTiposProducto.FirstOrDefault(p => p.Nombre == txtTipoProducto.Text);
            dgvProductos.DataSource = Entidades.Producto.Producto.GetProductos(marca != null ? marca.IdMarca : 0,
                                                                               tipoProducto != null ? tipoProducto.IdTipoProducto : 0,
                                                                               txtNombre.Text);
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[2].Width = 150;
            dgvProductos.Columns[4].Width = 150;
            dgvProductos.Columns[5].Width = 200;
            dgvProductos.Columns[6].Width = 400;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMarca.Limpiar();
            txtTipoProducto.Limpiar();
            txtNombre.Limpiar();
            txtObservaciones.Limpiar();
        }

    }
}
