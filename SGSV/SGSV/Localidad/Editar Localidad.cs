using System;
using System.Windows.Forms;

namespace SGSV.Localidad
{
    public partial class frmEditarLocalidad : MasterForm
    {
        private Entidades.Localidad.Localidad localidad;

        public frmEditarLocalidad()
        {
            InitializeComponent();
            localidad = new Entidades.Localidad.Localidad();
            base.Text = "Crear Localidad";
        }

        public frmEditarLocalidad(int idLocalidad)
        {
            InitializeComponent();
            localidad = new Entidades.Localidad.Localidad(idLocalidad);
            txtNombre.Text = localidad.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            localidad.Nombre = txtNombre.Text;
            localidad.Guardar();
            Close();
        }
    }
}
