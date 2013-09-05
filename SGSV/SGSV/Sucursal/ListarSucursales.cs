using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGSV.Sucursal
{
    public partial class ListarSucursales : Form
    {
        public ListarSucursales()
        {
            InitializeComponent();
        }

        private void ListarSucursales_Load(object sender, EventArgs e)
        {
            InicializarPantalla();
            ActualizarPantallaSinFiltro();
        }

        private void InicializarPantalla()
        {
            cbLocalidad.DataSource = Entidades.Localidad.Localidad.GetLocalidades();
            cbLocalidad.DisplayMember = "nombre";
            cbLocalidad.ValueMember = "idLocalidad";

            chbInhabilitado.Checked = false;
        }

        private char inhabilitado()
        {
            if (chbInhabilitado.Checked)
                return '1';
            else
                return '0';
        }

        private  int localidadElegida()
        {
            return Convert.ToInt32(cbLocalidad.SelectedValue.ToString());
        }

        private void ActualizarPantallaSinFiltro()
        {
            dgvSucursales.DataSource = Entidades.Sucursal.Sucursal.GetSucursalesSinFiltro();
            dgvSucursales.Columns[0].Visible = false;
            dgvSucursales.Columns[1].Visible = false;
            dgvSucursales.Visible = true;
        }

        private void acualizarConFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvSucursales.DataSource = Entidades.Sucursal.Sucursal.GetSucursalesConFiltro(localidadElegida(),inhabilitado());
            dgvSucursales.Columns[0].Visible = false;
            dgvSucursales.Columns[1].Visible = false;
            dgvSucursales.Visible = true;
        }

        private int idSucursalElegida()
        {
            return Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells[0].Value.ToString());
        }

        private string nombreSucursalElegida()
        {
            return dgvSucursales.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void borrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sucursalElegidaEstaHabilitada())
            {

                string mensaje = "¿Desea darle de baja a la sucursal con nombre " + nombreSucursalElegida() + "?";

                DialogResult dialogResult = MessageBox.Show(mensaje, "Pregunta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Entidades.Sucursal.Sucursal.BajaLogicaSucursal(idSucursalElegida());
                    MessageBox.Show("Se ha realizado la baja con éxito", "Información", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ActualizarPantallaSinFiltro();
                }

            }else
            {
                MessageBox.Show("La sucursal se encuentra inhabilitada. Elija otra.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool sucursalElegidaEstaHabilitada()
        {
            return (Convert.ToChar(dgvSucursales.SelectedRows[0].Cells["inhabilitado"].Value.ToString()) == '0');
        }

        private void actualizarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarPantallaSinFiltro();
        }

        private void crearSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sucursal.frmCrearSucursal().ShowDialog();
            ActualizarPantallaSinFiltro();
        }

        private void modificarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal.frmModificarSucursal modificarSucursalScreen = new Sucursal.frmModificarSucursal();

            modificarSucursalScreen.idSucursal = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells[0].Value.ToString());
            modificarSucursalScreen.idLocalidad = Convert.ToInt32(dgvSucursales.SelectedRows[0].Cells[1].Value.ToString());
            modificarSucursalScreen.txtNombre.Text = dgvSucursales.SelectedRows[0].Cells[2].Value.ToString();
            modificarSucursalScreen.txtDireccion.Text = dgvSucursales.SelectedRows[0].Cells[3].Value.ToString();
            modificarSucursalScreen.txtTelefono.Text = dgvSucursales.SelectedRows[0].Cells[4].Value.ToString();
            modificarSucursalScreen.txtMail.Text = dgvSucursales.SelectedRows[0].Cells[5].Value.ToString();
            modificarSucursalScreen.txtCodigoPostal.Text = dgvSucursales.SelectedRows[0].Cells[6].Value.ToString();
            modificarSucursalScreen.ShowDialog();

            ActualizarPantallaSinFiltro();
        }

    }
}
