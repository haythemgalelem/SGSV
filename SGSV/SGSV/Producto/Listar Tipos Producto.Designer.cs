namespace SGSV.Producto
{
    partial class frmListarTiposProducto
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
            this.dgvTiposProducto = new System.Windows.Forms.DataGridView();
            this.menuTipoProducto = new System.Windows.Forms.MenuStrip();
            this.mnuCrearTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificarTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposProducto)).BeginInit();
            this.menuTipoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTiposProducto
            // 
            this.dgvTiposProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposProducto.Location = new System.Drawing.Point(0, 32);
            this.dgvTiposProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTiposProducto.Name = "dgvTiposProducto";
            this.dgvTiposProducto.Size = new System.Drawing.Size(340, 338);
            this.dgvTiposProducto.TabIndex = 0;
            // 
            // menuTipoProducto
            // 
            this.menuTipoProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCrearTipoProducto,
            this.mnuModificarTipoProducto});
            this.menuTipoProducto.Location = new System.Drawing.Point(0, 0);
            this.menuTipoProducto.Name = "menuTipoProducto";
            this.menuTipoProducto.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuTipoProducto.Size = new System.Drawing.Size(340, 28);
            this.menuTipoProducto.TabIndex = 1;
            // 
            // mnuCrearTipoProducto
            // 
            this.mnuCrearTipoProducto.Name = "mnuCrearTipoProducto";
            this.mnuCrearTipoProducto.Size = new System.Drawing.Size(150, 24);
            this.mnuCrearTipoProducto.Text = "Crear TipoProducto";
            this.mnuCrearTipoProducto.Click += new System.EventHandler(this.mnuCrearTipoProducto_Click);
            // 
            // mnuModificarTipoProducto
            // 
            this.mnuModificarTipoProducto.Name = "mnuModificarTipoProducto";
            this.mnuModificarTipoProducto.Size = new System.Drawing.Size(179, 24);
            this.mnuModificarTipoProducto.Text = "Modificar TipoProducto";
            this.mnuModificarTipoProducto.Click += new System.EventHandler(this.mnuModificarTipoProducto_Click);
            // 
            // frmListarTiposProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 371);
            this.Controls.Add(this.dgvTiposProducto);
            this.Controls.Add(this.menuTipoProducto);
            this.MainMenuStrip = this.menuTipoProducto;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarTiposProducto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar TiposProducto";
            this.Load += new System.EventHandler(this.Listar_TiposProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposProducto)).EndInit();
            this.menuTipoProducto.ResumeLayout(false);
            this.menuTipoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiposProducto;
        private System.Windows.Forms.MenuStrip menuTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem mnuModificarTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem mnuCrearTipoProducto;
    }
}