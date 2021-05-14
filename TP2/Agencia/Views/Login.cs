using Agencia.Views;
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
using Bussines;

namespace Agencia
{
    public partial class Login : Form
    {  
        Administrador admin;
        Cliente client;
        public Login()
        {
            InitializeComponent();
            
        }

     

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        String selec =seleccion.SelectedItem.ToString();
            if(selec == "Administrador")
            {
            this.Hide();
                    admin = new Administrador();
                    admin.Show();
            } else if (selec == "Cliente")
            {
                this.Hide();
                client = new Cliente();
                client.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

  
        private void pictureBox3_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
