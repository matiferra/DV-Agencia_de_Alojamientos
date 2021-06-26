
namespace Agencia.Views
{
    partial class AdmReservas 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmReservas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TODAS = new System.Windows.Forms.Button();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.combo_ciudadHeader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TODAS);
            this.panel1.Controls.Add(this.dataGridViewReservas);
            this.panel1.Controls.Add(this.combo_ciudadHeader);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 452);
            this.panel1.TabIndex = 40;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TODAS
            // 
            this.TODAS.BackColor = System.Drawing.Color.Transparent;
            this.TODAS.FlatAppearance.BorderSize = 2;
            this.TODAS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TODAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TODAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODAS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TODAS.ForeColor = System.Drawing.Color.Honeydew;
            this.TODAS.Location = new System.Drawing.Point(672, 394);
            this.TODAS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TODAS.Name = "TODAS";
            this.TODAS.Size = new System.Drawing.Size(159, 32);
            this.TODAS.TabIndex = 106;
            this.TODAS.Text = "Mostrar Todas";
            this.TODAS.UseVisualStyleBackColor = false;
            this.TODAS.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewReservas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewReservas.ColumnHeadersHeight = 39;
            this.dataGridViewReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.id_usuario,
            this.FDesde,
            this.FHasta,
            this.Precio,
            this.id_reserva});
            this.dataGridViewReservas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewReservas.Location = new System.Drawing.Point(128, 164);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.RowHeadersVisible = false;
            this.dataGridViewReservas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservas.Size = new System.Drawing.Size(703, 215);
            this.dataGridViewReservas.TabIndex = 105;
            this.dataGridViewReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellClick);
            // 
            // combo_ciudadHeader
            // 
            this.combo_ciudadHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combo_ciudadHeader.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_ciudadHeader.ForeColor = System.Drawing.Color.White;
            this.combo_ciudadHeader.FormattingEnabled = true;
            this.combo_ciudadHeader.Location = new System.Drawing.Point(128, 119);
            this.combo_ciudadHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combo_ciudadHeader.Name = "combo_ciudadHeader";
            this.combo_ciudadHeader.Size = new System.Drawing.Size(223, 25);
            this.combo_ciudadHeader.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ingrese Ciudad";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogin.Location = new System.Drawing.Point(377, 112);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 32);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "Buscar";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "BUSCAR RESERVAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.ToolTipText = "Eliminar";
            // 
            // id_usuario
            // 
            this.id_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_usuario.HeaderText = "Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
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
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // id_reserva
            // 
            this.id_reserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_reserva.HeaderText = "ID - Reserva";
            this.id_reserva.Name = "id_reserva";
            // 
            // AdmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdmReservas";
            this.Text = "AdmReservas";
            this.Load += new System.EventHandler(this.AdmReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combo_ciudadHeader;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Button TODAS;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reserva;
    }
}