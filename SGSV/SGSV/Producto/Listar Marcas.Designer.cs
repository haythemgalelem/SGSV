namespace SGSV.Producto
{
    partial class frmListarMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.menuMarca = new System.Windows.Forms.MenuStrip();
            this.mnuCrearMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.menuMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(0, 32);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(320, 338);
            this.dgvMarcas.TabIndex = 0;
            // 
            // menuMarca
            // 
            this.menuMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCrearMarca,
            this.mnuModificarMarca});
            this.menuMarca.Location = new System.Drawing.Point(0, 0);
            this.menuMarca.Name = "menuMarca";
            this.menuMarca.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMarca.Size = new System.Drawing.Size(321, 28);
            this.menuMarca.TabIndex = 1;
            // 
            // mnuCrearMarca
            // 
            this.mnuCrearMarca.Name = "mnuCrearMarca";
            this.mnuCrearMarca.Size = new System.Drawing.Size(125, 24);
            this.mnuCrearMarca.Text = "Crear Marca";
            this.mnuCrearMarca.Click += new System.EventHandler(this.mnuCrearMarca_Click);
            // 
            // mnuModificarMarca
            // 
            this.mnuModificarMarca.Name = "mnuModificarMarca";
            this.mnuModificarMarca.Size = new System.Drawing.Size(154, 24);
            this.mnuModificarMarca.Text = "Modificar Marca";
            this.mnuModificarMarca.Click += new System.EventHandler(this.mnuModificarMarca_Click);
            // 
            // frmListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(321, 371);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.menuMarca);
            this.MainMenuStrip = this.menuMarca;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarMarcas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Marcas";
            this.Load += new System.EventHandler(this.Listar_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.menuMarca.ResumeLayout(false);
            this.menuMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.MenuStrip menuMarca;
        private System.Windows.Forms.ToolStripMenuItem mnuModificarMarca;
        private System.Windows.Forms.ToolStripMenuItem mnuCrearMarca;
    }
}