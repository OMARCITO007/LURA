namespace LURA
{
    partial class Datos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fotosDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtro_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Exportar = new System.Windows.Forms.Button();
            this.ver_foto = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.fotosDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 507);
            this.panel2.TabIndex = 42;
            // 
            // fotosDataGridView
            // 
            this.fotosDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fotosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.fotosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.fotosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fotosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.fotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fotosDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.fotosDataGridView.GridColor = System.Drawing.SystemColors.Highlight;
            this.fotosDataGridView.Location = new System.Drawing.Point(46, 23);
            this.fotosDataGridView.Name = "fotosDataGridView";
            this.fotosDataGridView.Size = new System.Drawing.Size(918, 452);
            this.fotosDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.filtro_fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exportar);
            this.panel1.Controls.Add(this.ver_foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 140);
            this.panel1.TabIndex = 41;
            // 
            // filtro_fecha
            // 
            this.filtro_fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro_fecha.Location = new System.Drawing.Point(46, 92);
            this.filtro_fecha.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.filtro_fecha.Name = "filtro_fecha";
            this.filtro_fecha.Size = new System.Drawing.Size(276, 23);
            this.filtro_fecha.TabIndex = 51;
            this.filtro_fecha.ValueChanged += new System.EventHandler(this.filtro_fecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "LISTA DE IMÁGENES CAPTURADAS";
            // 
            // Exportar
            // 
            this.Exportar.BackColor = System.Drawing.Color.Transparent;
            this.Exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exportar.FlatAppearance.BorderSize = 0;
            this.Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exportar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar.ForeColor = System.Drawing.Color.Black;
            this.Exportar.Image = global::LURA.Properties.Resources.Vector__3_;
            this.Exportar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exportar.Location = new System.Drawing.Point(804, 74);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(160, 60);
            this.Exportar.TabIndex = 46;
            this.Exportar.Text = "Exportar reporte";
            this.Exportar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exportar.UseVisualStyleBackColor = false;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // ver_foto
            // 
            this.ver_foto.BackColor = System.Drawing.Color.Transparent;
            this.ver_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ver_foto.FlatAppearance.BorderSize = 0;
            this.ver_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver_foto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_foto.ForeColor = System.Drawing.Color.Black;
            this.ver_foto.Image = global::LURA.Properties.Resources.Vector__4_;
            this.ver_foto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ver_foto.Location = new System.Drawing.Point(669, 74);
            this.ver_foto.Name = "ver_foto";
            this.ver_foto.Size = new System.Drawing.Size(129, 60);
            this.ver_foto.TabIndex = 45;
            this.ver_foto.Text = "Ver imagen";
            this.ver_foto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ver_foto.UseVisualStyleBackColor = false;
            this.ver_foto.Click += new System.EventHandler(this.ver_foto_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Datos";
            this.Size = new System.Drawing.Size(1021, 647);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fotosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ver_foto;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.DataGridView fotosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker filtro_fecha;
    }
}
