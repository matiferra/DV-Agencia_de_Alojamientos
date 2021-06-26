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
using System.IO;

namespace Agencia
{
    public partial class Login : Form
    {
        Administrador adminForm;
        Cliente clienteForm;
        RegistroUsuario registroUsuarioForm;
        Bussines.AgenciaManager ag = new Bussines.AgenciaManager();
        //public Usuario user;

        public Login(Administrador adminForm, Cliente clienteForm, RegistroUsuario registroUsuarioForm)
        {
            InitializeComponent();
            //this.ag = agenciaManager;
            //  this.user = usuario;
            this.adminForm = adminForm;
            this.clienteForm = clienteForm;
            this.registroUsuarioForm = registroUsuarioForm;

        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ag.autenticar(txtUsername.Text, txtPassword.Text))
            {
                Global.GlobalSessionNombre = txtUsername.Text;//creo clase "Global" con el propisto de poder almacenar el nombre del usuario y poder identificar a la hora de cambiar contraseña.
                Global.GlobalSessionPass = txtPassword.Text;
                List<string> usuario = ag.buscarUsuarioxNombre(txtUsername.Text);
                bool bloqueado = bool.Parse(usuario.ElementAt(5));
                if (bool.Parse(usuario.ElementAt(4)) == true)
                {
                    if (!bloqueado)
                    {
                        adminForm.Dock = DockStyle.Fill;
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario esta bloqueado");
                    }
                }
                else
                {
                    if (!bloqueado)
                    {
                        clienteForm.Dock = DockStyle.Fill;
                        clienteForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario esta bloqueado");
                    }
                }
                txtUsername.Text = "";
                txtPassword.Text = "";
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
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registro_Click(object sender, EventArgs e)
        {
            registroUsuarioForm.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
