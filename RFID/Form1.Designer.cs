namespace RFID
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbFlecha = new System.Windows.Forms.PictureBox();
            this.btnRegistroicon = new FontAwesome.Sharp.IconButton();
            this.btnDatosusuarioicon = new FontAwesome.Sharp.IconButton();
            this.btnConexionicon = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaudios = new System.Windows.Forms.Label();
            this.cmbBaudios = new System.Windows.Forms.ComboBox();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnPuerto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chbBuscarID = new System.Windows.Forms.CheckBox();
            this.chbBuscarNombre = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblID2 = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFlecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PbFlecha);
            this.panel1.Controls.Add(this.btnRegistroicon);
            this.panel1.Controls.Add(this.btnDatosusuarioicon);
            this.panel1.Controls.Add(this.btnConexionicon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 641);
            this.panel1.TabIndex = 0;
            // 
            // PbFlecha
            // 
            this.PbFlecha.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PbFlecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbFlecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbFlecha.Image = global::RFID.Properties.Resources.flechaNN_removebg_preview;
            this.PbFlecha.Location = new System.Drawing.Point(64, 296);
            this.PbFlecha.Name = "PbFlecha";
            this.PbFlecha.Size = new System.Drawing.Size(66, 49);
            this.PbFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFlecha.TabIndex = 4;
            this.PbFlecha.TabStop = false;
            // 
            // btnRegistroicon
            // 
            this.btnRegistroicon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRegistroicon.FlatAppearance.BorderSize = 0;
            this.btnRegistroicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroicon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroicon.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnRegistroicon.IconColor = System.Drawing.Color.Black;
            this.btnRegistroicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistroicon.Location = new System.Drawing.Point(126, 505);
            this.btnRegistroicon.Name = "btnRegistroicon";
            this.btnRegistroicon.Size = new System.Drawing.Size(237, 83);
            this.btnRegistroicon.TabIndex = 3;
            this.btnRegistroicon.Text = "Registro / \r\nEdicion";
            this.btnRegistroicon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroicon.UseVisualStyleBackColor = false;
            this.btnRegistroicon.Click += new System.EventHandler(this.btnRegistroicon_Click);
            // 
            // btnDatosusuarioicon
            // 
            this.btnDatosusuarioicon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDatosusuarioicon.FlatAppearance.BorderSize = 0;
            this.btnDatosusuarioicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosusuarioicon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosusuarioicon.IconChar = FontAwesome.Sharp.IconChar.SmileWink;
            this.btnDatosusuarioicon.IconColor = System.Drawing.Color.Black;
            this.btnDatosusuarioicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatosusuarioicon.Location = new System.Drawing.Point(126, 382);
            this.btnDatosusuarioicon.Name = "btnDatosusuarioicon";
            this.btnDatosusuarioicon.Size = new System.Drawing.Size(237, 82);
            this.btnDatosusuarioicon.TabIndex = 2;
            this.btnDatosusuarioicon.Text = "Datos de\r\n usuario";
            this.btnDatosusuarioicon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatosusuarioicon.UseVisualStyleBackColor = false;
            this.btnDatosusuarioicon.Click += new System.EventHandler(this.btnDatosusuarioicon_Click);
            // 
            // btnConexionicon
            // 
            this.btnConexionicon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConexionicon.FlatAppearance.BorderSize = 0;
            this.btnConexionicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexionicon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexionicon.IconChar = FontAwesome.Sharp.IconChar.Chromecast;
            this.btnConexionicon.IconColor = System.Drawing.Color.Black;
            this.btnConexionicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConexionicon.Location = new System.Drawing.Point(126, 296);
            this.btnConexionicon.Name = "btnConexionicon";
            this.btnConexionicon.Size = new System.Drawing.Size(237, 49);
            this.btnConexionicon.TabIndex = 1;
            this.btnConexionicon.Text = "Conexion";
            this.btnConexionicon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConexionicon.UseVisualStyleBackColor = false;
            this.btnConexionicon.Click += new System.EventHandler(this.btnConexionicon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID.Properties.Resources.HT;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lblBaudios);
            this.panel2.Controls.Add(this.cmbBaudios);
            this.panel2.Controls.Add(this.cmbPuerto);
            this.panel2.Controls.Add(this.btnConectar);
            this.panel2.Controls.Add(this.btnPuerto);
            this.panel2.Location = new System.Drawing.Point(405, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 546);
            this.panel2.TabIndex = 2;
            // 
            // lblBaudios
            // 
            this.lblBaudios.AutoSize = true;
            this.lblBaudios.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudios.Location = new System.Drawing.Point(526, 33);
            this.lblBaudios.Name = "lblBaudios";
            this.lblBaudios.Size = new System.Drawing.Size(75, 20);
            this.lblBaudios.TabIndex = 4;
            this.lblBaudios.Text = "Baudios:";
            // 
            // cmbBaudios
            // 
            this.cmbBaudios.FormattingEnabled = true;
            this.cmbBaudios.Location = new System.Drawing.Point(620, 29);
            this.cmbBaudios.Name = "cmbBaudios";
            this.cmbBaudios.Size = new System.Drawing.Size(146, 24);
            this.cmbBaudios.TabIndex = 3;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(189, 29);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(203, 24);
            this.cmbPuerto.TabIndex = 2;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.Control;
            this.btnConectar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(32, 89);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(734, 37);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnPuerto
            // 
            this.btnPuerto.BackColor = System.Drawing.SystemColors.Control;
            this.btnPuerto.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuerto.Location = new System.Drawing.Point(21, 21);
            this.btnPuerto.Name = "btnPuerto";
            this.btnPuerto.Size = new System.Drawing.Size(152, 39);
            this.btnPuerto.TabIndex = 0;
            this.btnPuerto.Text = "PUERTO";
            this.btnPuerto.UseVisualStyleBackColor = false;
            this.btnPuerto.Click += new System.EventHandler(this.btnPuerto_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(391, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.lblFecha);
            this.panel4.Controls.Add(this.lblHora);
            this.panel4.Controls.Add(this.pbStatus);
            this.panel4.Controls.Add(this.lblStatus);
            this.panel4.Location = new System.Drawing.Point(391, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 69);
            this.panel4.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(478, 6);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::RFID.Properties.Resources.Connected;
            this.pbStatus.Location = new System.Drawing.Point(335, 6);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(45, 43);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 1;
            this.pbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Estado de Conexion:";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Location = new System.Drawing.Point(391, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 546);
            this.panel5.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(349, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID e Imagen";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del empleado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(596, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 39);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.btnGuardar);
            this.panel6.Controls.Add(this.btnLimpiar2);
            this.panel6.Controls.Add(this.txtDireccion);
            this.panel6.Controls.Add(this.txtCiudad);
            this.panel6.Controls.Add(this.txtPais);
            this.panel6.Controls.Add(this.txtNombre);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(389, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(805, 548);
            this.panel6.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chbBuscarID);
            this.groupBox5.Controls.Add(this.chbBuscarNombre);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.txtBuscar);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(14, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 228);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver Record";
            // 
            // chbBuscarID
            // 
            this.chbBuscarID.AutoSize = true;
            this.chbBuscarID.Location = new System.Drawing.Point(624, 37);
            this.chbBuscarID.Name = "chbBuscarID";
            this.chbBuscarID.Size = new System.Drawing.Size(137, 24);
            this.chbBuscarID.TabIndex = 4;
            this.chbBuscarID.Text = "Buscar por ID";
            this.chbBuscarID.UseVisualStyleBackColor = true;
            // 
            // chbBuscarNombre
            // 
            this.chbBuscarNombre.AutoSize = true;
            this.chbBuscarNombre.Location = new System.Drawing.Point(429, 39);
            this.chbBuscarNombre.Name = "chbBuscarNombre";
            this.chbBuscarNombre.Size = new System.Drawing.Size(179, 24);
            this.chbBuscarNombre.TabIndex = 3;
            this.chbBuscarNombre.Text = "Buscar por Nombre";
            this.chbBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 132);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(109, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(285, 27);
            this.txtBuscar.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Buscar:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(634, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 192);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagen";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RFID.Properties.Resources.Click_to_browse__1_;
            this.pictureBox4.Location = new System.Drawing.Point(12, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 137);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblID2);
            this.groupBox3.Controls.Add(this.btnObtener);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(443, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 188);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obtener ID";
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Location = new System.Drawing.Point(19, 154);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(34, 20);
            this.lblID2.TabIndex = 13;
            this.lblID2.Text = "ID:";
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.SystemColors.Control;
            this.btnObtener.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Location = new System.Drawing.Point(6, 68);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(152, 39);
            this.btnObtener.TabIndex = 12;
            this.btnObtener.Text = "OBTENER";
            this.btnObtener.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(37, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 39);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.Location = new System.Drawing.Point(232, 237);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(152, 39);
            this.btnLimpiar2.TabIndex = 13;
            this.btnLimpiar2.Text = "LIMPIAR";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(136, 72);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(136, 131);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(215, 22);
            this.txtCiudad.TabIndex = 10;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(136, 184);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(215, 22);
            this.txtPais.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pais:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nombre:";
            // 
            // timerFecha
            // 
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(478, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFlecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnRegistroicon;
        private FontAwesome.Sharp.IconButton btnDatosusuarioicon;
        private FontAwesome.Sharp.IconButton btnConexionicon;
        private System.Windows.Forms.PictureBox PbFlecha;
        private System.Windows.Forms.Label lblBaudios;
        private System.Windows.Forms.ComboBox cmbBaudios;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnPuerto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHora;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbBuscarID;
        private System.Windows.Forms.CheckBox chbBuscarNombre;
        private System.Windows.Forms.Timer timerFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}

