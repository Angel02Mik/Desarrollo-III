namespace vista
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.lb_nombreNegocio = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_hora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(328, 129);
            this.txt_usuario.Multiline = true;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(232, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(328, 181);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(232, 20);
            this.txt_password.TabIndex = 1;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.BorderSize = 0;
            this.bt_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(370, 225);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(90, 28);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.Bt_cancelar_Click);
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.bt_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt_ingresar.FlatAppearance.BorderSize = 0;
            this.bt_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.Black;
            this.bt_ingresar.Location = new System.Drawing.Point(478, 227);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(89, 28);
            this.bt_ingresar.TabIndex = 2;
            this.bt_ingresar.Text = "Ingresar";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.Bt_ingresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::vista.Properties.Resources.iconfinder_user_1011341;
            this.button1.Location = new System.Drawing.Point(295, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::vista.Properties.Resources.key;
            this.button3.Location = new System.Drawing.Point(295, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::vista.Properties.Resources.logo;
            this.pb_logo.Location = new System.Drawing.Point(56, 77);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(206, 198);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 3;
            this.pb_logo.TabStop = false;
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Image = global::vista.Properties.Resources.min;
            this.bt_minimizar.Location = new System.Drawing.Point(56, 298);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(33, 27);
            this.bt_minimizar.TabIndex = 42;
            this.bt_minimizar.UseVisualStyleBackColor = false;
            this.bt_minimizar.Click += new System.EventHandler(this.Bt_minimizar_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatAppearance.BorderSize = 0;
            this.bt_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrar.Image = global::vista.Properties.Resources.cerrar3;
            this.bt_cerrar.Location = new System.Drawing.Point(95, 298);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(33, 27);
            this.bt_cerrar.TabIndex = 42;
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.Bt_cerrar_Click);
            // 
            // lb_nombreNegocio
            // 
            this.lb_nombreNegocio.AutoSize = true;
            this.lb_nombreNegocio.BackColor = System.Drawing.Color.Transparent;
            this.lb_nombreNegocio.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombreNegocio.ForeColor = System.Drawing.Color.White;
            this.lb_nombreNegocio.Location = new System.Drawing.Point(291, 299);
            this.lb_nombreNegocio.Name = "lb_nombreNegocio";
            this.lb_nombreNegocio.Size = new System.Drawing.Size(92, 22);
            this.lb_nombreNegocio.TabIndex = 52;
            this.lb_nombreNegocio.Text = "MYSISTEM";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.BackColor = System.Drawing.Color.Transparent;
            this.lb_hora.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.Color.White;
            this.lb_hora.Location = new System.Drawing.Point(525, 303);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(46, 22);
            this.lb_hora.TabIndex = 52;
            this.lb_hora.Text = "hora";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::vista.Properties.Resources.banner1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(652, 350);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_nombreNegocio);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_minimizar);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.Label lb_nombreNegocio;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_hora;
    }
}