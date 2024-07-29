namespace LURA
{
    partial class PANEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PANEL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_capture = new System.Windows.Forms.Button();
            this.list_gps = new System.Windows.Forms.ComboBox();
            this.btn_conectar_gps = new System.Windows.Forms.Button();
            this.list_gp = new System.Windows.Forms.ComboBox();
            this.btn_conectar_gp = new System.Windows.Forms.Button();
            this.list_usb_encoder = new System.Windows.Forms.ComboBox();
            this.btn_conectar_enc = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.pantallas = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gp_camera = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.altura_gps = new System.Windows.Forms.TextBox();
            this.iniciar_medida = new System.Windows.Forms.Button();
            this.zero_pulsos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pulsos_encoder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.longitud_gps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.latitud_gps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distancia = new System.Windows.Forms.TextBox();
            this.lblDistanciaCorregida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pantallas.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp_camera)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_capture);
            this.panel1.Controls.Add(this.list_gps);
            this.panel1.Controls.Add(this.btn_conectar_gps);
            this.panel1.Controls.Add(this.list_gp);
            this.panel1.Controls.Add(this.btn_conectar_gp);
            this.panel1.Controls.Add(this.list_usb_encoder);
            this.panel1.Controls.Add(this.btn_conectar_enc);
            this.panel1.Controls.Add(this.btn_configuracion);
            this.panel1.Controls.Add(this.btn_datos);
            this.panel1.Controls.Add(this.btn_inicio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 801);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "GPS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(9, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "ENC:";
            // 
            // btn_capture
            // 
            this.btn_capture.BackColor = System.Drawing.Color.Salmon;
            this.btn_capture.FlatAppearance.BorderSize = 0;
            this.btn_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capture.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_capture.Location = new System.Drawing.Point(57, 740);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(128, 30);
            this.btn_capture.TabIndex = 17;
            this.btn_capture.Text = "Foto";
            this.btn_capture.UseVisualStyleBackColor = false;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // list_gps
            // 
            this.list_gps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_gps.FormattingEnabled = true;
            this.list_gps.Location = new System.Drawing.Point(61, 548);
            this.list_gps.Name = "list_gps";
            this.list_gps.Size = new System.Drawing.Size(120, 21);
            this.list_gps.TabIndex = 16;
            this.list_gps.Text = "USB GPS";
            // 
            // btn_conectar_gps
            // 
            this.btn_conectar_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_gps.FlatAppearance.BorderSize = 0;
            this.btn_conectar_gps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_gps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_gps.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_gps.Location = new System.Drawing.Point(57, 591);
            this.btn_conectar_gps.Name = "btn_conectar_gps";
            this.btn_conectar_gps.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_gps.TabIndex = 15;
            this.btn_conectar_gps.Text = "Conectar";
            this.btn_conectar_gps.UseVisualStyleBackColor = false;
            this.btn_conectar_gps.Click += new System.EventHandler(this.btn_conectar_gps_Click);
            // 
            // list_gp
            // 
            this.list_gp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_gp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.list_gp.FormattingEnabled = true;
            this.list_gp.Location = new System.Drawing.Point(58, 643);
            this.list_gp.Name = "list_gp";
            this.list_gp.Size = new System.Drawing.Size(127, 23);
            this.list_gp.TabIndex = 14;
            this.list_gp.Text = "USB GoPro";
            // 
            // btn_conectar_gp
            // 
            this.btn_conectar_gp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_gp.FlatAppearance.BorderSize = 0;
            this.btn_conectar_gp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_gp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_gp.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_gp.Location = new System.Drawing.Point(57, 688);
            this.btn_conectar_gp.Name = "btn_conectar_gp";
            this.btn_conectar_gp.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_gp.TabIndex = 13;
            this.btn_conectar_gp.Text = "Conectar";
            this.btn_conectar_gp.UseVisualStyleBackColor = false;
            this.btn_conectar_gp.Click += new System.EventHandler(this.btn_conectar_gp_Click);
            // 
            // list_usb_encoder
            // 
            this.list_usb_encoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_usb_encoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_usb_encoder.FormattingEnabled = true;
            this.list_usb_encoder.Location = new System.Drawing.Point(61, 453);
            this.list_usb_encoder.Name = "list_usb_encoder";
            this.list_usb_encoder.Size = new System.Drawing.Size(120, 21);
            this.list_usb_encoder.TabIndex = 12;
            this.list_usb_encoder.Text = "USB encoder";
            // 
            // btn_conectar_enc
            // 
            this.btn_conectar_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_enc.FlatAppearance.BorderSize = 0;
            this.btn_conectar_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_enc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_enc.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_enc.Location = new System.Drawing.Point(57, 496);
            this.btn_conectar_enc.Name = "btn_conectar_enc";
            this.btn_conectar_enc.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_enc.TabIndex = 11;
            this.btn_conectar_enc.Text = "Conectar";
            this.btn_conectar_enc.UseVisualStyleBackColor = false;
            this.btn_conectar_enc.Click += new System.EventHandler(this.btn_conectar_enc_Click);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btn_configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracion.ForeColor = System.Drawing.Color.Transparent;
            this.btn_configuracion.Image = global::LURA.Properties.Resources.view_dashboard_outline;
            this.btn_configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configuracion.Location = new System.Drawing.Point(12, 329);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(200, 45);
            this.btn_configuracion.TabIndex = 9;
            this.btn_configuracion.Text = "Configuración";
            this.btn_configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_configuracion.UseVisualStyleBackColor = false;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_datos
            // 
            this.btn_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btn_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_datos.FlatAppearance.BorderSize = 0;
            this.btn_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_datos.Image = global::LURA.Properties.Resources.view_dashboard_outline__2_;
            this.btn_datos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos.Location = new System.Drawing.Point(12, 267);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(200, 45);
            this.btn_datos.TabIndex = 8;
            this.btn_datos.Text = "Datos";
            this.btn_datos.UseVisualStyleBackColor = false;
            this.btn_datos.Click += new System.EventHandler(this.btn_datos_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(112)))), ((int)(((byte)(183)))));
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.Transparent;
            this.btn_inicio.Image = global::LURA.Properties.Resources.view_dashboard_outline__1_;
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(12, 201);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(199, 45);
            this.btn_inicio.TabIndex = 7;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 155);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(41, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nightControlBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 41);
            this.panel3.TabIndex = 5;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.Red;
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.Black;
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.Black;
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.Black;
            this.nightControlBox1.Location = new System.Drawing.Point(897, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 10;
            // 
            // pantallas
            // 
            this.pantallas.Controls.Add(this.panel5);
            this.pantallas.Controls.Add(this.panel4);
            this.pantallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pantallas.Location = new System.Drawing.Point(227, 41);
            this.pantallas.Name = "pantallas";
            this.pantallas.Size = new System.Drawing.Size(1036, 760);
            this.pantallas.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.gp_camera);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1036, 620);
            this.panel5.TabIndex = 41;
            // 
            // gp_camera
            // 
            this.gp_camera.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gp_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gp_camera.ErrorImage = global::LURA.Properties.Resources.Group_245;
            this.gp_camera.InitialImage = global::LURA.Properties.Resources.Group_245;
            this.gp_camera.Location = new System.Drawing.Point(92, 20);
            this.gp_camera.Name = "gp_camera";
            this.gp_camera.Size = new System.Drawing.Size(853, 588);
            this.gp_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gp_camera.TabIndex = 38;
            this.gp_camera.TabStop = false;
            this.gp_camera.WaitOnLoad = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblDistanciaCorregida);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.altura_gps);
            this.panel4.Controls.Add(this.iniciar_medida);
            this.panel4.Controls.Add(this.zero_pulsos);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pulsos_encoder);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.longitud_gps);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.latitud_gps);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.distancia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 140);
            this.panel4.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(824, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Altura:";
            // 
            // altura_gps
            // 
            this.altura_gps.BackColor = System.Drawing.Color.Silver;
            this.altura_gps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.altura_gps.Location = new System.Drawing.Point(890, 22);
            this.altura_gps.Name = "altura_gps";
            this.altura_gps.Size = new System.Drawing.Size(111, 23);
            this.altura_gps.TabIndex = 49;
            this.altura_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iniciar_medida
            // 
            this.iniciar_medida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.iniciar_medida.FlatAppearance.BorderSize = 0;
            this.iniciar_medida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar_medida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_medida.ForeColor = System.Drawing.Color.White;
            this.iniciar_medida.Location = new System.Drawing.Point(427, 63);
            this.iniciar_medida.Name = "iniciar_medida";
            this.iniciar_medida.Size = new System.Drawing.Size(134, 58);
            this.iniciar_medida.TabIndex = 46;
            this.iniciar_medida.Text = "INICIAR";
            this.iniciar_medida.UseVisualStyleBackColor = false;
            this.iniciar_medida.Click += new System.EventHandler(this.iniciar_medida_Click);
            // 
            // zero_pulsos
            // 
            this.zero_pulsos.BackColor = System.Drawing.Color.Tomato;
            this.zero_pulsos.FlatAppearance.BorderSize = 0;
            this.zero_pulsos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero_pulsos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_pulsos.ForeColor = System.Drawing.Color.White;
            this.zero_pulsos.Location = new System.Drawing.Point(697, 17);
            this.zero_pulsos.Name = "zero_pulsos";
            this.zero_pulsos.Size = new System.Drawing.Size(100, 30);
            this.zero_pulsos.TabIndex = 45;
            this.zero_pulsos.Text = "Zero";
            this.zero_pulsos.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Pulsos encoder:";
            // 
            // pulsos_encoder
            // 
            this.pulsos_encoder.BackColor = System.Drawing.Color.Silver;
            this.pulsos_encoder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.pulsos_encoder.Location = new System.Drawing.Point(567, 22);
            this.pulsos_encoder.Name = "pulsos_encoder";
            this.pulsos_encoder.Size = new System.Drawing.Size(111, 23);
            this.pulsos_encoder.TabIndex = 43;
            this.pulsos_encoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Longitud:";
            // 
            // longitud_gps
            // 
            this.longitud_gps.BackColor = System.Drawing.Color.Silver;
            this.longitud_gps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.longitud_gps.Location = new System.Drawing.Point(293, 102);
            this.longitud_gps.Name = "longitud_gps";
            this.longitud_gps.Size = new System.Drawing.Size(111, 23);
            this.longitud_gps.TabIndex = 41;
            this.longitud_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Latitud:";
            // 
            // latitud_gps
            // 
            this.latitud_gps.BackColor = System.Drawing.Color.Silver;
            this.latitud_gps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.latitud_gps.Location = new System.Drawing.Point(293, 62);
            this.latitud_gps.Name = "latitud_gps";
            this.latitud_gps.Size = new System.Drawing.Size(111, 23);
            this.latitud_gps.TabIndex = 39;
            this.latitud_gps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Distancia:";
            // 
            // distancia
            // 
            this.distancia.BackColor = System.Drawing.Color.Silver;
            this.distancia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.distancia.Location = new System.Drawing.Point(293, 22);
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(111, 23);
            this.distancia.TabIndex = 37;
            this.distancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDistanciaCorregida
            // 
            this.lblDistanciaCorregida.BackColor = System.Drawing.Color.Silver;
            this.lblDistanciaCorregida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistanciaCorregida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F);
            this.lblDistanciaCorregida.Location = new System.Drawing.Point(567, 64);
            this.lblDistanciaCorregida.Name = "lblDistanciaCorregida";
            this.lblDistanciaCorregida.Size = new System.Drawing.Size(230, 57);
            this.lblDistanciaCorregida.TabIndex = 75;
            this.lblDistanciaCorregida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(607, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 76;
            this.label5.Text = "Distancia recorrida en metros";
            // 
            // PANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 801);
            this.Controls.Add(this.pantallas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PANEL";
            this.Text = "LURA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pantallas.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp_camera)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pantallas;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_inicio;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.ComboBox list_usb_encoder;
        private System.Windows.Forms.Button btn_conectar_enc;
        public System.Windows.Forms.ComboBox list_gp;
        private System.Windows.Forms.Button btn_conectar_gp;
        private System.Windows.Forms.ComboBox list_gps;
        private System.Windows.Forms.Button btn_conectar_gps;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button iniciar_medida;
        private System.Windows.Forms.Button zero_pulsos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pulsos_encoder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox longitud_gps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox latitud_gps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distancia;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox gp_camera;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox altura_gps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblDistanciaCorregida;
    }
}

