
namespace Agencia.Views
{
    partial class AdmAlojamientos 
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
            this.tvNo = new System.Windows.Forms.RadioButton();
            this.tvSi = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ciudadText = new System.Windows.Forms.TextBox();
            this.alojamientosGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrellas_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.barrioText = new System.Windows.Forms.TextBox();
            this.estrellasText = new System.Windows.Forms.TextBox();
            this.tipoAlojamientoCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baniosText = new System.Windows.Forms.TextBox();
            this.habitacionesText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.personasText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alojamientosGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvNo
            // 
            this.tvNo.AutoSize = true;
            this.tvNo.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tvNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tvNo.Location = new System.Drawing.Point(460, 88);
            this.tvNo.Margin = new System.Windows.Forms.Padding(0);
            this.tvNo.Name = "tvNo";
            this.tvNo.Size = new System.Drawing.Size(40, 17);
            this.tvNo.TabIndex = 53;
            this.tvNo.TabStop = true;
            this.tvNo.Text = "No";
            this.tvNo.UseVisualStyleBackColor = true;
            // 
            // tvSi
            // 
            this.tvSi.AutoSize = true;
            this.tvSi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.tvSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tvSi.Location = new System.Drawing.Point(415, 88);
            this.tvSi.Margin = new System.Windows.Forms.Padding(0);
            this.tvSi.Name = "tvSi";
            this.tvSi.Size = new System.Drawing.Size(36, 17);
            this.tvSi.TabIndex = 52;
            this.tvSi.TabStop = true;
            this.tvSi.Text = "Si";
            this.tvSi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(293, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Servicio de Tv?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ciudadText
            // 
            this.ciudadText.BackColor = System.Drawing.SystemColors.ControlText;
            this.ciudadText.Font = new System.Drawing.Font("Cambria", 11F);
            this.ciudadText.ForeColor = System.Drawing.SystemColors.Menu;
            this.ciudadText.Location = new System.Drawing.Point(17, 48);
            this.ciudadText.Name = "ciudadText";
            this.ciudadText.Size = new System.Drawing.Size(137, 25);
            this.ciudadText.TabIndex = 56;
            this.ciudadText.Text = "Ciudad";
            this.ciudadText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // alojamientosGrid
            // 
            this.alojamientosGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.alojamientosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alojamientosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo_text,
            this.Barrio_text,
            this.NroHabitacion,
            this.Ciudad_text,
            this.Estrellas_text,
            this.Editar,
            this.Eliminar});
            this.alojamientosGrid.Location = new System.Drawing.Point(17, 210);
            this.alojamientosGrid.Name = "alojamientosGrid";
            this.alojamientosGrid.Size = new System.Drawing.Size(587, 160);
            this.alojamientosGrid.TabIndex = 59;
            this.alojamientosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Tipo_text
            // 
            this.Tipo_text.HeaderText = "Tipo";
            this.Tipo_text.Name = "Tipo_text";
            this.Tipo_text.Width = 50;
            // 
            // Barrio_text
            // 
            this.Barrio_text.HeaderText = "Barrio";
            this.Barrio_text.Name = "Barrio_text";
            this.Barrio_text.Width = 50;
            // 
            // NroHabitacion
            // 
            this.NroHabitacion.HeaderText = "Nro Habitacion";
            this.NroHabitacion.Name = "NroHabitacion";
            this.NroHabitacion.Width = 50;
            // 
            // Ciudad_text
            // 
            this.Ciudad_text.HeaderText = "Ciudad";
            this.Ciudad_text.Name = "Ciudad_text";
            this.Ciudad_text.Width = 50;
            // 
            // Estrellas_text
            // 
            this.Estrellas_text.HeaderText = "Estrella";
            this.Estrellas_text.Name = "Estrellas_text";
            this.Estrellas_text.Width = 50;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // barrioText
            // 
            this.barrioText.BackColor = System.Drawing.SystemColors.ControlText;
            this.barrioText.Font = new System.Drawing.Font("Cambria", 11F);
            this.barrioText.ForeColor = System.Drawing.SystemColors.Menu;
            this.barrioText.Location = new System.Drawing.Point(279, 48);
            this.barrioText.Name = "barrioText";
            this.barrioText.Size = new System.Drawing.Size(137, 25);
            this.barrioText.TabIndex = 61;
            this.barrioText.Text = "Barrio";
            // 
            // estrellasText
            // 
            this.estrellasText.BackColor = System.Drawing.SystemColors.ControlText;
            this.estrellasText.Font = new System.Drawing.Font("Cambria", 11F);
            this.estrellasText.ForeColor = System.Drawing.SystemColors.Menu;
            this.estrellasText.Location = new System.Drawing.Point(17, 79);
            this.estrellasText.Name = "estrellasText";
            this.estrellasText.Size = new System.Drawing.Size(137, 25);
            this.estrellasText.TabIndex = 62;
            this.estrellasText.Text = "Estrellas";
            // 
            // tipoAlojamientoCombo
            // 
            this.tipoAlojamientoCombo.BackColor = System.Drawing.SystemColors.ControlText;
            this.tipoAlojamientoCombo.Font = new System.Drawing.Font("Cambria", 11F);
            this.tipoAlojamientoCombo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tipoAlojamientoCombo.FormattingEnabled = true;
            this.tipoAlojamientoCombo.Items.AddRange(new object[] {
            "Hotel",
            "Cabaña"});
            this.tipoAlojamientoCombo.Location = new System.Drawing.Point(17, 3);
            this.tipoAlojamientoCombo.Name = "tipoAlojamientoCombo";
            this.tipoAlojamientoCombo.Size = new System.Drawing.Size(136, 25);
            this.tipoAlojamientoCombo.TabIndex = 63;
            this.tipoAlojamientoCombo.Text = "Tipo Alojamiento";
            this.tipoAlojamientoCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(17, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 31);
            this.button4.TabIndex = 60;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "ALOJAMIENTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baniosText);
            this.panel1.Controls.Add(this.habitacionesText);
            this.panel1.Controls.Add(this.precioText);
            this.panel1.Controls.Add(this.personasText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.tipoAlojamientoCombo);
            this.panel1.Controls.Add(this.estrellasText);
            this.panel1.Controls.Add(this.barrioText);
            this.panel1.Controls.Add(this.alojamientosGrid);
            this.panel1.Controls.Add(this.ciudadText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tvSi);
            this.panel1.Controls.Add(this.tvNo);
            this.panel1.Location = new System.Drawing.Point(28, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 389);
            this.panel1.TabIndex = 65;
            // 
            // baniosText
            // 
            this.baniosText.BackColor = System.Drawing.SystemColors.ControlText;
            this.baniosText.Font = new System.Drawing.Font("Cambria", 11F);
            this.baniosText.ForeColor = System.Drawing.SystemColors.Menu;
            this.baniosText.Location = new System.Drawing.Point(163, 119);
            this.baniosText.Name = "baniosText";
            this.baniosText.Size = new System.Drawing.Size(108, 25);
            this.baniosText.TabIndex = 68;
            this.baniosText.Text = "N° de baños";
            // 
            // habitacionesText
            // 
            this.habitacionesText.BackColor = System.Drawing.SystemColors.ControlText;
            this.habitacionesText.Font = new System.Drawing.Font("Cambria", 11F);
            this.habitacionesText.ForeColor = System.Drawing.SystemColors.Menu;
            this.habitacionesText.Location = new System.Drawing.Point(17, 118);
            this.habitacionesText.Name = "habitacionesText";
            this.habitacionesText.Size = new System.Drawing.Size(137, 25);
            this.habitacionesText.TabIndex = 67;
            this.habitacionesText.Text = "N° de habitaciones";
            // 
            // precioText
            // 
            this.precioText.BackColor = System.Drawing.SystemColors.ControlText;
            this.precioText.Font = new System.Drawing.Font("Cambria", 11F);
            this.precioText.ForeColor = System.Drawing.SystemColors.Menu;
            this.precioText.Location = new System.Drawing.Point(166, 79);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(105, 25);
            this.precioText.TabIndex = 66;
            this.precioText.Text = "Precio por dia";
            // 
            // personasText
            // 
            this.personasText.BackColor = System.Drawing.SystemColors.ControlText;
            this.personasText.Font = new System.Drawing.Font("Cambria", 11F);
            this.personasText.ForeColor = System.Drawing.SystemColors.Menu;
            this.personasText.Location = new System.Drawing.Point(163, 48);
            this.personasText.Name = "personasText";
            this.personasText.Size = new System.Drawing.Size(105, 25);
            this.personasText.TabIndex = 65;
            this.personasText.Text = "N° de personas";
            // 
            // AdmAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Agencia.Properties.Resources.Fadminitrador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(680, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmAlojamientos";
            this.Opacity = 0D;
            this.Text = "Alojamientos";
            this.Load += new System.EventHandler(this.AdmAlojamientos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdmAlojamientos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.alojamientosGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton tvNo;
        private System.Windows.Forms.RadioButton tvSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ciudadText;
        private System.Windows.Forms.DataGridView alojamientosGrid;
        private System.Windows.Forms.TextBox barrioText;
        private System.Windows.Forms.TextBox estrellasText;
        private System.Windows.Forms.ComboBox tipoAlojamientoCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.TextBox personasText;
        private System.Windows.Forms.TextBox habitacionesText;
        private System.Windows.Forms.TextBox baniosText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrellas_text;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}