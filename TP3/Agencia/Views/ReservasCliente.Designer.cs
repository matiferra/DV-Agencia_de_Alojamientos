
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaFecha = new System.Windows.Forms.DateTimePicker();
            this.desdeFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_alojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridViewReservas);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hastaFecha);
            this.panel1.Controls.Add(this.desdeFecha);
            this.panel1.Location = new System.Drawing.Point(28, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 463);
            this.panel1.TabIndex = 40;
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
            this.btnLogin.Location = new System.Drawing.Point(651, 64);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 33);
            this.btnLogin.TabIndex = 71;
            this.btnLogin.Text = "Buscar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(446, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Fecha Desde";
            // 
            // hastaFecha
            // 
            this.hastaFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastaFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaFecha.Location = new System.Drawing.Point(447, 66);
            this.hastaFecha.Name = "hastaFecha";
            this.hastaFecha.Size = new System.Drawing.Size(177, 31);
            this.hastaFecha.TabIndex = 68;
            // 
            // desdeFecha
            // 
            this.desdeFecha.CalendarFont = new System.Drawing.Font("Cambria", 11F);
            this.desdeFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.desdeFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeFecha.Location = new System.Drawing.Point(235, 64);
            this.desdeFecha.Name = "desdeFecha";
            this.desdeFecha.Size = new System.Drawing.Size(176, 31);
            this.desdeFecha.TabIndex = 67;
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
            this.dataGridViewReservas.Location = new System.Drawing.Point(192, 152);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersVisible = false;
            this.dataGridViewReservas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.Size = new System.Drawing.Size(554, 186);
            this.dataGridViewReservas.TabIndex = 106;
            this.dataGridViewReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.Width = 68;
            // 
            // FDesde
            // 
            this.FDesde.HeaderText = "Fecha Desde";
            this.FDesde.Name = "FDesde";
            this.FDesde.ReadOnly = true;
            this.FDesde.Width = 88;
            // 
            // FHasta
            // 
            this.FHasta.HeaderText = "Fecha Hasta";
            this.FHasta.Name = "FHasta";
            this.FHasta.ReadOnly = true;
            this.FHasta.Width = 86;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.Width = 65;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // id_alojamiento
            // 
            this.id_alojamiento.HeaderText = "ID - Alojamiento";
            this.id_alojamiento.Name = "id_alojamiento";
            this.id_alojamiento.Width = 97;
            // 
            // id_reserva
            // 
            this.id_reserva.HeaderText = "ID - Reserva";
            this.id_reserva.Name = "id_reserva";
            this.id_reserva.Width = 85;
            // 
            // ReservasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
    }
}