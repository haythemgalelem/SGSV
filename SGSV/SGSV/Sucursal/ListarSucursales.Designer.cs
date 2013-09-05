namespace SGSV.Sucursal
{
    partial class ListarSucursales
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acualizarConFiltroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxFiltro = new System.Windows.Forms.GroupBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.chbInhabilitado = new System.Windows.Forms.CheckBox();
            this.gboxListado = new System.Windows.Forms.GroupBox();
            this.dgvSucursales = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.gboxFiltro.SuspendLayout();
            this.gboxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSucursalToolStripMenuItem,
            this.modificarSucursalToolStripMenuItem,
            this.actualizarPantallaToolStripMenuItem,
            this.acualizarConFiltroToolStripMenuItem,
            this.borrarSucursalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearSucursalToolStripMenuItem
            // 
            this.crearSucursalToolStripMenuItem.Name = "crearSucursalToolStripMenuItem";
            this.crearSucursalToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.crearSucursalToolStripMenuItem.Text = "Crear Sucursal";
            this.crearSucursalToolStripMenuItem.Click += new System.EventHandler(this.crearSucursalToolStripMenuItem_Click);
            // 
            // modificarSucursalToolStripMenuItem
            // 
            this.modificarSucursalToolStripMenuItem.Name = "modificarSucursalToolStripMenuItem";
            this.modificarSucursalToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.modificarSucursalToolStripMenuItem.Text = "Modificar Sucursal";
            this.modificarSucursalToolStripMenuItem.Click += new System.EventHandler(this.modificarSucursalToolStripMenuItem_Click);
            // 
            // actualizarPantallaToolStripMenuItem
            // 
            this.actualizarPantallaToolStripMenuItem.Name = "actualizarPantallaToolStripMenuItem";
            this.actualizarPantallaToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.actualizarPantallaToolStripMenuItem.Text = "Actualizar pantalla sin filtro";
            this.actualizarPantallaToolStripMenuItem.Click += new System.EventHandler(this.actualizarPantallaToolStripMenuItem_Click);
            // 
            // acualizarConFiltroToolStripMenuItem
            // 
            this.acualizarConFiltroToolStripMenuItem.Name = "acualizarConFiltroToolStripMenuItem";
            this.acualizarConFiltroToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.acualizarConFiltroToolStripMenuItem.Text = "Actualizar pantalla con filtro";
            this.acualizarConFiltroToolStripMenuItem.Click += new System.EventHandler(this.acualizarConFiltroToolStripMenuItem_Click);
            // 
            // borrarSucursalToolStripMenuItem
            // 
            this.borrarSucursalToolStripMenuItem.Name = "borrarSucursalToolStripMenuItem";
            this.borrarSucursalToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.borrarSucursalToolStripMenuItem.Text = "Borrar sucursal";
            this.borrarSucursalToolStripMenuItem.Click += new System.EventHandler(this.borrarSucursalToolStripMenuItem_Click);
            // 
            // gboxFiltro
            // 
            this.gboxFiltro.Controls.Add(this.cbLocalidad);
            this.gboxFiltro.Controls.Add(this.lblLocalidad);
            this.gboxFiltro.Controls.Add(this.chbInhabilitado);
            this.gboxFiltro.Location = new System.Drawing.Point(13, 28);
            this.gboxFiltro.Name = "gboxFiltro";
            this.gboxFiltro.Size = new System.Drawing.Size(655, 55);
            this.gboxFiltro.TabIndex = 1;
            this.gboxFiltro.TabStop = false;
            this.gboxFiltro.Text = "Filtrar información por:";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(68, 20);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(104, 21);
            this.cbLocalidad.TabIndex = 2;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(7, 23);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // chbInhabilitado
            // 
            this.chbInhabilitado.AutoSize = true;
            this.chbInhabilitado.Location = new System.Drawing.Point(484, 23);
            this.chbInhabilitado.Name = "chbInhabilitado";
            this.chbInhabilitado.Size = new System.Drawing.Size(166, 17);
            this.chbInhabilitado.TabIndex = 0;
            this.chbInhabilitado.Text = "Mostrar sucursales eliminadas";
            this.chbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // gboxListado
            // 
            this.gboxListado.Controls.Add(this.dgvSucursales);
            this.gboxListado.Location = new System.Drawing.Point(13, 92);
            this.gboxListado.Name = "gboxListado";
            this.gboxListado.Size = new System.Drawing.Size(655, 287);
            this.gboxListado.TabIndex = 2;
            this.gboxListado.TabStop = false;
            this.gboxListado.Text = "Listado de sucursales";
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(7, 20);
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.Size = new System.Drawing.Size(643, 261);
            this.dgvSucursales.TabIndex = 0;
            // 
            // ListarSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 391);
            this.Controls.Add(this.gboxListado);
            this.Controls.Add(this.gboxFiltro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListarSucursales";
            this.Text = "Listar sucursales";
            this.Load += new System.EventHandler(this.ListarSucursales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxFiltro.ResumeLayout(false);
            this.gboxFiltro.PerformLayout();
            this.gboxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarSucursalToolStripMenuItem;
        private System.Windows.Forms.GroupBox gboxFiltro;
        private System.Windows.Forms.CheckBox chbInhabilitado;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.GroupBox gboxListado;
        private System.Windows.Forms.DataGridView dgvSucursales;
        private System.Windows.Forms.ToolStripMenuItem acualizarConFiltroToolStripMenuItem;
    }
}