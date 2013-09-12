using System;
using System.Collections.Generic;
using System.Linq;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var marca = listaMarcas.FirstOrDefault(m => m.Nombre.ToLower() == txtMarca.Text.ToLower());
            var tipoProducto = listaTiposProducto.FirstOrDefault(p => p.Nombre.ToLower() == txtTipoProducto.Text.ToLower());
            dgvProductos.DataSource = Entidades.Producto.Producto.GetProductos(marca != null ? marca.IdMarca : 0,
                                                                               tipoProducto != null ? tipoProducto.IdTipoProducto : 0,
                                                                               txtNombre.Text,
                                                                               txtObservaciones.Text);
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
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmEditarProducto().ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var indice = dgvProductos.SelectedCells[0].RowIndex;
            new frmEditarProducto(Convert.ToInt32(dgvProductos.Rows[indice].Cells[0].Value.ToString())).ShowDialog();
            Cargar();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Cargar();
        }

        protected void Limpiar()
        {
            txtMarca.Limpiar();
            txtTipoProducto.Limpiar();
            txtNombre.Limpiar();
            txtObservaciones.Limpiar();
        }

    }
}
