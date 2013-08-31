using System;
using System.Windows.Forms;

namespace SGSV.Localidad
{
    public partial class FrmEditarLocalidad : Form
    {
        protected int IdLocalidad;

        public FrmEditarLocalidad()
        {
            InitializeComponent();
        }

        public FrmEditarLocalidad(int idLocalidad)
        {
            InitializeComponent();
            var localidad = Entidades.Localidad.Localidad(idLocalidad);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var localidad = new Entidades.Localidad.Localidad {Nombre = txtNombre.Text};
            localidad.Guardar();
            Close();
        }
    }
}
