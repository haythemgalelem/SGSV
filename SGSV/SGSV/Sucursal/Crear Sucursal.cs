using System;
using System.Windows.Forms;

namespace SGSV.Sucursal
{
    public partial class frmCrearSucursal : MasterForm
    {
        public frmCrearSucursal()
        {
            InitializeComponent();
        }

        private void Crear_Sucursal_Load(object sender, EventArgs e)
        {
            InicializarPantalla();

        }

        private void InicializarPantalla()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCodigoPostal.Text = "";
            txtMail.Text = "";
            cbLocalidad.DataSource = Entidades.Localidad.Localidad.GetLocalidades();
            cbLocalidad.DisplayMember = "nombre";
            cbLocalidad.ValueMember = "idLocalidad";
        }

        private void refrescarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializarPantalla();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Entidades.Sucursal.Sucursal sucursal = new Entidades.Sucursal.Sucursal();

            sucursal.idSucursal = 0;
            sucursal.nombre = txtNombre.Text;
            sucursal.direccion = txtDireccion.Text;
            sucursal.idLocalidad =  Convert.ToInt32(cbLocalidad.SelectedValue.ToString());
            sucursal.telefono = txtTelefono.Text;
            sucursal.email = txtMail.Text;
            sucursal.codigoPostal = txtCodigoPostal.Text;

            sucursal.guardarSucursal();

            MessageBox.Show("Se ha realizado la creación con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 
        }

    }
}
