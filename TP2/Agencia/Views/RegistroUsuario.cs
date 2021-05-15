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

        string nombre;
        string password;
        int DNI;
        string email;
        string tipoAlojamiento;
        string tipoUsuario;



        static string fileName = "users.txt";
        static string sourcePath = @"C:\plataformas";
        static string targetPath = @"C:\plataformas";
        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);


        AgenciaManager ag = new AgenciaManager();

        public RegistroUsuario()
        {
            InitializeComponent();
        }



        private void registrarse_Click(object sender, EventArgs e)
        {

            //string[] lineas = { txtUsername.Text, txtEmail.Text };
            //using (StreamWriter outp = new StreamWriter(@"c/d"))
            //{
            //    foreach (var item in lineas)
            //    {
            //        outp.WriteLine(lineas);
            //    }
            //}
            string[] datos = { txtDocu.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, seleccion.Text };
            if (!File.Exists(sourceFile))
            {
                File.WriteAllLines(sourceFile, datos);
            } else
            {
                foreach (var item in datos)
                {
                    File.AppendAllText(sourceFile, item + Environment.NewLine);
                }
                

            }



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
