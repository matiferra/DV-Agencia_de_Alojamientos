using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using Bussines;
using System.IO;


namespace Agencia.Views
{
    public partial class RegistroUsuario : Form
    {
        AgenciaManager ag = new AgenciaManager();

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text;
            string password = txtPassword.Text;
            string DNI = txtDocu.Text;
            string email = txtEmail.Text;
            string esAdmin = "false";
            string bloqueado = "false";




            string fileName = "usuarios.txt";
            string sourcePath = @"C:\plataformas";
            string sourceFile = Path.Combine(sourcePath + @"\USER", fileName);


            if (!string.IsNullOrEmpty(usuario) || !string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(DNI) || !string.IsNullOrEmpty(email))
            {
                if (!Directory.Exists(sourcePath))
                {
                    Directory.CreateDirectory(sourcePath);
                    Directory.CreateDirectory(sourcePath + @"\USER");
                }

                string[] datos = { txtDocu.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, esAdmin, bloqueado, " " };
                if (!File.Exists(sourceFile))
                {
                    File.WriteAllLines(sourceFile, datos);
                }
                else
                {
                    foreach (var item in datos)
                    {
                        File.AppendAllText(sourceFile, item + Environment.NewLine);
                    }
                }
            }


            MessageBox.Show("Sas ingreso con exito");


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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
