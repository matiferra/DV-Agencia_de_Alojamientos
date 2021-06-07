
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmAlojamientos));
            this.alojamientosGrid = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar_aloja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrellas_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tv_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_alojamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Banio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioText = new System.Windows.Forms.TextBox();
            this.estrellasText = new System.Windows.Forms.TextBox();
            this.tipoAlojamientoCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_ciudadHeader = new System.Windows.Forms.ComboBox();
            this.check_tv = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LDiaOPer = new System.Windows.Forms.Label();
            this.LBaños = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LPersonas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LHabitaciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precioText = new System.Windows.Forms.TextBox();
            this.Agrego_boton = new System.Windows.Forms.Button();
            this.baniosText = new System.Windows.Forms.TextBox();
            this.habitacionesText = new System.Windows.Forms.TextBox();
            this.personasText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alojamientosGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alojamientosGrid
            // 
            this.alojamientosGrid.AllowUserToAddRows = false;
            this.alojamientosGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.alojamientosGrid.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alojamientosGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alojamientosGrid.ColumnHeadersHeight = 37;
            this.alojamientosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.alojamientosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar_aloja,
            this.Id,
            this.Barrio_text,
            this.Estrellas_text,
            this.cant_Persona,
            this.tv_text,
            this.tip_alojamiento,
            this.Ciudad_text,
            this.CantHabitacion,
            this.Precio_dia,
            this.pre_persona,
            this.Cantidad_Banio});
            this.alojamientosGrid.EnableHeadersVisualStyles = false;
            this.alojamientosGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.alojamientosGrid.Location = new System.Drawing.Point(14, 231);
            this.alojamientosGrid.Name = "alojamientosGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alojamientosGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.alojamientosGrid.RowHeadersVisible = false;
            this.alojamientosGrid.RowHeadersWidth = 22;
            this.alojamientosGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.alojamientosGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.alojamientosGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alojamientosGrid.Size = new System.Drawing.Size(943, 243);
            this.alojamientosGrid.TabIndex = 59;
            this.alojamientosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alojamientosGrid_CellClick);
            this.alojamientosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 10;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 60;
            // 
            // Eliminar_aloja
            // 
            this.Eliminar_aloja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            this.Eliminar_aloja.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar_aloja.HeaderText = "";
            this.Eliminar_aloja.Name = "Eliminar_aloja";
            this.Eliminar_aloja.Text = "Eliminar";
            this.Eliminar_aloja.UseColumnTextForButtonValue = true;
            this.Eliminar_aloja.Width = 60;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Barrio_text
            // 
            this.Barrio_text.HeaderText = "Barrio";
            this.Barrio_text.Name = "Barrio_text";
            this.Barrio_text.Width = 60;
            // 
            // Estrellas_text
            // 
            this.Estrellas_text.HeaderText = "Estrella";
            this.Estrellas_text.Name = "Estrellas_text";
            this.Estrellas_text.Width = 50;
            // 
            // cant_Persona
            // 
            this.cant_Persona.HeaderText = "Nro.Persona";
            this.cant_Persona.Name = "cant_Persona";
            // 
            // tv_text
            // 
            this.tv_text.HeaderText = "tv";
            this.tv_text.Name = "tv_text";
            this.tv_text.Width = 50;
            // 
            // tip_alojamiento
            // 
            this.tip_alojamiento.HeaderText = "Tipo Alojamiento";
            this.tip_alojamiento.Name = "tip_alojamiento";
            // 
            // Ciudad_text
            // 
            this.Ciudad_text.HeaderText = "Ciudad";
            this.Ciudad_text.Name = "Ciudad_text";
            this.Ciudad_text.Width = 60;
            // 
            // CantHabitacion
            // 
            this.CantHabitacion.HeaderText = "Nro Habitacion";
            this.CantHabitacion.Name = "CantHabitacion";
            this.CantHabitacion.Width = 50;
            // 
            // Precio_dia
            // 
            this.Precio_dia.HeaderText = "Precio por dia";
            this.Precio_dia.Name = "Precio_dia";
            // 
            // pre_persona
            // 
            this.pre_persona.HeaderText = "Precio por Persona";
            this.pre_persona.Name = "pre_persona";
            // 
            // Cantidad_Banio
            // 
            this.Cantidad_Banio.HeaderText = "Nro.Baños";
            this.Cantidad_Banio.Name = "Cantidad_Banio";
            // 
            // barrioText
            // 
            this.barrioText.BackColor = System.Drawing.SystemColors.ControlText;
            this.barrioText.Font = new System.Drawing.Font("Cambria", 11F);
            this.barrioText.ForeColor = System.Drawing.SystemColors.Menu;
            this.barrioText.Location = new System.Drawing.Point(151, 129);
            this.barrioText.Name = "barrioText";
            this.barrioText.Size = new System.Drawing.Size(137, 25);
            this.barrioText.TabIndex = 61;
            // 
            // estrellasText
            // 
            this.estrellasText.BackColor = System.Drawing.SystemColors.ControlText;
            this.estrellasText.Font = new System.Drawing.Font("Cambria", 11F);
            this.estrellasText.ForeColor = System.Drawing.SystemColors.Menu;
            this.estrellasText.Location = new System.Drawing.Point(318, 60);
            this.estrellasText.Name = "estrellasText";
            this.estrellasText.Size = new System.Drawing.Size(137, 25);
            this.estrellasText.TabIndex = 62;
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
            this.tipoAlojamientoCombo.Location = new System.Drawing.Point(148, 60);
            this.tipoAlojamientoCombo.Name = "tipoAlojamientoCombo";
            this.tipoAlojamientoCombo.Size = new System.Drawing.Size(136, 25);
            this.tipoAlojamientoCombo.TabIndex = 63;
            this.tipoAlojamientoCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "ALOJAMIENTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_ciudadHeader);
            this.panel1.Controls.Add(this.check_tv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LDiaOPer);
            this.panel1.Controls.Add(this.LBaños);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LPersonas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LHabitaciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.precioText);
            this.panel1.Controls.Add(this.Agrego_boton);
            this.panel1.Controls.Add(this.baniosText);
            this.panel1.Controls.Add(this.habitacionesText);
            this.panel1.Controls.Add(this.personasText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tipoAlojamientoCombo);
            this.panel1.Controls.Add(this.estrellasText);
            this.panel1.Controls.Add(this.barrioText);
            this.panel1.Controls.Add(this.alojamientosGrid);
            this.panel1.Location = new System.Drawing.Point(28, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 488);
            this.panel1.TabIndex = 65;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // combo_ciudadHeader
            // 
            this.combo_ciudadHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combo_ciudadHeader.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ciudadHeader.ForeColor = System.Drawing.Color.White;
            this.combo_ciudadHeader.FormattingEnabled = true;
            this.combo_ciudadHeader.Location = new System.Drawing.Point(678, 60);
            this.combo_ciudadHeader.Name = "combo_ciudadHeader";
            this.combo_ciudadHeader.Size = new System.Drawing.Size(137, 25);
            this.combo_ciudadHeader.TabIndex = 103;
            // 
            // check_tv
            // 
            this.check_tv.AutoSize = true;
            this.check_tv.Location = new System.Drawing.Point(189, 201);
            this.check_tv.Name = "check_tv";
            this.check_tv.Size = new System.Drawing.Size(15, 14);
            this.check_tv.TabIndex = 80;
            this.check_tv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(152, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Servicio de Tv?";
            // 
            // LDiaOPer
            // 
            this.LDiaOPer.AutoSize = true;
            this.LDiaOPer.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.LDiaOPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDiaOPer.Location = new System.Drawing.Point(319, 108);
            this.LDiaOPer.Name = "LDiaOPer";
            this.LDiaOPer.Size = new System.Drawing.Size(106, 17);
            this.LDiaOPer.TabIndex = 78;
            this.LDiaOPer.Text = "Precio por día";
            // 
            // LBaños
            // 
            this.LBaños.AutoSize = true;
            this.LBaños.Font = new System.Drawing.Font("Cambria", 10.75F, System.Drawing.FontStyle.Bold);
            this.LBaños.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBaños.Location = new System.Drawing.Point(675, 105);
            this.LBaños.Name = "LBaños";
            this.LBaños.Size = new System.Drawing.Size(90, 17);
            this.LBaños.TabIndex = 77;
            this.LBaños.Text = "Nº de baños";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(147, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Tipo de alojamiento";
            // 
            // LPersonas
            // 
            this.LPersonas.AutoSize = true;
            this.LPersonas.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.LPersonas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPersonas.Location = new System.Drawing.Point(496, 39);
            this.LPersonas.Name = "LPersonas";
            this.LPersonas.Size = new System.Drawing.Size(83, 16);
            this.LPersonas.TabIndex = 75;
            this.LPersonas.Text = "Nº personas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(318, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Nº estrellas";
            // 
            // LHabitaciones
            // 
            this.LHabitaciones.AutoSize = true;
            this.LHabitaciones.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.LHabitaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LHabitaciones.Location = new System.Drawing.Point(499, 109);
            this.LHabitaciones.Name = "LHabitaciones";
            this.LHabitaciones.Size = new System.Drawing.Size(106, 16);
            this.LHabitaciones.TabIndex = 73;
            this.LHabitaciones.Text = "Nº habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(150, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Ingresar barrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(680, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Ingresar ciudad";
            // 
            // precioText
            // 
            this.precioText.BackColor = System.Drawing.SystemColors.ControlText;
            this.precioText.Font = new System.Drawing.Font("Cambria", 11F);
            this.precioText.ForeColor = System.Drawing.SystemColors.Menu;
            this.precioText.Location = new System.Drawing.Point(318, 129);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(137, 25);
            this.precioText.TabIndex = 70;
            // 
            // Agrego_boton
            // 
            this.Agrego_boton.BackColor = System.Drawing.Color.Transparent;
            this.Agrego_boton.FlatAppearance.BorderSize = 2;
            this.Agrego_boton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Agrego_boton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Agrego_boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agrego_boton.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Agrego_boton.ForeColor = System.Drawing.Color.White;
            this.Agrego_boton.Location = new System.Drawing.Point(711, 173);
            this.Agrego_boton.Name = "Agrego_boton";
            this.Agrego_boton.Size = new System.Drawing.Size(104, 36);
            this.Agrego_boton.TabIndex = 69;
            this.Agrego_boton.Text = "Agregar";
            this.Agrego_boton.UseVisualStyleBackColor = false;
            this.Agrego_boton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // baniosText
            // 
            this.baniosText.BackColor = System.Drawing.SystemColors.ControlText;
            this.baniosText.Font = new System.Drawing.Font("Cambria", 11F);
            this.baniosText.ForeColor = System.Drawing.SystemColors.Menu;
            this.baniosText.Location = new System.Drawing.Point(678, 126);
            this.baniosText.Name = "baniosText";
            this.baniosText.Size = new System.Drawing.Size(137, 25);
            this.baniosText.TabIndex = 68;
            // 
            // habitacionesText
            // 
            this.habitacionesText.BackColor = System.Drawing.SystemColors.ControlText;
            this.habitacionesText.Font = new System.Drawing.Font("Cambria", 11F);
            this.habitacionesText.ForeColor = System.Drawing.SystemColors.Menu;
            this.habitacionesText.Location = new System.Drawing.Point(499, 129);
            this.habitacionesText.Name = "habitacionesText";
            this.habitacionesText.Size = new System.Drawing.Size(137, 25);
            this.habitacionesText.TabIndex = 67;
            // 
            // personasText
            // 
            this.personasText.BackColor = System.Drawing.SystemColors.ControlText;
            this.personasText.Font = new System.Drawing.Font("Cambria", 11F);
            this.personasText.ForeColor = System.Drawing.SystemColors.Menu;
            this.personasText.Location = new System.Drawing.Point(499, 60);
            this.personasText.Name = "personasText";
            this.personasText.Size = new System.Drawing.Size(137, 25);
            this.personasText.TabIndex = 65;
            // 
            // AdmAlojamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1025, 530);
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
        private System.Windows.Forms.DataGridView alojamientosGrid;
        private System.Windows.Forms.TextBox barrioText;
        private System.Windows.Forms.TextBox estrellasText;
        private System.Windows.Forms.ComboBox tipoAlojamientoCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox personasText;
        private System.Windows.Forms.TextBox habitacionesText;
        private System.Windows.Forms.TextBox baniosText;
        private System.Windows.Forms.Button Agrego_boton;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LHabitaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LDiaOPer;
        private System.Windows.Forms.Label LBaños;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LPersonas;
        private System.Windows.Forms.CheckBox check_tv;
        public System.Windows.Forms.ComboBox combo_ciudadHeader;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar_aloja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrellas_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tv_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip_alojamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Banio;
    }
}