
namespace Agencia
{
    partial class ReservasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservasCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaFecha = new System.Windows.Forms.DateTimePicker();
            this.desdeFecha = new System.Windows.Forms.DateTimePicker();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_alojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewReservas);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hastaFecha);
            this.panel1.Controls.Add(this.desdeFecha);
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 452);
            this.panel1.TabIndex = 40;
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewReservas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewReservas.ColumnHeadersHeight = 39;
            this.dataGridViewReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.FDesde,
            this.FHasta,
            this.ciudad,
            this.Precio,
            this.id_alojamiento,
            this.id_reserva});
            this.dataGridViewReservas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewReservas.Location = new System.Drawing.Point(121, 190);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersVisible = false;
            this.dataGridViewReservas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.Size = new System.Drawing.Size(698, 215);
            this.dataGridViewReservas.TabIndex = 106;
            this.dataGridViewReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(635, 115);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 31);
            this.btnLogin.TabIndex = 71;
            this.btnLogin.Text = "Buscar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Fecha Desde";
            // 
            // hastaFecha
            // 
            this.hastaFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastaFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaFecha.Location = new System.Drawing.Point(398, 115);
            this.hastaFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hastaFecha.Name = "hastaFecha";
            this.hastaFecha.Size = new System.Drawing.Size(206, 31);
            this.hastaFecha.TabIndex = 68;
            // 
            // desdeFecha
            // 
            this.desdeFecha.CalendarFont = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.desdeFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeFecha.Location = new System.Drawing.Point(150, 113);
            this.desdeFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.desdeFecha.Name = "desdeFecha";
            this.desdeFecha.Size = new System.Drawing.Size(205, 31);
            this.desdeFecha.TabIndex = 67;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.Width = 75;
            // 
            // FDesde
            // 
            this.FDesde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FDesde.HeaderText = "Fecha Desde";
            this.FDesde.Name = "FDesde";
            this.FDesde.ReadOnly = true;
            // 
            // FHasta
            // 
            this.FHasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FHasta.HeaderText = "Fecha Hasta";
            this.FHasta.Name = "FHasta";
            this.FHasta.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // id_alojamiento
            // 
            this.id_alojamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_alojamiento.HeaderText = "ID - Alojamiento";
            this.id_alojamiento.Name = "id_alojamiento";
            this.id_alojamiento.Width = 120;
            // 
            // id_reserva
            // 
            this.id_reserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_reserva.HeaderText = "ID - Reserva";
            this.id_reserva.Name = "id_reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 107;
            this.label1.Text = "REALIZA TU RESERVA";
            // 
            // ReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReservasCliente";
            this.Text = "ReservasCliente";
            this.Load += new System.EventHandler(this.ReservasCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hastaFecha;
        private System.Windows.Forms.DateTimePicker desdeFecha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
    }
}