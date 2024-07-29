namespace LURA
{
    partial class Configuracion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DistanciaCorregida = new System.Windows.Forms.TextBox();
            this.save_conf = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.factor_escala = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calibrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.distancia_real = new System.Windows.Forms.TextBox();
            this.calibración = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pulsos_medidos = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pulsos_encoder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diametro_rueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ppr_enc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 149);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "CALIBRACIÓN DE ENCODER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DistanciaCorregida);
            this.panel2.Controls.Add(this.save_conf);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.factor_escala);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.calibrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.distancia_real);
            this.panel2.Controls.Add(this.calibración);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pulsos_medidos);
            this.panel2.Controls.Add(this.zero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pulsos_encoder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.diametro_rueda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ppr_enc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 414);
            this.panel2.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 18);
            this.label9.TabIndex = 75;
            this.label9.Text = "Distancia recorrida:";
            // 
            // DistanciaCorregida
            // 
            this.DistanciaCorregida.BackColor = System.Drawing.Color.Silver;
            this.DistanciaCorregida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DistanciaCorregida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanciaCorregida.Location = new System.Drawing.Point(709, 105);
            this.DistanciaCorregida.Name = "DistanciaCorregida";
            this.DistanciaCorregida.Size = new System.Drawing.Size(111, 23);
            this.DistanciaCorregida.TabIndex = 74;
            this.DistanciaCorregida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_conf
            // 
            this.save_conf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.save_conf.FlatAppearance.BorderSize = 0;
            this.save_conf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_conf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_conf.ForeColor = System.Drawing.Color.White;
            this.save_conf.Location = new System.Drawing.Point(270, 215);
            this.save_conf.Name = "save_conf";
            this.save_conf.Size = new System.Drawing.Size(111, 30);
            this.save_conf.TabIndex = 73;
            this.save_conf.Text = "Guardar";
            this.save_conf.UseVisualStyleBackColor = false;
            this.save_conf.Click += new System.EventHandler(this.save_conf_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 72;
            this.label8.Text = "Factor escala:";
            // 
            // factor_escala
            // 
            this.factor_escala.BackColor = System.Drawing.Color.PaleGreen;
            this.factor_escala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.factor_escala.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.factor_escala.Location = new System.Drawing.Point(270, 168);
            this.factor_escala.Name = "factor_escala";
            this.factor_escala.Size = new System.Drawing.Size(111, 23);
            this.factor_escala.TabIndex = 71;
            this.factor_escala.Text = "1";
            this.factor_escala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 70;
            this.label6.Text = "Factor escala:";
            // 
            // calibrar
            // 
            this.calibrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.calibrar.FlatAppearance.BorderSize = 0;
            this.calibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calibrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrar.ForeColor = System.Drawing.Color.White;
            this.calibrar.Location = new System.Drawing.Point(709, 245);
            this.calibrar.Name = "calibrar";
            this.calibrar.Size = new System.Drawing.Size(111, 30);
            this.calibrar.TabIndex = 66;
            this.calibrar.Text = "Calibrar";
            this.calibrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Distancia real:";
            // 
            // distancia_real
            // 
            this.distancia_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distancia_real.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancia_real.Location = new System.Drawing.Point(709, 199);
            this.distancia_real.Name = "distancia_real";
            this.distancia_real.Size = new System.Drawing.Size(111, 23);
            this.distancia_real.TabIndex = 64;
            this.distancia_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calibración
            // 
            this.calibración.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibración.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.calibración.Location = new System.Drawing.Point(709, 294);
            this.calibración.Name = "calibración";
            this.calibración.Size = new System.Drawing.Size(111, 23);
            this.calibración.TabIndex = 63;
            this.calibración.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Pulsos medidos:";
            // 
            // pulsos_medidos
            // 
            this.pulsos_medidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pulsos_medidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsos_medidos.Location = new System.Drawing.Point(709, 150);
            this.pulsos_medidos.Name = "pulsos_medidos";
            this.pulsos_medidos.Size = new System.Drawing.Size(111, 23);
            this.pulsos_medidos.TabIndex = 61;
            this.pulsos_medidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Tomato;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(839, 54);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(111, 30);
            this.zero.TabIndex = 53;
            this.zero.Text = "Zero";
            this.zero.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pulsos encoder:";
            // 
            // pulsos_encoder
            // 
            this.pulsos_encoder.BackColor = System.Drawing.Color.Silver;
            this.pulsos_encoder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pulsos_encoder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsos_encoder.Location = new System.Drawing.Point(709, 59);
            this.pulsos_encoder.Name = "pulsos_encoder";
            this.pulsos_encoder.Size = new System.Drawing.Size(111, 23);
            this.pulsos_encoder.TabIndex = 51;
            this.pulsos_encoder.Text = "0000";
            this.pulsos_encoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Diametro de rueda cm:";
            // 
            // diametro_rueda
            // 
            this.diametro_rueda.BackColor = System.Drawing.Color.PaleGreen;
            this.diametro_rueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diametro_rueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diametro_rueda.Location = new System.Drawing.Point(270, 119);
            this.diametro_rueda.Name = "diametro_rueda";
            this.diametro_rueda.Size = new System.Drawing.Size(111, 23);
            this.diametro_rueda.TabIndex = 48;
            this.diametro_rueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "PPR:";
            // 
            // ppr_enc
            // 
            this.ppr_enc.BackColor = System.Drawing.Color.PaleGreen;
            this.ppr_enc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppr_enc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppr_enc.Location = new System.Drawing.Point(270, 69);
            this.ppr_enc.Name = "ppr_enc";
            this.ppr_enc.Size = new System.Drawing.Size(111, 23);
            this.ppr_enc.TabIndex = 46;
            this.ppr_enc.Text = "2000";
            this.ppr_enc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(1139, 781);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pulsos_encoder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diametro_rueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ppr_enc;
        private System.Windows.Forms.Button calibrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox distancia_real;
        private System.Windows.Forms.TextBox calibración;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pulsos_medidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_conf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox factor_escala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DistanciaCorregida;
    }
}
