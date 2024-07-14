namespace LURA
{
    partial class Inicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.list_gps = new System.Windows.Forms.ComboBox();
            this.btn_conectar_gps = new System.Windows.Forms.Button();
            this.list_usb_encoder = new System.Windows.Forms.ComboBox();
            this.btn_conectar_enc = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            this.list_gp = new System.Windows.Forms.ComboBox();
            this.btn_conectar_gp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gp_camera = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gp_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.list_gps);
            this.panel4.Controls.Add(this.btn_conectar_gps);
            this.panel4.Controls.Add(this.list_usb_encoder);
            this.panel4.Controls.Add(this.btn_conectar_enc);
            this.panel4.Controls.Add(this.btn_capture);
            this.panel4.Controls.Add(this.list_gp);
            this.panel4.Controls.Add(this.btn_conectar_gp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 653);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(981, 94);
            this.panel4.TabIndex = 38;
            // 
            // list_gps
            // 
            this.list_gps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_gps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_gps.FormattingEnabled = true;
            this.list_gps.Location = new System.Drawing.Point(656, 51);
            this.list_gps.Name = "list_gps";
            this.list_gps.Size = new System.Drawing.Size(120, 21);
            this.list_gps.TabIndex = 12;
            this.list_gps.Text = "USB GPS";
            // 
            // btn_conectar_gps
            // 
            this.btn_conectar_gps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_gps.FlatAppearance.BorderSize = 0;
            this.btn_conectar_gps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_gps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_gps.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_gps.Location = new System.Drawing.Point(788, 46);
            this.btn_conectar_gps.Name = "btn_conectar_gps";
            this.btn_conectar_gps.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_gps.TabIndex = 11;
            this.btn_conectar_gps.Text = "Conectar";
            this.btn_conectar_gps.UseVisualStyleBackColor = false;
            this.btn_conectar_gps.Click += new System.EventHandler(this.btn_conectar_gps_Click);
            // 
            // list_usb_encoder
            // 
            this.list_usb_encoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_usb_encoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_usb_encoder.FormattingEnabled = true;
            this.list_usb_encoder.Location = new System.Drawing.Point(95, 51);
            this.list_usb_encoder.Name = "list_usb_encoder";
            this.list_usb_encoder.Size = new System.Drawing.Size(120, 21);
            this.list_usb_encoder.TabIndex = 10;
            this.list_usb_encoder.Text = "USB encoder";
            // 
            // btn_conectar_enc
            // 
            this.btn_conectar_enc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_enc.FlatAppearance.BorderSize = 0;
            this.btn_conectar_enc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_enc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_enc.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_enc.Location = new System.Drawing.Point(228, 46);
            this.btn_conectar_enc.Name = "btn_conectar_enc";
            this.btn_conectar_enc.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_enc.TabIndex = 9;
            this.btn_conectar_enc.Text = "Conectar";
            this.btn_conectar_enc.UseVisualStyleBackColor = false;
            this.btn_conectar_enc.Click += new System.EventHandler(this.btn_conectar_enc_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.BackColor = System.Drawing.Color.Salmon;
            this.btn_capture.FlatAppearance.BorderSize = 0;
            this.btn_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capture.Location = new System.Drawing.Point(513, 17);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(128, 23);
            this.btn_capture.TabIndex = 8;
            this.btn_capture.Text = "Foto";
            this.btn_capture.UseVisualStyleBackColor = false;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // list_gp
            // 
            this.list_gp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_gp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.list_gp.FormattingEnabled = true;
            this.list_gp.Location = new System.Drawing.Point(370, 51);
            this.list_gp.Name = "list_gp";
            this.list_gp.Size = new System.Drawing.Size(127, 23);
            this.list_gp.TabIndex = 3;
            // 
            // btn_conectar_gp
            // 
            this.btn_conectar_gp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.btn_conectar_gp.FlatAppearance.BorderSize = 0;
            this.btn_conectar_gp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar_gp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar_gp.ForeColor = System.Drawing.Color.White;
            this.btn_conectar_gp.Location = new System.Drawing.Point(513, 46);
            this.btn_conectar_gp.Name = "btn_conectar_gp";
            this.btn_conectar_gp.Size = new System.Drawing.Size(128, 30);
            this.btn_conectar_gp.TabIndex = 1;
            this.btn_conectar_gp.Text = "Conectar";
            this.btn_conectar_gp.UseVisualStyleBackColor = false;
            this.btn_conectar_gp.Click += new System.EventHandler(this.btn_conectar_gp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.iniciar_medida);
            this.panel1.Controls.Add(this.zero_pulsos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pulsos_encoder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.longitud_gps);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.latitud_gps);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.distancia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 140);
            this.panel1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(606, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Distancia recorrida en metros";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(567, 62);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 60);
            this.textBox5.TabIndex = 47;
            this.textBox5.Text = "000000";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.distancia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.distancia.Location = new System.Drawing.Point(293, 22);
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(111, 23);
            this.distancia.TabIndex = 37;
            this.distancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.gp_camera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 513);
            this.panel2.TabIndex = 40;
            // 
            // gp_camera
            // 
            this.gp_camera.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gp_camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gp_camera.ErrorImage = global::LURA.Properties.Resources.Group_245;
            this.gp_camera.InitialImage = global::LURA.Properties.Resources.Group_245;
            this.gp_camera.Location = new System.Drawing.Point(160, 16);
            this.gp_camera.Name = "gp_camera";
            this.gp_camera.Size = new System.Drawing.Size(720, 480);
            this.gp_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gp_camera.TabIndex = 38;
            this.gp_camera.TabStop = false;
            this.gp_camera.WaitOnLoad = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(981, 747);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gp_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox list_gps;
        private System.Windows.Forms.Button btn_conectar_gps;
        private System.Windows.Forms.ComboBox list_usb_encoder;
        private System.Windows.Forms.Button btn_conectar_enc;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.ComboBox list_gp;
        private System.Windows.Forms.Button btn_conectar_gp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox gp_camera;
    }
}
