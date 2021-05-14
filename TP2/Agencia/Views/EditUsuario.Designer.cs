
namespace Agencia.Views
{
    partial class EditUsuario
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAceptarmodi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(45, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 29);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "Ingrese el DNI";
            // 
            // btnAceptarmodi
            // 
            this.btnAceptarmodi.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarmodi.FlatAppearance.BorderSize = 2;
            this.btnAceptarmodi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptarmodi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptarmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarmodi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarmodi.ForeColor = System.Drawing.Color.White;
            this.btnAceptarmodi.Location = new System.Drawing.Point(453, 246);
            this.btnAceptarmodi.Name = "btnAceptarmodi";
            this.btnAceptarmodi.Size = new System.Drawing.Size(136, 31);
            this.btnAceptarmodi.TabIndex = 37;
            this.btnAceptarmodi.Text = "Aceptar";
            this.btnAceptarmodi.UseVisualStyleBackColor = false;
            this.btnAceptarmodi.Click += new System.EventHandler(this.btnAceptarmodi_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(437, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 29);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Ingrese Email";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(242, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "Ingrese Nombre";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Cambria", 14F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(99, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 29);
            this.textBox3.TabIndex = 40;
            this.textBox3.Text = "Ingrese el password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "EDITAR USUARIO";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 14F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(319, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 30);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.Text = "Tipo Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btnAceptarmodi);
            this.panel1.Location = new System.Drawing.Point(28, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 389);
            this.panel1.TabIndex = 65;
            // 
            // EditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Agencia.Properties.Resources.Fadminitrador;
            this.ClientSize = new System.Drawing.Size(680, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUsuario";
            this.Text = "EditUsuario";
            this.Load += new System.EventHandler(this.EditUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAceptarmodi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}