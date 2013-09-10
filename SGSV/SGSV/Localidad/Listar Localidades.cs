using System;
using System.Windows.Forms;

namespace SGSV.Localidad
{
    public partial class frmListarLocalidades : MasterForm
    {
        public frmListarLocalidades()
        {
            InitializeComponent();
        }

        protected void Cargar()
        {
            dgvLocalidades.DataSource = Entidades.Localidad.Localidad.GetLocalidades();
            dgvLocalidades.Columns[0].Visible = false;
            dgvLocalidades.Columns[1].Width = dgvLocalidades.Width - 45;
        }

        private void Listar_Localidades_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void mnuModificarLocalidad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmEditarLocalidad(Convert.ToInt32(dgvLocalidades.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
                Cargar();
            }
            catch (Exception)
            {
                
            }
        }

        private void mnuCrearLocalidad_Click(object sender, EventArgs e)
        {
            new frmEditarLocalidad().ShowDialog();
            Cargar();
        }

    }
}
