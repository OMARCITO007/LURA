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
            this.label4 = new System.Windows.Forms.Label();
            this.radio_rueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ppr = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pulsos_encoder = new System.Windows.Forms.TextBox();
            this.calibrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.distancia_real = new System.Windows.Forms.TextBox();
            this.calibración = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pulsos_medidos = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(961, 149);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "CALIBRACIÓN DE ENCODER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.guardar);
            this.panel2.Controls.Add(this.limpiar);
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
            this.panel2.Controls.Add(this.radio_rueda);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ppr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 414);
            this.panel2.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Radio de rueda:";
            // 
            // radio_rueda
            // 
            this.radio_rueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radio_rueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_rueda.Location = new System.Drawing.Point(566, 56);
            this.radio_rueda.Name = "radio_rueda";
            this.radio_rueda.Size = new System.Drawing.Size(111, 23);
            this.radio_rueda.TabIndex = 48;
            this.radio_rueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "PPR:";
            // 
            // ppr
            // 
            this.ppr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppr.Location = new System.Drawing.Point(259, 56);
            this.ppr.Name = "ppr";
            this.ppr.Size = new System.Drawing.Size(111, 23);
            this.ppr.TabIndex = 46;
            this.ppr.Text = "2000";
            this.ppr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Tomato;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(476, 100);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(100, 30);
            this.zero.TabIndex = 53;
            this.zero.Text = "Zero";
            this.zero.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pulsos encoder:";
            // 
            // pulsos_encoder
            // 
            this.pulsos_encoder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pulsos_encoder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsos_encoder.Location = new System.Drawing.Point(346, 105);
            this.pulsos_encoder.Name = "pulsos_encoder";
            this.pulsos_encoder.Size = new System.Drawing.Size(111, 23);
            this.pulsos_encoder.TabIndex = 51;
            this.pulsos_encoder.Text = "0000";
            this.pulsos_encoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calibrar
            // 
            this.calibrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.calibrar.FlatAppearance.BorderSize = 0;
            this.calibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calibrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrar.ForeColor = System.Drawing.Color.White;
            this.calibrar.Location = new System.Drawing.Point(478, 196);
            this.calibrar.Name = "calibrar";
            this.calibrar.Size = new System.Drawing.Size(100, 30);
            this.calibrar.TabIndex = 66;
            this.calibrar.Text = "Calibrar";
            this.calibrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Distancia real:";
            // 
            // distancia_real
            // 
            this.distancia_real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distancia_real.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancia_real.Location = new System.Drawing.Point(346, 227);
            this.distancia_real.Name = "distancia_real";
            this.distancia_real.Size = new System.Drawing.Size(111, 23);
            this.distancia_real.TabIndex = 64;
            this.distancia_real.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calibración
            // 
            this.calibración.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibración.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.calibración.Location = new System.Drawing.Point(597, 201);
            this.calibración.Name = "calibración";
            this.calibración.Size = new System.Drawing.Size(111, 23);
            this.calibración.TabIndex = 63;
            this.calibración.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "Pulsos medidos:";
            // 
            // pulsos_medidos
            // 
            this.pulsos_medidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pulsos_medidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsos_medidos.Location = new System.Drawing.Point(346, 178);
            this.pulsos_medidos.Name = "pulsos_medidos";
            this.pulsos_medidos.Size = new System.Drawing.Size(111, 23);
            this.pulsos_medidos.TabIndex = 61;
            this.pulsos_medidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(88)))));
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(489, 350);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(100, 30);
            this.guardar.TabIndex = 68;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Tomato;
            this.limpiar.FlatAppearance.BorderSize = 0;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.White;
            this.limpiar.Location = new System.Drawing.Point(270, 350);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 30);
            this.limpiar.TabIndex = 67;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(961, 781);
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
        private System.Windows.Forms.TextBox radio_rueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ppr;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button calibrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox distancia_real;
        private System.Windows.Forms.TextBox calibración;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pulsos_medidos;
    }
}
