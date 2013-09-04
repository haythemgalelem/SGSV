namespace SGSV.Localidad
{
    partial class frmListarLocalidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.menuLocalidad = new System.Windows.Forms.MenuStrip();
            this.mnuCrearLocalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificarLocalidad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.menuLocalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(0, 32);
            this.dgvLocalidades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.Size = new System.Drawing.Size(320, 338);
            this.dgvLocalidades.TabIndex = 0;
            // 
            // menuLocalidad
            // 
            this.menuLocalidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCrearLocalidad,
            this.mnuModificarLocalidad});
            this.menuLocalidad.Location = new System.Drawing.Point(0, 0);
            this.menuLocalidad.Name = "menuLocalidad";
            this.menuLocalidad.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuLocalidad.Size = new System.Drawing.Size(321, 28);
            this.menuLocalidad.TabIndex = 1;
            // 
            // mnuCrearLocalidad
            // 
            this.mnuCrearLocalidad.Name = "mnuCrearLocalidad";
            this.mnuCrearLocalidad.Size = new System.Drawing.Size(125, 24);
            this.mnuCrearLocalidad.Text = "Crear Localidad";
            this.mnuCrearLocalidad.Click += new System.EventHandler(this.mnuCrearLocalidad_Click);
            // 
            // mnuModificarLocalidad
            // 
            this.mnuModificarLocalidad.Name = "mnuModificarLocalidad";
            this.mnuModificarLocalidad.Size = new System.Drawing.Size(154, 24);
            this.mnuModificarLocalidad.Text = "Modificar Localidad";
            this.mnuModificarLocalidad.Click += new System.EventHandler(this.mnuModificarLocalidad_Click);
            // 
            // frmListarLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(321, 371);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.menuLocalidad);
            this.MainMenuStrip = this.menuLocalidad;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarLocalidades";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Localidades";
            this.Load += new System.EventHandler(this.Listar_Localidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.menuLocalidad.ResumeLayout(false);
            this.menuLocalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.MenuStrip menuLocalidad;
        private System.Windows.Forms.ToolStripMenuItem mnuModificarLocalidad;
        private System.Windows.Forms.ToolStripMenuItem mnuCrearLocalidad;
    }
}