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
    public partial class frmModificarSucursal : MasterForm
    {
        public int idSucursal;
        public int idLocalidad;
        private string nombre;
        private string telefono;
        private string codigoPostal;
        private string email;
        private string direccion;

        public frmModificarSucursal()
        {
            InitializeComponent();
        }

        private void frmModificarSucursal_Load(object sender, EventArgs e)
        {
            cbLocalidad.DataSource = Entidades.Localidad.Localidad.GetLocalidades();
            cbLocalidad.DisplayMember = "nombre";
            cbLocalidad.ValueMember = "idLocalidad";
            cbLocalidad.SelectedValue = idLocalidad;

            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            codigoPostal = txtCodigoPostal.Text;
            email = txtMail.Text;
            direccion = txtDireccion.Text;


        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refrescarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;
            txtCodigoPostal.Text = codigoPostal;
            txtMail.Text = email;
            txtDireccion.Text = direccion;
            cbLocalidad.SelectedValue = idLocalidad;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea realizar los cambios?", "Pregunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Entidades.Sucursal.Sucursal.RealizarCambiosSucursal(idSucursal, localidadElegida(), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text, txtCodigoPostal.Text);
                
                nombre = txtNombre.Text;
                telefono = txtTelefono.Text;
                codigoPostal = txtCodigoPostal.Text;
                email = txtMail.Text;
                direccion = txtDireccion.Text;
                cbLocalidad.SelectedValue = idLocalidad;

                MessageBox.Show("Se han realizado los cambios correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int localidadElegida()
        {
            return Convert.ToInt32(cbLocalidad.SelectedValue.ToString());
        }

    }
}
