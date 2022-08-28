namespace comunicasionDatos
{
    partial class ping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ping));
            this.textPing = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pConteier = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RichPing = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.PicAlert = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGraficas = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnDns = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuaradarDns = new System.Windows.Forms.Button();
            this.dgDns = new System.Windows.Forms.DataGridView();
            this.direccionDns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttlDns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACKDns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitsDns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosGridBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datosGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosGridBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textDns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbPing = new System.Windows.Forms.PictureBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pConteier.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // textPing
            // 
            this.textPing.BackColor = System.Drawing.Color.LightGray;
            this.textPing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPing.ForeColor = System.Drawing.Color.Black;
            this.textPing.Location = new System.Drawing.Point(57, 96);
            this.textPing.Name = "textPing";
            this.textPing.Size = new System.Drawing.Size(98, 16);
            this.textPing.TabIndex = 0;
            this.textPing.Tag = "Nombre";
            this.textPing.TextChanged += new System.EventHandler(this.textPing_TextChanged);
            this.textPing.Enter += new System.EventHandler(this.txtEnter);
            this.textPing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPing_KeyPress);
            this.textPing.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pConteier
            // 
            this.pConteier.BackColor = System.Drawing.Color.White;
            this.pConteier.Controls.Add(this.panel3);
            this.pConteier.Controls.Add(this.RichPing);
            this.pConteier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConteier.Location = new System.Drawing.Point(0, 0);
            this.pConteier.Name = "pConteier";
            this.pConteier.Size = new System.Drawing.Size(170, 506);
            this.pConteier.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 62);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // RichPing
            // 
            this.RichPing.BackColor = System.Drawing.Color.Gainsboro;
            this.RichPing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichPing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichPing.ForeColor = System.Drawing.Color.Black;
            this.RichPing.Location = new System.Drawing.Point(0, -149);
            this.RichPing.Name = "RichPing";
            this.RichPing.Size = new System.Drawing.Size(170, 655);
            this.RichPing.TabIndex = 10;
            this.RichPing.Text = "";
            this.RichPing.TextChanged += new System.EventHandler(this.RichPing_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.LightGray;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(53, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "PING Dns";
            // 
            // PicAlert
            // 
            this.PicAlert.BackColor = System.Drawing.Color.LightGray;
            this.PicAlert.Location = new System.Drawing.Point(44, 83);
            this.PicAlert.Name = "PicAlert";
            this.PicAlert.Size = new System.Drawing.Size(122, 43);
            this.PicAlert.TabIndex = 5;
            this.PicAlert.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.BackColor = System.Drawing.Color.Black;
            this.pbNombre.Location = new System.Drawing.Point(42, 81);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(126, 47);
            this.pbNombre.TabIndex = 5;
            this.pbNombre.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(0, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 27);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "PING DNS";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pConteier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 506);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnGraficas);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.btnDns);
            this.panel2.Controls.Add(this.btnLeer);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnGuaradarDns);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 62);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnGraficas
            // 
            this.btnGraficas.BackColor = System.Drawing.Color.White;
            this.btnGraficas.FlatAppearance.BorderSize = 0;
            this.btnGraficas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficas.Location = new System.Drawing.Point(324, 0);
            this.btnGraficas.Name = "btnGraficas";
            this.btnGraficas.Size = new System.Drawing.Size(131, 27);
            this.btnGraficas.TabIndex = 25;
            this.btnGraficas.Text = "Graficar";
            this.btnGraficas.UseVisualStyleBackColor = false;
            this.btnGraficas.Click += new System.EventHandler(this.btnGraficas_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(108, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "limpiar rich";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(814, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(42, 27);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "limpiar grid";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnDns
            // 
            this.btnDns.BackColor = System.Drawing.Color.White;
            this.btnDns.FlatAppearance.BorderSize = 0;
            this.btnDns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDns.Location = new System.Drawing.Point(108, 0);
            this.btnDns.Name = "btnDns";
            this.btnDns.Size = new System.Drawing.Size(111, 27);
            this.btnDns.TabIndex = 20;
            this.btnDns.Text = "PING";
            this.btnDns.UseVisualStyleBackColor = false;
            this.btnDns.Click += new System.EventHandler(this.btnDns_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.White;
            this.btnLeer.FlatAppearance.BorderSize = 0;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeer.Location = new System.Drawing.Point(452, 0);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(128, 27);
            this.btnLeer.TabIndex = 15;
            this.btnLeer.Text = "leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(576, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 27);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuaradarDns
            // 
            this.btnGuaradarDns.BackColor = System.Drawing.Color.White;
            this.btnGuaradarDns.FlatAppearance.BorderSize = 0;
            this.btnGuaradarDns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuaradarDns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuaradarDns.Location = new System.Drawing.Point(215, 0);
            this.btnGuaradarDns.Name = "btnGuaradarDns";
            this.btnGuaradarDns.Size = new System.Drawing.Size(113, 27);
            this.btnGuaradarDns.TabIndex = 11;
            this.btnGuaradarDns.Text = "guardar";
            this.btnGuaradarDns.UseVisualStyleBackColor = false;
            this.btnGuaradarDns.Click += new System.EventHandler(this.btnGuaradarDns_Click);
            // 
            // dgDns
            // 
            this.dgDns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.direccionDns,
            this.ttlDns,
            this.tiempoDns,
            this.PACKDns,
            this.BitsDns,
            this.Dns});
            this.dgDns.Location = new System.Drawing.Point(232, 307);
            this.dgDns.Name = "dgDns";
            this.dgDns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgDns.Size = new System.Drawing.Size(540, 191);
            this.dgDns.TabIndex = 23;
            // 
            // direccionDns
            // 
            this.direccionDns.HeaderText = "direccion ip";
            this.direccionDns.Name = "direccionDns";
            // 
            // ttlDns
            // 
            this.ttlDns.HeaderText = "TTL";
            this.ttlDns.Name = "ttlDns";
            // 
            // tiempoDns
            // 
            this.tiempoDns.HeaderText = "tiempo";
            this.tiempoDns.Name = "tiempoDns";
            // 
            // PACKDns
            // 
            this.PACKDns.HeaderText = "PACK";
            this.PACKDns.Name = "PACKDns";
            // 
            // BitsDns
            // 
            this.BitsDns.HeaderText = "BITS";
            this.BitsDns.Name = "BitsDns";
            // 
            // Dns
            // 
            this.Dns.HeaderText = "DNS";
            this.Dns.Name = "Dns";
            // 
            // datosGridBindingSource2
            // 
            this.datosGridBindingSource2.DataSource = typeof(diseños.datosGrid);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 47);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.textDns);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textPing);
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.lblNombre);
            this.panel5.Controls.Add(this.PicAlert);
            this.panel5.Controls.Add(this.pbPing);
            this.panel5.Controls.Add(this.pbNombre);
            this.panel5.Location = new System.Drawing.Point(827, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 655);
            this.panel5.TabIndex = 25;
            // 
            // textDns
            // 
            this.textDns.BackColor = System.Drawing.Color.LightGray;
            this.textDns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDns.Location = new System.Drawing.Point(57, 183);
            this.textDns.Multiline = true;
            this.textDns.Name = "textDns";
            this.textDns.Size = new System.Drawing.Size(98, 21);
            this.textDns.TabIndex = 9;
            this.textDns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ping";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox6.Location = new System.Drawing.Point(45, 170);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(122, 43);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pbPing
            // 
            this.pbPing.BackColor = System.Drawing.Color.Black;
            this.pbPing.Location = new System.Drawing.Point(43, 168);
            this.pbPing.Name = "pbPing";
            this.pbPing.Size = new System.Drawing.Size(126, 47);
            this.pbPing.TabIndex = 5;
            this.pbPing.TabStop = false;
            this.pbPing.Tag = "Nombre";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.TTL,
            this.tiempo,
            this.pack,
            this.bits});
            this.dgDatos.Location = new System.Drawing.Point(232, 102);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.Size = new System.Drawing.Size(540, 188);
            this.dgDatos.TabIndex = 26;
            // 
            // IP
            // 
            this.IP.HeaderText = "direccion Ip";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // TTL
            // 
            this.TTL.HeaderText = "TTL";
            this.TTL.Name = "TTL";
            this.TTL.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // pack
            // 
            this.pack.HeaderText = "paquetes";
            this.pack.Name = "pack";
            this.pack.ReadOnly = true;
            // 
            // bits
            // 
            this.bits.HeaderText = "Bits";
            this.bits.Name = "bits";
            this.bits.ReadOnly = true;
            // 
            // ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 506);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.dgDns);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "q";
            this.Load += new System.EventHandler(this.ping_Load);
            this.pConteier.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGridBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pConteier;
        private System.Windows.Forms.PictureBox PicAlert;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textPing;
        public System.Windows.Forms.RichTextBox RichPing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dgDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttlDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACKDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitsDns;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dns;
        private System.Windows.Forms.Button btnDns;
        private System.Windows.Forms.Button btnGuaradarDns;
        private System.Windows.Forms.BindingSource datosGridBindingSource1;
        private System.Windows.Forms.BindingSource datosGridBindingSource;
        private System.Windows.Forms.BindingSource datosGridBindingSource2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textDns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbPing;
        private System.Windows.Forms.Button btnGraficas;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn bits;
    }
}