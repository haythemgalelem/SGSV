using System;
using System.Windows.Forms;

namespace SGSV.Localidad
{
    public partial class FrmListarLocalidades : Form
    {
        public FrmListarLocalidades()
        {
            InitializeComponent();
        }

        private void Listar_Localidades_Load(object sender, EventArgs e)
        {
            dgvLocalidades.DataSource = Entidades.Localidad.Localidad.GetLocalidades();
            dgvLocalidades.Columns[0].Visible = false;
        }

        private void modificarLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEditarLocalidad(Convert.ToInt32(dgvLocalidades.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
        }
    }
}
