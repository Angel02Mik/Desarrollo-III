namespace vista
{
    partial class frm_configuracion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreNegocio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_usuario = new System.Windows.Forms.CheckBox();
            this.chk_proveedor = new System.Windows.Forms.CheckBox();
            this.chk_caja = new System.Windows.Forms.CheckBox();
            this.chk_cliente = new System.Windows.Forms.CheckBox();
            this.chk_cargo = new System.Windows.Forms.CheckBox();
            this.chk_categoria = new System.Windows.Forms.CheckBox();
            this.chk_personal = new System.Windows.Forms.CheckBox();
            this.chk_producto = new System.Windows.Forms.CheckBox();
            this.chk_documento = new System.Windows.Forms.CheckBox();
            this.chk_ventas = new System.Windows.Forms.CheckBox();
            this.chk_compras = new System.Windows.Forms.CheckBox();
            this.chk_inicio = new System.Windows.Forms.CheckBox();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.pb_mostrarLogo = new System.Windows.Forms.PictureBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_cargarLogo = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mostrarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 64);
            this.panel1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::vista.Properties.Resources.iconfinder_management_2799204__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = " Configuracion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre del negocio";
            // 
            // txt_nombreNegocio
            // 
            this.txt_nombreNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombreNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreNegocio.Location = new System.Drawing.Point(30, 58);
            this.txt_nombreNegocio.Name = "txt_nombreNegocio";
            this.txt_nombreNegocio.Size = new System.Drawing.Size(373, 22);
            this.txt_nombreNegocio.TabIndex = 34;
            this.txt_nombreNegocio.TextChanged += new System.EventHandler(this.Txt_nombreNegocio_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.chk_usuario);
            this.panel2.Controls.Add(this.chk_proveedor);
            this.panel2.Controls.Add(this.chk_caja);
            this.panel2.Controls.Add(this.chk_cliente);
            this.panel2.Controls.Add(this.chk_cargo);
            this.panel2.Controls.Add(this.chk_categoria);
            this.panel2.Controls.Add(this.chk_personal);
            this.panel2.Controls.Add(this.chk_producto);
            this.panel2.Controls.Add(this.chk_documento);
            this.panel2.Controls.Add(this.chk_ventas);
            this.panel2.Controls.Add(this.chk_compras);
            this.panel2.Controls.Add(this.chk_inicio);
            this.panel2.Controls.Add(this.cb_usuario);
            this.panel2.Controls.Add(this.pb_mostrarLogo);
            this.panel2.Controls.Add(this.bt_cancelar);
            this.panel2.Controls.Add(this.bt_cargarLogo);
            this.panel2.Controls.Add(this.bt_guardar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_nombreNegocio);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 309);
            this.panel2.TabIndex = 38;
            // 
            // chk_usuario
            // 
            this.chk_usuario.AutoSize = true;
            this.chk_usuario.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_usuario.ForeColor = System.Drawing.Color.White;
            this.chk_usuario.Location = new System.Drawing.Point(824, 252);
            this.chk_usuario.Name = "chk_usuario";
            this.chk_usuario.Size = new System.Drawing.Size(80, 23);
            this.chk_usuario.TabIndex = 40;
            this.chk_usuario.Text = "Usuario";
            this.chk_usuario.UseVisualStyleBackColor = true;
            // 
            // chk_proveedor
            // 
            this.chk_proveedor.AutoSize = true;
            this.chk_proveedor.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_proveedor.ForeColor = System.Drawing.Color.White;
            this.chk_proveedor.Location = new System.Drawing.Point(635, 254);
            this.chk_proveedor.Name = "chk_proveedor";
            this.chk_proveedor.Size = new System.Drawing.Size(99, 23);
            this.chk_proveedor.TabIndex = 40;
            this.chk_proveedor.Text = "Proveedor";
            this.chk_proveedor.UseVisualStyleBackColor = true;
            // 
            // chk_caja
            // 
            this.chk_caja.AutoSize = true;
            this.chk_caja.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_caja.ForeColor = System.Drawing.Color.White;
            this.chk_caja.Location = new System.Drawing.Point(824, 220);
            this.chk_caja.Name = "chk_caja";
            this.chk_caja.Size = new System.Drawing.Size(57, 23);
            this.chk_caja.TabIndex = 40;
            this.chk_caja.Text = "Caja";
            this.chk_caja.UseVisualStyleBackColor = true;
            // 
            // chk_cliente
            // 
            this.chk_cliente.AutoSize = true;
            this.chk_cliente.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_cliente.ForeColor = System.Drawing.Color.White;
            this.chk_cliente.Location = new System.Drawing.Point(635, 222);
            this.chk_cliente.Name = "chk_cliente";
            this.chk_cliente.Size = new System.Drawing.Size(74, 23);
            this.chk_cliente.TabIndex = 40;
            this.chk_cliente.Text = "Cliente";
            this.chk_cliente.UseVisualStyleBackColor = true;
            // 
            // chk_cargo
            // 
            this.chk_cargo.AutoSize = true;
            this.chk_cargo.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_cargo.ForeColor = System.Drawing.Color.White;
            this.chk_cargo.Location = new System.Drawing.Point(824, 188);
            this.chk_cargo.Name = "chk_cargo";
            this.chk_cargo.Size = new System.Drawing.Size(67, 23);
            this.chk_cargo.TabIndex = 40;
            this.chk_cargo.Text = "Cargo";
            this.chk_cargo.UseVisualStyleBackColor = true;
            // 
            // chk_categoria
            // 
            this.chk_categoria.AutoSize = true;
            this.chk_categoria.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_categoria.ForeColor = System.Drawing.Color.White;
            this.chk_categoria.Location = new System.Drawing.Point(635, 190);
            this.chk_categoria.Name = "chk_categoria";
            this.chk_categoria.Size = new System.Drawing.Size(91, 23);
            this.chk_categoria.TabIndex = 40;
            this.chk_categoria.Text = "Categoria";
            this.chk_categoria.UseVisualStyleBackColor = true;
            // 
            // chk_personal
            // 
            this.chk_personal.AutoSize = true;
            this.chk_personal.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_personal.ForeColor = System.Drawing.Color.White;
            this.chk_personal.Location = new System.Drawing.Point(824, 156);
            this.chk_personal.Name = "chk_personal";
            this.chk_personal.Size = new System.Drawing.Size(87, 23);
            this.chk_personal.TabIndex = 40;
            this.chk_personal.Text = "Personal";
            this.chk_personal.UseVisualStyleBackColor = true;
            // 
            // chk_producto
            // 
            this.chk_producto.AutoSize = true;
            this.chk_producto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_producto.ForeColor = System.Drawing.Color.White;
            this.chk_producto.Location = new System.Drawing.Point(635, 158);
            this.chk_producto.Name = "chk_producto";
            this.chk_producto.Size = new System.Drawing.Size(88, 23);
            this.chk_producto.TabIndex = 40;
            this.chk_producto.Text = "Producto";
            this.chk_producto.UseVisualStyleBackColor = true;
            // 
            // chk_documento
            // 
            this.chk_documento.AutoSize = true;
            this.chk_documento.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_documento.ForeColor = System.Drawing.Color.White;
            this.chk_documento.Location = new System.Drawing.Point(824, 124);
            this.chk_documento.Name = "chk_documento";
            this.chk_documento.Size = new System.Drawing.Size(105, 23);
            this.chk_documento.TabIndex = 40;
            this.chk_documento.Text = "Documento";
            this.chk_documento.UseVisualStyleBackColor = true;
            // 
            // chk_ventas
            // 
            this.chk_ventas.AutoSize = true;
            this.chk_ventas.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ventas.ForeColor = System.Drawing.Color.White;
            this.chk_ventas.Location = new System.Drawing.Point(635, 126);
            this.chk_ventas.Name = "chk_ventas";
            this.chk_ventas.Size = new System.Drawing.Size(74, 23);
            this.chk_ventas.TabIndex = 40;
            this.chk_ventas.Text = "Ventas";
            this.chk_ventas.UseVisualStyleBackColor = true;
            // 
            // chk_compras
            // 
            this.chk_compras.AutoSize = true;
            this.chk_compras.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_compras.ForeColor = System.Drawing.Color.White;
            this.chk_compras.Location = new System.Drawing.Point(824, 92);
            this.chk_compras.Name = "chk_compras";
            this.chk_compras.Size = new System.Drawing.Size(88, 23);
            this.chk_compras.TabIndex = 40;
            this.chk_compras.Text = "Compras";
            this.chk_compras.UseVisualStyleBackColor = true;
            // 
            // chk_inicio
            // 
            this.chk_inicio.AutoSize = true;
            this.chk_inicio.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_inicio.ForeColor = System.Drawing.Color.White;
            this.chk_inicio.Location = new System.Drawing.Point(635, 94);
            this.chk_inicio.Name = "chk_inicio";
            this.chk_inicio.Size = new System.Drawing.Size(64, 23);
            this.chk_inicio.TabIndex = 40;
            this.chk_inicio.Text = "Inicio";
            this.chk_inicio.UseVisualStyleBackColor = true;
            // 
            // cb_usuario
            // 
            this.cb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Location = new System.Drawing.Point(635, 58);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(294, 21);
            this.cb_usuario.TabIndex = 39;
            // 
            // pb_mostrarLogo
            // 
            this.pb_mostrarLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_mostrarLogo.Image = global::vista.Properties.Resources.SISTEMVENTA;
            this.pb_mostrarLogo.Location = new System.Drawing.Point(223, 92);
            this.pb_mostrarLogo.Name = "pb_mostrarLogo";
            this.pb_mostrarLogo.Size = new System.Drawing.Size(180, 140);
            this.pb_mostrarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mostrarLogo.TabIndex = 38;
            this.pb_mostrarLogo.TabStop = false;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Image = global::vista.Properties.Resources.iconfinder_cross_16189;
            this.bt_cancelar.Location = new System.Drawing.Point(151, 247);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(117, 28);
            this.bt_cancelar.TabIndex = 37;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // bt_cargarLogo
            // 
            this.bt_cargarLogo.BackColor = System.Drawing.Color.White;
            this.bt_cargarLogo.FlatAppearance.BorderSize = 0;
            this.bt_cargarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cargarLogo.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cargarLogo.ForeColor = System.Drawing.Color.Black;
            this.bt_cargarLogo.Image = global::vista.Properties.Resources.icons8_foto_16;
            this.bt_cargarLogo.Location = new System.Drawing.Point(30, 86);
            this.bt_cargarLogo.Name = "bt_cargarLogo";
            this.bt_cargarLogo.Size = new System.Drawing.Size(117, 28);
            this.bt_cargarLogo.TabIndex = 36;
            this.bt_cargarLogo.Text = "Cargar logo";
            this.bt_cargarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cargarLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cargarLogo.UseVisualStyleBackColor = false;
            this.bt_cargarLogo.Click += new System.EventHandler(this.Bt_cargarLogo_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(49)))));
            this.bt_guardar.FlatAppearance.BorderSize = 0;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.Color.White;
            this.bt_guardar.Image = global::vista.Properties.Resources.ok;
            this.bt_guardar.Location = new System.Drawing.Point(286, 247);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(117, 28);
            this.bt_guardar.TabIndex = 36;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.Bt_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(632, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Añadir Privilegios";
            // 
            // frm_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_configuracion";
            this.Text = "frm_configuracion";
            this.Load += new System.EventHandler(this.Frm_configuracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mostrarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_nombreNegocio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_mostrarLogo;
        private System.Windows.Forms.Button bt_cargarLogo;
        private System.Windows.Forms.CheckBox chk_usuario;
        private System.Windows.Forms.CheckBox chk_proveedor;
        private System.Windows.Forms.CheckBox chk_caja;
        private System.Windows.Forms.CheckBox chk_cliente;
        private System.Windows.Forms.CheckBox chk_cargo;
        private System.Windows.Forms.CheckBox chk_categoria;
        private System.Windows.Forms.CheckBox chk_personal;
        private System.Windows.Forms.CheckBox chk_producto;
        private System.Windows.Forms.CheckBox chk_documento;
        private System.Windows.Forms.CheckBox chk_ventas;
        private System.Windows.Forms.CheckBox chk_compras;
        private System.Windows.Forms.CheckBox chk_inicio;
        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.Label label2;
    }
}