
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaAlojamiento));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.seleccion_tipo = new System.Windows.Forms.ComboBox();
            this.text_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaFecha = new System.Windows.Forms.DateTimePicker();
            this.desdeFecha = new System.Windows.Forms.DateTimePicker();
            this.Phasta_campo = new System.Windows.Forms.TextBox();
            this.Pdesde_campo = new System.Windows.Forms.TextBox();
            this.comboBox_ciudad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(256, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "REALIZA TU BUSQUEDA DE ALOJAMIENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(367, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 14);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tipo de alojamiento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ingresa una ciudad";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(701, 201);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 32);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.Text = "Buscar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cantidad de personas";
            // 
            // seleccion_tipo
            // 
            this.seleccion_tipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seleccion_tipo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seleccion_tipo.ForeColor = System.Drawing.Color.White;
            this.seleccion_tipo.FormattingEnabled = true;
            this.seleccion_tipo.Items.AddRange(new object[] {
            "Hotel",
            "Cabañas"});
            this.seleccion_tipo.Location = new System.Drawing.Point(365, 84);
            this.seleccion_tipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.seleccion_tipo.Name = "seleccion_tipo";
            this.seleccion_tipo.Size = new System.Drawing.Size(192, 31);
            this.seleccion_tipo.TabIndex = 52;
            this.seleccion_tipo.SelectedIndexChanged += new System.EventHandler(this.seleccion_tipo_SelectedIndexChanged);
            // 
            // text_cantidad
            // 
            this.text_cantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_cantidad.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_cantidad.ForeColor = System.Drawing.Color.White;
            this.text_cantidad.Location = new System.Drawing.Point(120, 154);
            this.text_cantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_cantidad.Name = "text_cantidad";
            this.text_cantidad.Size = new System.Drawing.Size(177, 31);
            this.text_cantidad.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(728, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "Precio Hasta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(618, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Precio Desde";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hastaFecha);
            this.panel1.Controls.Add(this.desdeFecha);
            this.panel1.Controls.Add(this.Phasta_campo);
            this.panel1.Controls.Add(this.Pdesde_campo);
            this.panel1.Controls.Add(this.comboBox_ciudad);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_cantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.seleccion_tipo);
            this.panel1.Location = new System.Drawing.Point(33, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 452);
            this.panel1.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(622, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 65;
            this.label2.Text = "Fecha Desde";
            // 
            // hastaFecha
            // 
            this.hastaFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastaFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaFecha.Location = new System.Drawing.Point(622, 154);
            this.hastaFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hastaFecha.Name = "hastaFecha";
            this.hastaFecha.Size = new System.Drawing.Size(193, 31);
            this.hastaFecha.TabIndex = 64;
            // 
            // desdeFecha
            // 
            this.desdeFecha.CalendarFont = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.desdeFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeFecha.Location = new System.Drawing.Point(366, 154);
            this.desdeFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.desdeFecha.Name = "desdeFecha";
            this.desdeFecha.Size = new System.Drawing.Size(191, 31);
            this.desdeFecha.TabIndex = 63;
            // 
            // Phasta_campo
            // 
            this.Phasta_campo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phasta_campo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Phasta_campo.ForeColor = System.Drawing.Color.White;
            this.Phasta_campo.Location = new System.Drawing.Point(732, 84);
            this.Phasta_campo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Phasta_campo.Name = "Phasta_campo";
            this.Phasta_campo.Size = new System.Drawing.Size(83, 31);
            this.Phasta_campo.TabIndex = 62;
            // 
            // Pdesde_campo
            // 
            this.Pdesde_campo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pdesde_campo.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pdesde_campo.ForeColor = System.Drawing.Color.White;
            this.Pdesde_campo.Location = new System.Drawing.Point(622, 84);
            this.Pdesde_campo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pdesde_campo.Name = "Pdesde_campo";
            this.Pdesde_campo.Size = new System.Drawing.Size(88, 31);
            this.Pdesde_campo.TabIndex = 61;
            // 
            // comboBox_ciudad
            // 
            this.comboBox_ciudad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_ciudad.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_ciudad.FormattingEnabled = true;
            this.comboBox_ciudad.Location = new System.Drawing.Point(121, 84);
            this.comboBox_ciudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_ciudad.Name = "comboBox_ciudad";
            this.comboBox_ciudad.Size = new System.Drawing.Size(176, 31);
            this.comboBox_ciudad.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 39;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reservar,
            this.Barrio,
            this.estrellas,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(63, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(798, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reservar
            // 
            this.Reservar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Reservar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Reservar.HeaderText = "";
            this.Reservar.Name = "Reservar";
            this.Reservar.Text = "reservar";
            this.Reservar.UseColumnTextForButtonValue = true;
            this.Reservar.Width = 60;
            // 
            // Barrio
            // 
            this.Barrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 90;
            // 
            // estrellas
            // 
            this.estrellas.HeaderText = "Estrellas";
            this.estrellas.Name = "estrellas";
            this.estrellas.ReadOnly = true;
            this.estrellas.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "N° Personas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "TV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ciudad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "Habitaciones";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Precio/Dia";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.HeaderText = "Precio/Persona";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.HeaderText = "N° baños";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 90;
            // 
            // BusquedaAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BusquedaAlojamiento";
            this.Text = "BusquedaAlojamiento";
            this.Load += new System.EventHandler(this.BusquedaAlojamiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seleccion_tipo;
        private System.Windows.Forms.TextBox text_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_ciudad;
        private System.Windows.Forms.TextBox Phasta_campo;
        private System.Windows.Forms.TextBox Pdesde_campo;
        private System.Windows.Forms.DateTimePicker hastaFecha;
        private System.Windows.Forms.DateTimePicker desdeFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Reservar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}