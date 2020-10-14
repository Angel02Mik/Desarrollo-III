namespace vista
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_nombreUsuario = new System.Windows.Forms.Label();
            this.bt_completo = new System.Windows.Forms.Button();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_maximizar = new System.Windows.Forms.Button();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_configuracion = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_cerrarSesion = new System.Windows.Forms.Button();
            this.bt_unidadMedida = new System.Windows.Forms.Button();
            this.bt_caja = new System.Windows.Forms.Button();
            this.bt_cargo = new System.Windows.Forms.Button();
            this.bt_personal = new System.Windows.Forms.Button();
            this.bt_documento = new System.Windows.Forms.Button();
            this.bt_categoria = new System.Windows.Forms.Button();
            this.bt_usuario = new System.Windows.Forms.Button();
            this.bt_compras = new System.Windows.Forms.Button();
            this.bt_proveedor = new System.Windows.Forms.Button();
            this.bt_cliente = new System.Windows.Forms.Button();
            this.bt_producto = new System.Windows.Forms.Button();
            this.bt_venta = new System.Windows.Forms.Button();
            this.bt_inicio = new System.Windows.Forms.Button();
            this.pn_principal = new System.Windows.Forms.Panel();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.Black;
            this.pn_header.Controls.Add(this.lb_hora);
            this.pn_header.Controls.Add(this.lb_fecha);
            this.pn_header.Controls.Add(this.lb_nombreUsuario);
            this.pn_header.Controls.Add(this.bt_completo);
            this.pn_header.Controls.Add(this.bt_minimizar);
            this.pn_header.Controls.Add(this.bt_maximizar);
            this.pn_header.Controls.Add(this.bt_cerrar);
            this.pn_header.Controls.Add(this.button1);
            this.pn_header.Controls.Add(this.bt_configuracion);
            this.pn_header.Controls.Add(this.pb_logo);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1200, 58);
            this.pn_header.TabIndex = 0;
            this.pn_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pn_header_MouseMove);
            // 
            // lb_nombreUsuario
            // 
            this.lb_nombreUsuario.AutoSize = true;
            this.lb_nombreUsuario.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lb_nombreUsuario.Location = new System.Drawing.Point(168, 22);
            this.lb_nombreUsuario.Name = "lb_nombreUsuario";
            this.lb_nombreUsuario.Size = new System.Drawing.Size(92, 17);
            this.lb_nombreUsuario.TabIndex = 3;
            this.lb_nombreUsuario.Text = "Miguel Angel";
            // 
            // bt_completo
            // 
            this.bt_completo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_completo.FlatAppearance.BorderSize = 0;
            this.bt_completo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_completo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_completo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_completo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_completo.Image = global::vista.Properties.Resources.max;
            this.bt_completo.Location = new System.Drawing.Point(1126, 14);
            this.bt_completo.Name = "bt_completo";
            this.bt_completo.Size = new System.Drawing.Size(28, 32);
            this.bt_completo.TabIndex = 5;
            this.bt_completo.UseVisualStyleBackColor = true;
            this.bt_completo.Visible = false;
            this.bt_completo.Click += new System.EventHandler(this.Bt_completo_Click);
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Image = global::vista.Properties.Resources.minimizar;
            this.bt_minimizar.Location = new System.Drawing.Point(1092, 14);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(28, 32);
            this.bt_minimizar.TabIndex = 4;
            this.bt_minimizar.UseVisualStyleBackColor = true;
            this.bt_minimizar.Click += new System.EventHandler(this.Bt_minimizar_Click);
            // 
            // bt_maximizar
            // 
            this.bt_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximizar.Image = global::vista.Properties.Resources.min;
            this.bt_maximizar.Location = new System.Drawing.Point(1126, 14);
            this.bt_maximizar.Name = "bt_maximizar";
            this.bt_maximizar.Size = new System.Drawing.Size(28, 32);
            this.bt_maximizar.TabIndex = 4;
            this.bt_maximizar.UseVisualStyleBackColor = true;
            this.bt_maximizar.Click += new System.EventHandler(this.Bt_maximizar_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrar.Image = global::vista.Properties.Resources.cerrar3;
            this.bt_cerrar.Location = new System.Drawing.Point(1160, 14);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(28, 32);
            this.bt_cerrar.TabIndex = 4;
            this.bt_cerrar.UseVisualStyleBackColor = true;
            this.bt_cerrar.Click += new System.EventHandler(this.Bt_cerrar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::vista.Properties.Resources.iconfinder_user_101134;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(134, 11);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_configuracion
            // 
            this.bt_configuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_configuracion.FlatAppearance.BorderSize = 0;
            this.bt_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_configuracion.Image = global::vista.Properties.Resources.iconfinder_management_2799204__1_;
            this.bt_configuracion.Location = new System.Drawing.Point(1042, 10);
            this.bt_configuracion.Name = "bt_configuracion";
            this.bt_configuracion.Size = new System.Drawing.Size(44, 38);
            this.bt_configuracion.TabIndex = 1;
            this.bt_configuracion.UseVisualStyleBackColor = true;
            this.bt_configuracion.Click += new System.EventHandler(this.Bt_configuracion_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_logo.Image = global::vista.Properties.Resources.banner;
            this.pb_logo.Location = new System.Drawing.Point(0, 0);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(133, 58);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.bt_cerrarSesion);
            this.panel2.Controls.Add(this.bt_unidadMedida);
            this.panel2.Controls.Add(this.bt_caja);
            this.panel2.Controls.Add(this.bt_cargo);
            this.panel2.Controls.Add(this.bt_personal);
            this.panel2.Controls.Add(this.bt_documento);
            this.panel2.Controls.Add(this.bt_categoria);
            this.panel2.Controls.Add(this.bt_usuario);
            this.panel2.Controls.Add(this.bt_compras);
            this.panel2.Controls.Add(this.bt_proveedor);
            this.panel2.Controls.Add(this.bt_cliente);
            this.panel2.Controls.Add(this.bt_producto);
            this.panel2.Controls.Add(this.bt_venta);
            this.panel2.Controls.Add(this.bt_inicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 662);
            this.panel2.TabIndex = 1;
            // 
            // bt_cerrarSesion
            // 
            this.bt_cerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_cerrarSesion.FlatAppearance.BorderSize = 0;
            this.bt_cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrarSesion.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.bt_cerrarSesion.Image = global::vista.Properties.Resources.iconfinder_Cross_2001870;
            this.bt_cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cerrarSesion.Location = new System.Drawing.Point(0, 612);
            this.bt_cerrarSesion.Name = "bt_cerrarSesion";
            this.bt_cerrarSesion.Size = new System.Drawing.Size(133, 33);
            this.bt_cerrarSesion.TabIndex = 4;
            this.bt_cerrarSesion.Text = "   Cerrar Ses";
            this.bt_cerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cerrarSesion.UseVisualStyleBackColor = true;
            this.bt_cerrarSesion.Click += new System.EventHandler(this.Bt_cerrarSesion_Click);
            // 
            // bt_unidadMedida
            // 
            this.bt_unidadMedida.BackColor = System.Drawing.Color.Black;
            this.bt_unidadMedida.FlatAppearance.BorderSize = 0;
            this.bt_unidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_unidadMedida.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_unidadMedida.ForeColor = System.Drawing.Color.White;
            this.bt_unidadMedida.Image = global::vista.Properties.Resources.icons8_balanza_24;
            this.bt_unidadMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_unidadMedida.Location = new System.Drawing.Point(0, 518);
            this.bt_unidadMedida.Name = "bt_unidadMedida";
            this.bt_unidadMedida.Size = new System.Drawing.Size(133, 41);
            this.bt_unidadMedida.TabIndex = 2;
            this.bt_unidadMedida.Text = "   Unidad-M";
            this.bt_unidadMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_unidadMedida.UseVisualStyleBackColor = false;
            this.bt_unidadMedida.Click += new System.EventHandler(this.Bt_unidadMedida_Click);
            // 
            // bt_caja
            // 
            this.bt_caja.BackColor = System.Drawing.Color.Black;
            this.bt_caja.FlatAppearance.BorderSize = 0;
            this.bt_caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_caja.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_caja.ForeColor = System.Drawing.Color.White;
            this.bt_caja.Image = global::vista.Properties.Resources.icons8_bolsa_de_dinero_24;
            this.bt_caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_caja.Location = new System.Drawing.Point(0, 476);
            this.bt_caja.Name = "bt_caja";
            this.bt_caja.Size = new System.Drawing.Size(133, 41);
            this.bt_caja.TabIndex = 2;
            this.bt_caja.Text = "   Caja";
            this.bt_caja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_caja.UseVisualStyleBackColor = false;
            this.bt_caja.Click += new System.EventHandler(this.Bt_caja_Click);
            // 
            // bt_cargo
            // 
            this.bt_cargo.FlatAppearance.BorderSize = 0;
            this.bt_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cargo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_cargo.ForeColor = System.Drawing.Color.White;
            this.bt_cargo.Image = global::vista.Properties.Resources.iconfinder_Profile_10593;
            this.bt_cargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cargo.Location = new System.Drawing.Point(0, 429);
            this.bt_cargo.Name = "bt_cargo";
            this.bt_cargo.Size = new System.Drawing.Size(133, 41);
            this.bt_cargo.TabIndex = 1;
            this.bt_cargo.Text = "   Cargo";
            this.bt_cargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cargo.UseVisualStyleBackColor = true;
            this.bt_cargo.Click += new System.EventHandler(this.Bt_cargo_Click);
            // 
            // bt_personal
            // 
            this.bt_personal.FlatAppearance.BorderSize = 0;
            this.bt_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_personal.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_personal.ForeColor = System.Drawing.Color.White;
            this.bt_personal.Image = global::vista.Properties.Resources.iconfinder_User_27887;
            this.bt_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_personal.Location = new System.Drawing.Point(0, 382);
            this.bt_personal.Name = "bt_personal";
            this.bt_personal.Size = new System.Drawing.Size(133, 41);
            this.bt_personal.TabIndex = 1;
            this.bt_personal.Text = "   Personal";
            this.bt_personal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_personal.UseVisualStyleBackColor = true;
            this.bt_personal.Click += new System.EventHandler(this.Bt_personal_Click);
            // 
            // bt_documento
            // 
            this.bt_documento.FlatAppearance.BorderSize = 0;
            this.bt_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_documento.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_documento.ForeColor = System.Drawing.Color.White;
            this.bt_documento.Image = global::vista.Properties.Resources.icons8_documento_24;
            this.bt_documento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_documento.Location = new System.Drawing.Point(0, 335);
            this.bt_documento.Name = "bt_documento";
            this.bt_documento.Size = new System.Drawing.Size(133, 41);
            this.bt_documento.TabIndex = 1;
            this.bt_documento.Text = "   Documento";
            this.bt_documento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_documento.UseVisualStyleBackColor = true;
            this.bt_documento.Click += new System.EventHandler(this.Bt_documento_Click);
            // 
            // bt_categoria
            // 
            this.bt_categoria.FlatAppearance.BorderSize = 0;
            this.bt_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_categoria.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_categoria.ForeColor = System.Drawing.Color.White;
            this.bt_categoria.Image = global::vista.Properties.Resources.icons8_abrir_carpeta_24;
            this.bt_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_categoria.Location = new System.Drawing.Point(0, 147);
            this.bt_categoria.Name = "bt_categoria";
            this.bt_categoria.Size = new System.Drawing.Size(133, 41);
            this.bt_categoria.TabIndex = 0;
            this.bt_categoria.Text = "   Categoria";
            this.bt_categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_categoria.UseVisualStyleBackColor = true;
            this.bt_categoria.Click += new System.EventHandler(this.Bt_categoria_Click);
            // 
            // bt_usuario
            // 
            this.bt_usuario.FlatAppearance.BorderSize = 0;
            this.bt_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuario.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuario.ForeColor = System.Drawing.Color.White;
            this.bt_usuario.Image = global::vista.Properties.Resources.iconfinder_contact_new_23203;
            this.bt_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_usuario.Location = new System.Drawing.Point(0, 565);
            this.bt_usuario.Name = "bt_usuario";
            this.bt_usuario.Size = new System.Drawing.Size(133, 41);
            this.bt_usuario.TabIndex = 0;
            this.bt_usuario.Text = "   Usuario";
            this.bt_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_usuario.UseVisualStyleBackColor = true;
            this.bt_usuario.Click += new System.EventHandler(this.Bt_usuario_Click);
            // 
            // bt_compras
            // 
            this.bt_compras.FlatAppearance.BorderSize = 0;
            this.bt_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_compras.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compras.ForeColor = System.Drawing.Color.White;
            this.bt_compras.Image = global::vista.Properties.Resources.iconfinder_Money_3387302;
            this.bt_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_compras.Location = new System.Drawing.Point(0, 288);
            this.bt_compras.Name = "bt_compras";
            this.bt_compras.Size = new System.Drawing.Size(133, 41);
            this.bt_compras.TabIndex = 0;
            this.bt_compras.Text = "   Compras";
            this.bt_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_compras.UseVisualStyleBackColor = true;
            this.bt_compras.Click += new System.EventHandler(this.Bt_compras_Click);
            // 
            // bt_proveedor
            // 
            this.bt_proveedor.FlatAppearance.BorderSize = 0;
            this.bt_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_proveedor.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proveedor.ForeColor = System.Drawing.Color.White;
            this.bt_proveedor.Image = global::vista.Properties.Resources.icons8_proveedor_24;
            this.bt_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_proveedor.Location = new System.Drawing.Point(0, 241);
            this.bt_proveedor.Name = "bt_proveedor";
            this.bt_proveedor.Size = new System.Drawing.Size(133, 41);
            this.bt_proveedor.TabIndex = 0;
            this.bt_proveedor.Text = "   Proveedor";
            this.bt_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_proveedor.UseVisualStyleBackColor = true;
            this.bt_proveedor.Click += new System.EventHandler(this.Bt_proveedor_Click);
            // 
            // bt_cliente
            // 
            this.bt_cliente.FlatAppearance.BorderSize = 0;
            this.bt_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cliente.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cliente.ForeColor = System.Drawing.Color.White;
            this.bt_cliente.Image = global::vista.Properties.Resources.iconfinder_User_group_132433;
            this.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cliente.Location = new System.Drawing.Point(0, 194);
            this.bt_cliente.Name = "bt_cliente";
            this.bt_cliente.Size = new System.Drawing.Size(133, 41);
            this.bt_cliente.TabIndex = 0;
            this.bt_cliente.Text = "   Cliente";
            this.bt_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cliente.UseVisualStyleBackColor = true;
            this.bt_cliente.Click += new System.EventHandler(this.Bt_cliente_Click);
            // 
            // bt_producto
            // 
            this.bt_producto.FlatAppearance.BorderSize = 0;
            this.bt_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_producto.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_producto.ForeColor = System.Drawing.Color.White;
            this.bt_producto.Image = global::vista.Properties.Resources.iconfinder_send_box_45273;
            this.bt_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_producto.Location = new System.Drawing.Point(0, 100);
            this.bt_producto.Name = "bt_producto";
            this.bt_producto.Size = new System.Drawing.Size(133, 41);
            this.bt_producto.TabIndex = 0;
            this.bt_producto.Text = "   Producto";
            this.bt_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_producto.UseVisualStyleBackColor = true;
            this.bt_producto.Click += new System.EventHandler(this.Bt_producto_Click);
            // 
            // bt_venta
            // 
            this.bt_venta.FlatAppearance.BorderSize = 0;
            this.bt_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_venta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_venta.ForeColor = System.Drawing.Color.White;
            this.bt_venta.Image = global::vista.Properties.Resources.iconfinder_shoping_cart_87085;
            this.bt_venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_venta.Location = new System.Drawing.Point(0, 53);
            this.bt_venta.Name = "bt_venta";
            this.bt_venta.Size = new System.Drawing.Size(133, 41);
            this.bt_venta.TabIndex = 0;
            this.bt_venta.Text = "   Ventas";
            this.bt_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_venta.UseVisualStyleBackColor = true;
            this.bt_venta.Click += new System.EventHandler(this.Bt_venta_Click);
            // 
            // bt_inicio
            // 
            this.bt_inicio.FlatAppearance.BorderSize = 0;
            this.bt_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inicio.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inicio.ForeColor = System.Drawing.Color.White;
            this.bt_inicio.Image = global::vista.Properties.Resources.iconfinder_kfm_home_1323;
            this.bt_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_inicio.Location = new System.Drawing.Point(0, 6);
            this.bt_inicio.Name = "bt_inicio";
            this.bt_inicio.Size = new System.Drawing.Size(133, 41);
            this.bt_inicio.TabIndex = 0;
            this.bt_inicio.Text = "   Inicio";
            this.bt_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_inicio.UseVisualStyleBackColor = true;
            this.bt_inicio.Click += new System.EventHandler(this.Bt_inicio_Click);
            // 
            // pn_principal
            // 
            this.pn_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_principal.Location = new System.Drawing.Point(133, 58);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1067, 662);
            this.pn_principal.TabIndex = 3;
            // 
            // lb_fecha
            // 
            this.lb_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.Color.White;
            this.lb_fecha.Location = new System.Drawing.Point(630, 22);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(92, 24);
            this.lb_fecha.TabIndex = 6;
            this.lb_fecha.Text = "2019-06-09";
            // 
            // lb_hora
            // 
            this.lb_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.Color.White;
            this.lb_hora.Location = new System.Drawing.Point(909, 22);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(92, 24);
            this.lb_hora.TabIndex = 6;
            this.lb_hora.Text = "2019-06-09";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pn_principal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1200, 702);
            this.Name = "frm_principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_categoria;
        private System.Windows.Forms.Button bt_usuario;
        private System.Windows.Forms.Button bt_compras;
        private System.Windows.Forms.Button bt_proveedor;
        private System.Windows.Forms.Button bt_cliente;
        private System.Windows.Forms.Button bt_producto;
        private System.Windows.Forms.Button bt_venta;
        private System.Windows.Forms.Button bt_inicio;
        private System.Windows.Forms.Panel pn_principal;
        private System.Windows.Forms.Button bt_documento;
        private System.Windows.Forms.Button bt_cargo;
        private System.Windows.Forms.Button bt_personal;
        private System.Windows.Forms.Button bt_caja;
        private System.Windows.Forms.Button bt_unidadMedida;
        private System.Windows.Forms.Button bt_configuracion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Button bt_cerrarSesion;
        private System.Windows.Forms.Button bt_maximizar;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_completo;
        public System.Windows.Forms.PictureBox pb_logo;
        public System.Windows.Forms.Label lb_nombreUsuario;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Timer timer;
    }
}

