using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

using System.IO;
using Bussines;

namespace Agencia.Views
{
    public partial class RegistroUsuario : Form
    {

        public AgenciaManager ag;
        public RegistroUsuario(AgenciaManager agenciaManager)
        {
            InitializeComponent();
            this.ag = agenciaManager;
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string password = txtPassword.Text;
            string DNI = txtDocu.Text;
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password) && 
                !string.IsNullOrEmpty(DNI) && !string.IsNullOrEmpty(email))
            {
                if (ag.agregarUsuario(int.Parse(DNI), usuario, email, password, false, false))
                {
                    MessageBox.Show("Sas ingreso con exito");

                    limpioCampos();
                }
                else
                {
                    MessageBox.Show("error al registrar usuario");
                }
            }
            else
            {
                MessageBox.Show("todos los campos son requeridos");
            }

      
        }

        private void limpioCampos()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtDocu.Text =string.Empty;
            txtEmail.Text = string.Empty;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
         this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
