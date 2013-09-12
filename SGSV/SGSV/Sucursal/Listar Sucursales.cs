using System;
using System.Collections.Generic;
using System.Linq;
using SGSV.Utils;

namespace SGSV.Sucursal
{
    public partial class frmListarSucursales : MasterForm
    {
        private IEnumerable<Entidades.Localidad.Localidad> listaLocalidades;

        public frmListarSucursales()
        {
            InitializeComponent();
            listaLocalidades = Entidades.Localidad.Localidad.GetLocalidades();
            txtLocalidad.AutoCompleteCustomSource.AddRange(listaLocalidades.Select(m => m.Nombre).ToArray());
            Cargar();
        }

        protected void Cargar()
        {
            dgvSucursales.DataSource = Entidades.Sucursal.Sucursal.GetSucursales();
            dgvSucursales.Columns[0].Visible = false;
            dgvSucursales.Columns[1].Visible = false;
            dgvSucursales.Columns[2].Width = 150;
            dgvSucursales.Columns[3].Width = 150;
            dgvSucursales.Columns[4].Width = 150;
            dgvSucursales.Columns[5].Width = 150;
            dgvSucursales.Columns[6].Width = 150;
            dgvSucursales.Columns[7].Width = 150;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var localidad = listaLocalidades.FirstOrDefault(m => m.Nombre.ToLower() == txtLocalidad.Text.ToLower());
            dgvSucursales.DataSource = Entidades.Sucursal.Sucursal.GetSucursales(localidad != null ? localidad.IdLocalidad : 0,
                                                                                 txtNombre.Text,
                                                                                 txtDireccion.Text,
                                                                                 txtTelefono.Text,
                                                                                 txtEmail.Text,
                                                                                 txtCodigoPostal.Text);
            dgvSucursales.Columns[0].Visible = false;
            dgvSucursales.Columns[1].Visible = false;
            dgvSucursales.Columns[2].Width = 150;
            dgvSucursales.Columns[3].Width = 150;
            dgvSucursales.Columns[4].Width = 150;
            dgvSucursales.Columns[5].Width = 150;
            dgvSucursales.Columns[6].Width = 150;
            dgvSucursales.Columns[7].Width = 150;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmEditarSucursal().ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var indice = dgvSucursales.SelectedCells[0].RowIndex;
            new frmEditarSucursal(Convert.ToInt32(dgvSucursales.Rows[indice].Cells[0].Value.ToString())).ShowDialog();
            Cargar();
        }

        protected void Limpiar()
        {
            txtLocalidad.Limpiar();
            txtNombre.Limpiar();
            txtDireccion.Limpiar();
            txtTelefono.Limpiar();
            txtEmail.Limpiar();
            txtCodigoPostal.Limpiar();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Cargar();
        }

    }
}
