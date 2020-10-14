namespace vista
{
    partial class frm_producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_producto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_totalRegistro = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_producto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_producto
            // 
            this.dg_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_producto.BackgroundColor = System.Drawing.Color.White;
            this.dg_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_producto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_producto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dg_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_producto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_producto.EnableHeadersVisualStyles = false;
            this.dg_producto.Location = new System.Drawing.Point(12, 115);
            this.dg_producto.Name = "dg_producto";
            this.dg_producto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_producto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_producto.RowHeadersWidth = 20;
            this.dg_producto.Size = new System.Drawing.Size(776, 311);
            this.dg_producto.TabIndex = 0;
            this.dg_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_producto_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::vista.Properties.Resources.iconfinder_send_box_45273;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = " Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_totalRegistro
            // 
            this.lb_totalRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_totalRegistro.AutoSize = true;
            this.lb_totalRegistro.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalRegistro.Location = new System.Drawing.Point(12, 428);
            this.lb_totalRegistro.Name = "lb_totalRegistro";
            this.lb_totalRegistro.Size = new System.Drawing.Size(118, 19);
            this.lb_totalRegistro.TabIndex = 3;
            this.lb_totalRegistro.Text = "Total registro: 100";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(71, 9);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(228, 22);
            this.txt_busqueda.TabIndex = 11;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.Txt_busqueda_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_busqueda);
            this.panel2.Location = new System.Drawing.Point(478, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 39);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "BUSCAR";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.SystemColors.Control;
            this.bt_eliminar.FlatAppearance.BorderSize = 0;
            this.bt_eliminar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.Color.Black;
            this.bt_eliminar.Image = global::vista.Properties.Resources.delete1__2_;
            this.bt_eliminar.Location = new System.Drawing.Point(222, 75);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(99, 33);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.Bt_eliminar_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.SystemColors.Control;
            this.bt_modificar.FlatAppearance.BorderSize = 0;
            this.bt_modificar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificar.ForeColor = System.Drawing.Color.Black;
            this.bt_modificar.Image = global::vista.Properties.Resources.edit;
            this.bt_modificar.Location = new System.Drawing.Point(117, 75);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(99, 33);
            this.bt_modificar.TabIndex = 2;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Click += new System.EventHandler(this.Bt_modificar_Click);
            // 
            // bt_insertar
            // 
            this.bt_insertar.BackColor = System.Drawing.SystemColors.Control;
            this.bt_insertar.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_insertar.ForeColor = System.Drawing.Color.Black;
            this.bt_insertar.Image = global::vista.Properties.Resources.iconfinder_13_62655;
            this.bt_insertar.Location = new System.Drawing.Point(12, 75);
            this.bt_insertar.Name = "bt_insertar";
            this.bt_insertar.Size = new System.Drawing.Size(99, 33);
            this.bt_insertar.TabIndex = 2;
            this.bt_insertar.Text = "Nuevo";
            this.bt_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_insertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_insertar.UseVisualStyleBackColor = false;
            this.bt_insertar.Click += new System.EventHandler(this.Bt_insertar_Click);
            // 
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_totalRegistro);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_insertar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_producto);
            this.Name = "frm_producto";
            this.Text = "frm_producto";
            this.Load += new System.EventHandler(this.Frm_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_producto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_insertar;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_totalRegistro;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}