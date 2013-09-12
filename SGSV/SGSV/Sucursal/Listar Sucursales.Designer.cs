namespace SGSV.Sucursal
{
    partial class frmListarSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarSucursales));
            this.dgvSucursales = new System.Windows.Forms.DataGridView();
            this.menuSucursal = new System.Windows.Forms.MenuStrip();
            this.mnuCrearSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificarSucursal = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFiltros = new System.Windows.Forms.GroupBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.menuSucursal.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Location = new System.Drawing.Point(0, 163);
            this.dgvSucursales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.Size = new System.Drawing.Size(943, 466);
            this.dgvSucursales.TabIndex = 8;
            // 
            // menuSucursal
            // 
            this.menuSucursal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCrearSucursal,
            this.mnuModificarSucursal});
            this.menuSucursal.Location = new System.Drawing.Point(0, 0);
            this.menuSucursal.Name = "menuSucursal";
            this.menuSucursal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuSucursal.Size = new System.Drawing.Size(943, 28);
            this.menuSucursal.TabIndex = 1;
            // 
            // mnuCrearSucursal
            // 
            this.mnuCrearSucursal.Name = "mnuCrearSucursal";
            this.mnuCrearSucursal.Size = new System.Drawing.Size(114, 24);
            this.mnuCrearSucursal.Text = "Crear Sucursal";
            this.mnuCrearSucursal.Click += new System.EventHandler(this.mnuCrearSucursal_Click);
            // 
            // mnuModificarSucursal
            // 
            this.mnuModificarSucursal.Name = "mnuModificarSucursal";
            this.mnuModificarSucursal.Size = new System.Drawing.Size(143, 24);
            this.mnuModificarSucursal.Text = "Modificar Sucursal";
            this.mnuModificarSucursal.Click += new System.EventHandler(this.mnuModificarSucursal_Click);
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.lblCodigoPostal);
            this.pnlFiltros.Controls.Add(this.txtCodigoPostal);
            this.pnlFiltros.Controls.Add(this.lblEmail);
            this.pnlFiltros.Controls.Add(this.txtEmail);
            this.pnlFiltros.Controls.Add(this.lblTelefono);
            this.pnlFiltros.Controls.Add(this.txtTelefono);
            this.pnlFiltros.Controls.Add(this.lblDireccion);
            this.pnlFiltros.Controls.Add(this.txtDireccion);
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Controls.Add(this.btnBuscar);
            this.pnlFiltros.Controls.Add(this.lblLocalidad);
            this.pnlFiltros.Controls.Add(this.txtLocalidad);
            this.pnlFiltros.Controls.Add(this.lblNombre);
            this.pnlFiltros.Controls.Add(this.txtNombre);
            this.pnlFiltros.Location = new System.Drawing.Point(12, 42);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(919, 114);
            this.pnlFiltros.TabIndex = 2;
            this.pnlFiltros.TabStop = false;
            this.pnlFiltros.Text = "Filtros de Búsqueda";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(342, 76);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(99, 17);
            this.lblCodigoPostal.TabIndex = 21;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(449, 73);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPostal.MaxLength = 100;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(181, 22);
            this.txtCodigoPostal.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(342, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(449, 47);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(342, 24);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(449, 21);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 100;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 78);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(140, 75);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(181, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(777, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 82);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(678, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 82);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(33, 26);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(73, 17);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLocalidad.Location = new System.Drawing.Point(140, 23);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalidad.MaxLength = 100;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(181, 22);
            this.txtLocalidad.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 49);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // frmListarSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(943, 629);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.dgvSucursales);
            this.Controls.Add(this.menuSucursal);
            this.MainMenuStrip = this.menuSucursal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarSucursales";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.menuSucursal.ResumeLayout(false);
            this.menuSucursal.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSucursales;
        private System.Windows.Forms.MenuStrip menuSucursal;
        private System.Windows.Forms.ToolStripMenuItem mnuModificarSucursal;
        private System.Windows.Forms.ToolStripMenuItem mnuCrearSucursal;
        private System.Windows.Forms.GroupBox pnlFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}