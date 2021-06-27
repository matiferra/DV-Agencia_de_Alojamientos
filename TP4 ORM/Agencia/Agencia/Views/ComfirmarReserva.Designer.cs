
namespace Agencia.Views
{
    partial class ComfirmarReserva
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
            this.button1 = new System.Windows.Forms.Button();
            this.Id_text = new System.Windows.Forms.TextBox();
            this.desdeFecha = new System.Windows.Forms.DateTimePicker();
            this.hastaFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "comfirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id_text
            // 
            this.Id_text.Location = new System.Drawing.Point(26, 32);
            this.Id_text.Name = "Id_text";
            this.Id_text.Size = new System.Drawing.Size(171, 23);
            this.Id_text.TabIndex = 1;
            this.Id_text.Visible = false;
            // 
            // desdeFecha
            // 
            this.desdeFecha.CalendarFont = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.desdeFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeFecha.Location = new System.Drawing.Point(26, 140);
            this.desdeFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.desdeFecha.Name = "desdeFecha";
            this.desdeFecha.Size = new System.Drawing.Size(133, 31);
            this.desdeFecha.TabIndex = 64;
            // 
            // hastaFecha
            // 
            this.hastaFecha.CalendarFont = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hastaFecha.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastaFecha.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaFecha.Location = new System.Drawing.Point(213, 140);
            this.hastaFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hastaFecha.Name = "hastaFecha";
            this.hastaFecha.Size = new System.Drawing.Size(137, 31);
            this.hastaFecha.TabIndex = 65;
            // 
            // ComfirmarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 558);
            this.Controls.Add(this.hastaFecha);
            this.Controls.Add(this.desdeFecha);
            this.Controls.Add(this.Id_text);
            this.Controls.Add(this.button1);
            this.Name = "ComfirmarReserva";
            this.Text = "ComfirmarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Id_text;
        public System.Windows.Forms.DateTimePicker desdeFecha;
        public System.Windows.Forms.DateTimePicker hastaFecha;
    }
}