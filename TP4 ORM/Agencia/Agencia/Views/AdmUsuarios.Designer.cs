
namespace Agencia.Views
{
    partial class AdmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmUsuarios));
            this.buscarButton = new System.Windows.Forms.Button();
            this.buscarText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.boton_desbloquear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boton_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boton_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Col_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_bloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_esadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.BackColor = System.Drawing.Color.Transparent;
            this.buscarButton.FlatAppearance.BorderSize = 2;
            this.buscarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buscarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarButton.ForeColor = System.Drawing.Color.Honeydew;
            this.buscarButton.Location = new System.Drawing.Point(522, 71);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(133, 28);
            this.buscarButton.TabIndex = 34;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = false;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // buscarText
            // 
            this.buscarText.BackColor = System.Drawing.SystemColors.ControlText;
            this.buscarText.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarText.ForeColor = System.Drawing.SystemColors.Menu;
            this.buscarText.Location = new System.Drawing.Point(208, 71);
            this.buscarText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buscarText.Name = "buscarText";
            this.buscarText.Size = new System.Drawing.Size(292, 28);
            this.buscarText.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Buscar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewUsuarios);
            this.panel1.Controls.Add(this.buscarButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buscarText);
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 452);
            this.panel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingresar Documento";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boton_desbloquear,
            this.boton_Editar,
            this.boton_eliminar,
            this.Col_dni,
            this.col_mail,
            this.Col_bloqueado,
            this.Col_nombre,
            this.Col_esadmin,
            this.Col_pass,
            this.id});
            this.dataGridViewUsuarios.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(60, 120);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(793, 313);
            this.dataGridViewUsuarios.TabIndex = 39;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            this.dataGridViewUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUsuarios_CellFormatting);
            this.dataGridViewUsuarios.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewUsuarios_RowPrePaint);
            // 
            // boton_desbloquear
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.boton_desbloquear.DefaultCellStyle = dataGridViewCellStyle1;
            this.boton_desbloquear.HeaderText = "";
            this.boton_desbloquear.Name = "boton_desbloquear";
            this.boton_desbloquear.Text = "Desbloquear";
            this.boton_desbloquear.UseColumnTextForButtonValue = true;
            this.boton_desbloquear.Width = 70;
            // 
            // boton_Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.boton_Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.boton_Editar.HeaderText = "";
            this.boton_Editar.Name = "boton_Editar";
            this.boton_Editar.Text = "Editar";
            this.boton_Editar.UseColumnTextForButtonValue = true;
            this.boton_Editar.Width = 60;
            // 
            // boton_eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.boton_eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.boton_eliminar.HeaderText = "";
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseColumnTextForButtonValue = true;
            this.boton_eliminar.Width = 60;
            // 
            // Col_dni
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Col_dni.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_dni.HeaderText = "DNI";
            this.Col_dni.Name = "Col_dni";
            this.Col_dni.ReadOnly = true;
            // 
            // col_mail
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.col_mail.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_mail.HeaderText = "Mail";
            this.col_mail.Name = "col_mail";
            this.col_mail.ReadOnly = true;
            this.col_mail.Width = 150;
            // 
            // Col_bloqueado
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Col_bloqueado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_bloqueado.HeaderText = "Bloqueado";
            this.Col_bloqueado.Name = "Col_bloqueado";
            this.Col_bloqueado.ReadOnly = true;
            // 
            // Col_nombre
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.Col_nombre.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col_nombre.HeaderText = "nombre";
            this.Col_nombre.Name = "Col_nombre";
            this.Col_nombre.ReadOnly = true;
            this.Col_nombre.Width = 150;
            // 
            // Col_esadmin
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.Col_esadmin.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_esadmin.HeaderText = "Es Admin";
            this.Col_esadmin.Name = "Col_esadmin";
            this.Col_esadmin.ReadOnly = true;
            // 
            // Col_pass
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.Col_pass.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col_pass.HeaderText = "Contraseña";
            this.Col_pass.Name = "Col_pass";
            this.Col_pass.ReadOnly = true;
            this.Col_pass.Visible = false;
            this.Col_pass.Width = 30;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // AdmUsuarios
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
            this.Name = "AdmUsuarios";
            this.Text = "AdmUsuarios";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.AdmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox buscarText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn boton_desbloquear;
        private System.Windows.Forms.DataGridViewButtonColumn boton_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn boton_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_bloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_esadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}