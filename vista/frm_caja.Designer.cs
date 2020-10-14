namespace vista
{
    partial class frm_caja
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreNegocio = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.char_caja = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bt_cerrarCaja = new System.Windows.Forms.Button();
            this.bt_abrirCaja = new System.Windows.Forms.Button();
            this.bt_movimiento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.char_caja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 64);
            this.panel1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(33, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 4);
            this.panel3.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 131;
            this.label5.Text = "MONTO INICIAL + SALDO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 132;
            this.label3.Text = "SALDO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 133;
            this.label2.Text = "EGRESO TOTAL";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(296, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 134;
            this.label9.Text = "1000";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(296, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 19);
            this.label8.TabIndex = 135;
            this.label8.Text = "1000";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(296, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 136;
            this.label7.Text = "1000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(296, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 137;
            this.label6.Text = "1000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 138;
            this.label1.Text = "INGRESO TOTAL";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 139;
            this.label4.Text = "Monto Inicial";
            // 
            // txt_nombreNegocio
            // 
            this.txt_nombreNegocio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombreNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombreNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreNegocio.Location = new System.Drawing.Point(130, 110);
            this.txt_nombreNegocio.Name = "txt_nombreNegocio";
            this.txt_nombreNegocio.Size = new System.Drawing.Size(73, 22);
            this.txt_nombreNegocio.TabIndex = 130;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(124)))), ((int)(((byte)(131)))));
            this.panel11.Location = new System.Drawing.Point(465, 439);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(14, 14);
            this.panel11.TabIndex = 156;
            // 
            // char_caja
            // 
            this.char_caja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.char_caja.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.char_caja.ChartAreas.Add(chartArea1);
            this.char_caja.Location = new System.Drawing.Point(464, 131);
            this.char_caja.Name = "char_caja";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.Name = "serie_uno";
            this.char_caja.Series.Add(series1);
            this.char_caja.Size = new System.Drawing.Size(380, 288);
            this.char_caja.TabIndex = 152;
            title1.Name = "Title1";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            this.char_caja.Titles.Add(title1);
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.panel16.Location = new System.Drawing.Point(668, 477);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(14, 14);
            this.panel16.TabIndex = 147;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(485, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 141;
            this.label15.Text = "MONTO INICIAL";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(227)))), ((int)(((byte)(111)))));
            this.panel12.Location = new System.Drawing.Point(556, 439);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(14, 14);
            this.panel12.TabIndex = 148;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(576, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 142;
            this.label16.Text = "INGRESO MENSUAL";
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel15.Location = new System.Drawing.Point(579, 477);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(14, 14);
            this.panel15.TabIndex = 149;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(2)))), ((int)(((byte)(59)))));
            this.panel13.Location = new System.Drawing.Point(657, 439);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(14, 14);
            this.panel13.TabIndex = 150;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(677, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 15);
            this.label17.TabIndex = 143;
            this.label17.Text = "DEVOLUCIONES";
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(245)))), ((int)(((byte)(82)))));
            this.panel14.Location = new System.Drawing.Point(746, 439);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(14, 14);
            this.panel14.TabIndex = 151;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(688, 477);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 14);
            this.label20.TabIndex = 144;
            this.label20.Text = "GASTOS";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(766, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 14);
            this.label18.TabIndex = 145;
            this.label18.Text = "DEUDA A COBRAR";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Tw Cen MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(599, 477);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 14);
            this.label19.TabIndex = 146;
            this.label19.Text = "DEUDA A PAGAR";
            // 
            // bt_cerrarCaja
            // 
            this.bt_cerrarCaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_cerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(49)))));
            this.bt_cerrarCaja.FlatAppearance.BorderSize = 0;
            this.bt_cerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cerrarCaja.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cerrarCaja.ForeColor = System.Drawing.Color.White;
            this.bt_cerrarCaja.Image = global::vista.Properties.Resources.iconfinder_cross_button_45933;
            this.bt_cerrarCaja.Location = new System.Drawing.Point(713, 107);
            this.bt_cerrarCaja.Name = "bt_cerrarCaja";
            this.bt_cerrarCaja.Size = new System.Drawing.Size(117, 28);
            this.bt_cerrarCaja.TabIndex = 154;
            this.bt_cerrarCaja.Text = "Cerrar Caja";
            this.bt_cerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_cerrarCaja.UseVisualStyleBackColor = false;
            this.bt_cerrarCaja.Click += new System.EventHandler(this.Bt_cerrarCaja_Click);
            // 
            // bt_abrirCaja
            // 
            this.bt_abrirCaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_abrirCaja.BackColor = System.Drawing.Color.Silver;
            this.bt_abrirCaja.FlatAppearance.BorderSize = 0;
            this.bt_abrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_abrirCaja.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_abrirCaja.ForeColor = System.Drawing.Color.Black;
            this.bt_abrirCaja.Image = global::vista.Properties.Resources.iconfinder_icon_116_lock_open_314694;
            this.bt_abrirCaja.Location = new System.Drawing.Point(467, 107);
            this.bt_abrirCaja.Name = "bt_abrirCaja";
            this.bt_abrirCaja.Size = new System.Drawing.Size(117, 28);
            this.bt_abrirCaja.TabIndex = 153;
            this.bt_abrirCaja.Text = "Abrir Caja";
            this.bt_abrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_abrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_abrirCaja.UseVisualStyleBackColor = false;
            this.bt_abrirCaja.Click += new System.EventHandler(this.Bt_abrirCaja_Click);
            // 
            // bt_movimiento
            // 
            this.bt_movimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_movimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_movimiento.FlatAppearance.BorderSize = 0;
            this.bt_movimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_movimiento.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_movimiento.ForeColor = System.Drawing.Color.White;
            this.bt_movimiento.Image = global::vista.Properties.Resources.iconfinder_icon_40_clipboard_list_315162;
            this.bt_movimiento.Location = new System.Drawing.Point(590, 107);
            this.bt_movimiento.Name = "bt_movimiento";
            this.bt_movimiento.Size = new System.Drawing.Size(117, 28);
            this.bt_movimiento.TabIndex = 155;
            this.bt_movimiento.Text = "Movimiento";
            this.bt_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_movimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_movimiento.UseVisualStyleBackColor = false;
            this.bt_movimiento.Click += new System.EventHandler(this.Bt_movimiento_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::vista.Properties.Resources.icons8_bolsa_de_dinero_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = " Caja";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 570);
            this.Controls.Add(this.bt_cerrarCaja);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.bt_abrirCaja);
            this.Controls.Add(this.bt_movimiento);
            this.Controls.Add(this.char_caja);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombreNegocio);
            this.Controls.Add(this.panel1);
            this.Name = "frm_caja";
            this.Text = "frm_caja";
            this.Load += new System.EventHandler(this.Frm_caja_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.char_caja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_cerrarCaja;
        private System.Windows.Forms.Button bt_abrirCaja;
        private System.Windows.Forms.Button bt_movimiento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_nombreNegocio;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataVisualization.Charting.Chart char_caja;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}