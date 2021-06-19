using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Agencia.Views
{
    public partial class Administrador : Form
    {
         private Form currentChildForm;

      //  public Bussines.AgenciaManager ag { get; set; }
        AdmAlojamientos admAlojamientosForm;
        AdmReservas admReservasForm;
        AdmUsuarios admUsuariosForm;
        

        public Administrador(AdmUsuarios admUsuariosForm, AdmAlojamientos admAlojamientosForm, AdmReservas admReservasForm)
        {
            InitializeComponent();
            
            
            this.admAlojamientosForm = admAlojamientosForm;
            this.admUsuariosForm = admUsuariosForm;
            this.admReservasForm = admReservasForm;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm = null;
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }


      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        /*
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        */

        private void Administrador_MouseDown(object sender, MouseEventArgs e)
        {
        //    ReleaseCapture();
          //  SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           OpenChildForm(new AdmUsuarios());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdmReservas());
        }

        private void button3_Click_1(object sender, EventArgs e)

        {
           // admAlojamientosForm.agencia = ag;
            OpenChildForm(admAlojamientosForm);
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
