namespace P520231_JEANCAV.Formularios
{
    partial class FrmProveedoresGestion
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
            this.DgListaProveedores = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.CbProveedorTipo = new System.Windows.Forms.ComboBox();
            this.TxtProveedorEmail = new System.Windows.Forms.TextBox();
            this.TxtProveedorNota = new System.Windows.Forms.TextBox();
            this.TxtProveedorCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProveedorNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgListaProveedores
            // 
            this.DgListaProveedores.AllowUserToAddRows = false;
            this.DgListaProveedores.AllowUserToDeleteRows = false;
            this.DgListaProveedores.AllowUserToOrderColumns = true;
            this.DgListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaProveedores.Location = new System.Drawing.Point(12, 29);
            this.DgListaProveedores.Name = "DgListaProveedores";
            this.DgListaProveedores.ReadOnly = true;
            this.DgListaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgListaProveedores.Size = new System.Drawing.Size(855, 213);
            this.DgListaProveedores.TabIndex = 0;
            this.DgListaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaProveedores_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(396, 543);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(103, 36);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProveedorDireccion);
            this.groupBox1.Controls.Add(this.CbProveedorTipo);
            this.groupBox1.Controls.Add(this.TxtProveedorEmail);
            this.groupBox1.Controls.Add(this.TxtProveedorNota);
            this.groupBox1.Controls.Add(this.TxtProveedorCedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtProveedorNombre);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 289);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtProveedorDireccion
            // 
            this.TxtProveedorDireccion.Location = new System.Drawing.Point(561, 163);
            this.TxtProveedorDireccion.Multiline = true;
            this.TxtProveedorDireccion.Name = "TxtProveedorDireccion";
            this.TxtProveedorDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProveedorDireccion.Size = new System.Drawing.Size(284, 90);
            this.TxtProveedorDireccion.TabIndex = 15;
            // 
            // CbProveedorTipo
            // 
            this.CbProveedorTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProveedorTipo.FormattingEnabled = true;
            this.CbProveedorTipo.Location = new System.Drawing.Point(127, 232);
            this.CbProveedorTipo.Name = "CbProveedorTipo";
            this.CbProveedorTipo.Size = new System.Drawing.Size(251, 21);
            this.CbProveedorTipo.TabIndex = 14;
            // 
            // TxtProveedorEmail
            // 
            this.TxtProveedorEmail.Location = new System.Drawing.Point(127, 195);
            this.TxtProveedorEmail.Name = "TxtProveedorEmail";
            this.TxtProveedorEmail.Size = new System.Drawing.Size(305, 20);
            this.TxtProveedorEmail.TabIndex = 12;
            this.TxtProveedorEmail.Leave += new System.EventHandler(this.TxtProveedorEmail_Leave);
            // 
            // TxtProveedorNota
            // 
            this.TxtProveedorNota.Location = new System.Drawing.Point(561, 85);
            this.TxtProveedorNota.Multiline = true;
            this.TxtProveedorNota.Name = "TxtProveedorNota";
            this.TxtProveedorNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtProveedorNota.Size = new System.Drawing.Size(281, 72);
            this.TxtProveedorNota.TabIndex = 11;
            // 
            // TxtProveedorCedula
            // 
            this.TxtProveedorCedula.Location = new System.Drawing.Point(127, 141);
            this.TxtProveedorCedula.Name = "TxtProveedorCedula";
            this.TxtProveedorCedula.Size = new System.Drawing.Size(305, 20);
            this.TxtProveedorCedula.TabIndex = 10;
            this.TxtProveedorCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorCedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Notas:";
            // 
            // TxtProveedorNombre
            // 
            this.TxtProveedorNombre.Location = new System.Drawing.Point(127, 85);
            this.TxtProveedorNombre.Name = "TxtProveedorNombre";
            this.TxtProveedorNombre.Size = new System.Drawing.Size(305, 20);
            this.TxtProveedorNombre.TabIndex = 9;
            // 
            // TxtUsuarioID
            // 
            this.TxtUsuarioID.Location = new System.Drawing.Point(156, 39);
            this.TxtUsuarioID.Name = "TxtUsuarioID";
            this.TxtUsuarioID.ReadOnly = true;
            this.TxtUsuarioID.Size = new System.Drawing.Size(276, 20);
            this.TxtUsuarioID.TabIndex = 8;
            this.TxtUsuarioID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código Proveedor:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(519, 543);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 36);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmProveedoresGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(879, 591);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgListaProveedores);
            this.Name = "FrmProveedoresGestion";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedoresGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgListaProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgListaProveedores;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtProveedorDireccion;
        private System.Windows.Forms.ComboBox CbProveedorTipo;
        private System.Windows.Forms.TextBox TxtProveedorEmail;
        private System.Windows.Forms.TextBox TxtProveedorCedula;
        private System.Windows.Forms.TextBox TxtProveedorNombre;
        private System.Windows.Forms.TextBox TxtUsuarioID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProveedorNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}