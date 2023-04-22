namespace P520231_JEANCAV.Formularios
{
    partial class FrmRegistroCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroCompra));
            this.CboxCompraTipo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.BtnProveedorBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.CboxTipoCompra = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCrearCompra = new System.Windows.Forms.Button();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVentaUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProductoAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEliminar = new System.Windows.Forms.ToolStripButton();
            this.CboxCompraTipo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboxCompraTipo
            // 
            this.CboxCompraTipo.Controls.Add(this.CboxTipoCompra);
            this.CboxCompraTipo.Controls.Add(this.TxtNotas);
            this.CboxCompraTipo.Controls.Add(this.label3);
            this.CboxCompraTipo.Controls.Add(this.label2);
            this.CboxCompraTipo.Controls.Add(this.BtnProveedorBuscar);
            this.CboxCompraTipo.Controls.Add(this.TxtProveedorNombre);
            this.CboxCompraTipo.Controls.Add(this.label1);
            this.CboxCompraTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxCompraTipo.Location = new System.Drawing.Point(28, 21);
            this.CboxCompraTipo.Name = "CboxCompraTipo";
            this.CboxCompraTipo.Size = new System.Drawing.Size(564, 153);
            this.CboxCompraTipo.TabIndex = 0;
            this.CboxCompraTipo.TabStop = false;
            this.CboxCompraTipo.Text = "Encabezado (Tabla Compra)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(34, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle (Tabla CompraDetalle)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(79, 22);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.ReadOnly = true;
            this.TxtProveedorNombre.Size = new System.Drawing.Size(348, 20);
            this.TxtProveedorNombre.TabIndex = 1;
            // 
            // BtnProveedorBuscar
            // 
            this.BtnProveedorBuscar.Location = new System.Drawing.Point(449, 20);
            this.BtnProveedorBuscar.Name = "BtnProveedorBuscar";
            this.BtnProveedorBuscar.Size = new System.Drawing.Size(93, 22);
            this.BtnProveedorBuscar.TabIndex = 2;
            this.BtnProveedorBuscar.Text = "Buscar...";
            this.BtnProveedorBuscar.UseVisualStyleBackColor = true;
            this.BtnProveedorBuscar.Click += new System.EventHandler(this.BtnProveedorBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notas: ";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(79, 78);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(350, 59);
            this.TxtNotas.TabIndex = 6;
            // 
            // CboxTipoCompra
            // 
            this.CboxTipoCompra.FormattingEnabled = true;
            this.CboxTipoCompra.Location = new System.Drawing.Point(79, 51);
            this.CboxTipoCompra.Name = "CboxTipoCompra";
            this.CboxTipoCompra.Size = new System.Drawing.Size(345, 21);
            this.CboxTipoCompra.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProductoAgregar,
            this.BtnProductoEditar,
            this.BtnProductoEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CProductoCodigoBarras,
            this.CProductoNombre,
            this.CCantidad,
            this.CPrecioVentaUnitario});
            this.DgvLista.Location = new System.Drawing.Point(6, 57);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(546, 132);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtTotalCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(32, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CANTIDAD ITEMS";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.Color.DimGray;
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.ForeColor = System.Drawing.Color.White;
            this.TxtTotalCantidad.Location = new System.Drawing.Point(85, 42);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(125, 29);
            this.TxtTotalCantidad.TabIndex = 1;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.Black;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Gold;
            this.TxtTotal.Location = new System.Drawing.Point(343, 42);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(125, 29);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL";
            // 
            // BtnCrearCompra
            // 
            this.BtnCrearCompra.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCrearCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCompra.Location = new System.Drawing.Point(201, 464);
            this.BtnCrearCompra.Name = "BtnCrearCompra";
            this.BtnCrearCompra.Size = new System.Drawing.Size(204, 33);
            this.BtnCrearCompra.TabIndex = 3;
            this.BtnCrearCompra.Text = "Crear Compra";
            this.BtnCrearCompra.UseVisualStyleBackColor = false;
            // 
            // CProductoID
            // 
            this.CProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Código";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            this.CProductoID.Width = 80;
            // 
            // CProductoCodigoBarras
            // 
            this.CProductoCodigoBarras.DataPropertyName = "ProductoCodigoBarras";
            this.CProductoCodigoBarras.HeaderText = "Códgo Barras";
            this.CProductoCodigoBarras.Name = "CProductoCodigoBarras";
            this.CProductoCodigoBarras.ReadOnly = true;
            // 
            // CProductoNombre
            // 
            this.CProductoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CProductoNombre.DataPropertyName = "ProductoNombre";
            this.CProductoNombre.HeaderText = "Producto";
            this.CProductoNombre.Name = "CProductoNombre";
            this.CProductoNombre.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 80;
            // 
            // CPrecioVentaUnitario
            // 
            this.CPrecioVentaUnitario.DataPropertyName = "PrecioVentaUnitario";
            this.CPrecioVentaUnitario.HeaderText = "Precio Unitario";
            this.CPrecioVentaUnitario.Name = "CPrecioVentaUnitario";
            this.CPrecioVentaUnitario.ReadOnly = true;
            // 
            // BtnProductoAgregar
            // 
            this.BtnProductoAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnProductoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoAgregar.Image")));
            this.BtnProductoAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoAgregar.Name = "BtnProductoAgregar";
            this.BtnProductoAgregar.Size = new System.Drawing.Size(121, 22);
            this.BtnProductoAgregar.Text = "Agregar Producto";
            this.BtnProductoAgregar.Click += new System.EventHandler(this.BtnProductoAgregar_Click);
            // 
            // BtnProductoEditar
            // 
            this.BtnProductoEditar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnProductoEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoEditar.Image")));
            this.BtnProductoEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoEditar.Name = "BtnProductoEditar";
            this.BtnProductoEditar.Size = new System.Drawing.Size(130, 22);
            this.BtnProductoEditar.Text = "Modificar Producto";
            // 
            // BtnProductoEliminar
            // 
            this.BtnProductoEliminar.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnProductoEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProductoEliminar.Image")));
            this.BtnProductoEliminar.ImageTransparentColor = System.Drawing.Color.LightYellow;
            this.BtnProductoEliminar.Name = "BtnProductoEliminar";
            this.BtnProductoEliminar.Size = new System.Drawing.Size(122, 22);
            this.BtnProductoEliminar.Text = "Eliminar Producto";
            // 
            // FrmRegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 500);
            this.Controls.Add(this.BtnCrearCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CboxCompraTipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Compra";
            this.Load += new System.EventHandler(this.FrmRegistroCompra_Load);
            this.CboxCompraTipo.ResumeLayout(false);
            this.CboxCompraTipo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CboxCompraTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnProveedorBuscar;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxTipoCompra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnProductoAgregar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVentaUnitario;
        private System.Windows.Forms.ToolStripButton BtnProductoEditar;
        private System.Windows.Forms.ToolStripButton BtnProductoEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCrearCompra;
    }
}