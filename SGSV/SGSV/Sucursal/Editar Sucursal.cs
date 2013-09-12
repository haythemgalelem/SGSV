using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SGSV.Properties;
using SGSV.Utils;

namespace SGSV.Sucursal
{
    public partial class frmEditarSucursal : MasterForm
    {
        private Entidades.Sucursal.Sucursal sucursal;
        private IEnumerable<Entidades.Localidad.Localidad> listaLocalidades;

        public frmEditarSucursal()
        {
            InitializeComponent();
            sucursal = new Entidades.Sucursal.Sucursal();
        }

        public frmEditarSucursal(int idSucursal)
        {
            InitializeComponent();
            sucursal = new Entidades.Sucursal.Sucursal(idSucursal);
            txtLocalidad.Text = sucursal.Localidad.Nombre;
            txtNombre.Text = sucursal.Nombre;
            txtDireccion.Text = sucursal.Direccion;
            txtTelefono.Text = sucursal.Telefono;
            txtEmail.Text = sucursal.Email;
            txtCodigoPostal.Text = sucursal.CodigoPostal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sucursal.Localidad = listaLocalidades.FirstOrDefault(m => m.Nombre.ToLower() == txtLocalidad.Text.ToLower());
            sucursal.Nombre = txtNombre.Text;
            sucursal.Direccion = txtDireccion.Text;
            sucursal.Telefono = txtTelefono.Text;
            sucursal.Email = txtEmail.Text;
            sucursal.CodigoPostal = txtCodigoPostal.Text;
            if (!SonDatosValidos()) return;
            sucursal.Guardar();
            MessageBox.Show(Resources.OperaciónExitosa, Resources.Guardar, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmEditarSucursal_Load(object sender, EventArgs e)
        {
            listaLocalidades = Entidades.Localidad.Localidad.GetLocalidades();
            txtLocalidad.AutoCompleteCustomSource.AddRange(listaLocalidades.Select(m => m.Nombre).ToArray());
        }

        protected bool SonDatosValidos()
        {
            if(sucursal.Localidad == null)
            {
                MessageBox.Show(Resources.IngresarLocalidad, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sucursal.Nombre == string.Empty)
            {
                MessageBox.Show(Resources.IngresarNombre, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sucursal.Direccion == string.Empty)
            {
                MessageBox.Show(Resources.IngresarDirección, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sucursal.Telefono == string.Empty)
            {
                MessageBox.Show(Resources.IngresarTeléfono, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sucursal.Email == string.Empty || !sucursal.Email.EsEmail())
            {
                MessageBox.Show(Resources.IngresarEmail, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sucursal.CodigoPostal == string.Empty)
            {
                MessageBox.Show(Resources.IngresarCodigoPostal, Resources.DatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
