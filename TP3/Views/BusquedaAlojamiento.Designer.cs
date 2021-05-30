
namespace Agencia.Views
{
    partial class BusquedaAlojamiento
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
            this.text_fechah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.seleccion_tipo = new System.Windows.Forms.ComboBox();
            this.text_ciudad = new System.Windows.Forms.TextBox();
            this.text_cantidad = new System.Windows.Forms.TextBox();
            this.text_fechad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_fechah
            // 
            this.text_fechah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_fechah.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fechah.ForeColor = System.Drawing.SystemColors.Window;
            this.text_fechah.Location = new System.Drawing.Point(324, 98);
            this.text_fechah.Name = "text_fechah";
            this.text_fechah.Size = new System.Drawing.Size(81, 31);
            this.text_fechah.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "REALIZA TU BUSQUEDA DE ALOJAMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ciudad";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(508, 168);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 33);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.Text = "Buscar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // seleccion_tipo
            // 
            this.seleccion_tipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seleccion_tipo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccion_tipo.ForeColor = System.Drawing.SystemColors.Window;
            this.seleccion_tipo.FormattingEnabled = true;
            this.seleccion_tipo.Items.AddRange(new object[] {
            "Hotel",
            "Cabañas"});
            this.seleccion_tipo.Location = new System.Drawing.Point(470, 98);
            this.seleccion_tipo.Name = "seleccion_tipo";
            this.seleccion_tipo.Size = new System.Drawing.Size(130, 31);
            this.seleccion_tipo.TabIndex = 52;
            // 
            // text_ciudad
            // 
            this.text_ciudad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_ciudad.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ciudad.ForeColor = System.Drawing.SystemColors.Window;
            this.text_ciudad.Location = new System.Drawing.Point(21, 98);
            this.text_ciudad.Name = "text_ciudad";
            this.text_ciudad.Size = new System.Drawing.Size(130, 31);
            this.text_ciudad.TabIndex = 49;
            // 
            // text_cantidad
            // 
            this.text_cantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_cantidad.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.text_cantidad.Location = new System.Drawing.Point(21, 168);
            this.text_cantidad.Name = "text_cantidad";
            this.text_cantidad.Size = new System.Drawing.Size(130, 31);
            this.text_cantidad.TabIndex = 51;
            // 
            // text_fechad
            // 
            this.text_fechad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_fechad.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fechad.ForeColor = System.Drawing.SystemColors.Window;
            this.text_fechad.Location = new System.Drawing.Point(193, 98);
            this.text_fechad.Name = "text_fechad";
            this.text_fechad.Size = new System.Drawing.Size(81, 31);
            this.text_fechad.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.text_fechah);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_fechad);
            this.panel1.Controls.Add(this.text_cantidad);
            this.panel1.Controls.Add(this.text_ciudad);
            this.panel1.Controls.Add(this.seleccion_tipo);
            this.panel1.Location = new System.Drawing.Point(28, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 411);
            this.panel1.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nº de personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(466, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "tipo de alojamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(320, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "desde";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 163);
            this.dataGridView1.TabIndex = 58;
            // 
            // BusquedaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Agencia.Properties.Resources.Fcliente;
            this.ClientSize = new System.Drawing.Size(680, 475);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusquedaAlojamiento";
            this.Text = "BusquedaAlojamiento";
            this.Load += new System.EventHandler(this.BusquedaAlojamiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_fechah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox seleccion_tipo;
        private System.Windows.Forms.TextBox text_ciudad;
        private System.Windows.Forms.TextBox text_cantidad;
        private System.Windows.Forms.TextBox text_fechad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}