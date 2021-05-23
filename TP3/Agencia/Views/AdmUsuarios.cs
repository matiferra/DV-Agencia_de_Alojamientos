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
    public partial class AdmUsuarios : Form
    {
        static Bussines.Agencia a = new Bussines.Agencia();
        static Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);

        Usuario usuario = null;
        Usuario usuarioEnMemoria = null;

        private Form currentChildForm;

        public AdmUsuarios()
        {
            leerUsuarios();
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(60, Color.Black);

        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void leerUsuarios()
        {
            //LEER
            string fileName = "usuarios.txt";
            string sourcePath = @"C:\plataformas\USER";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string contenido = String.Empty;

            if (File.Exists(sourceFile))
            {
                contenido = File.ReadAllText(sourceFile);
                string[] lineas = contenido.Split(new[] { Environment.NewLine },
                                                    StringSplitOptions.None
                );


                //LINEAS DEL ARCHIVO
                //0 - nombre
                //1 - DNI
                //2 - mail
                //3 - password
                //4 - esAdmin
                //5 - bloqueado

                string nombre;
                string DNI;
                string mail;
                string password;
                bool esAdmin;
                bool bloqueado;

                for (int i = 0; i < lineas.Length - 1; i++)
                {

                    DNI = lineas[i];
                    nombre = lineas[i + 1];
                    mail = lineas[i + 2];
                    password = lineas[i + 3];
                    esAdmin = bool.Parse(lineas[i + 4]);
                    bloqueado = bool.Parse(lineas[i + 5]);

                    try
                    {
                        //int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado
                        ag.agregarUsuario(DNI, nombre, mail, password, esAdmin, bloqueado);
                        i = i + 6;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            else
            {
                Console.WriteLine("No existe");
            }

        }
        private void AdmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            string DNI = buscarText.Text;
            foreach (var item in ag.misUsuarios)
            {

                if (item.DNI == DNI)
                {
                    usuario = item;
                }
            }
            
            if(usuario != null)
            {
                DNIText.Text = usuario.DNI + "";
                passText.Text = usuario.password;
                mailText.Text = usuario.mail;
                nombreText.Text = usuario.nombre;
                if(usuario.esAdmin == true)
                {
                    TipoCombo.SelectedItem = "Administrador";
                } else
                {
                    TipoCombo.SelectedItem = "Cliente";
                }
                usuario = null;
                usuarioEnMemoria = usuario;
            } else
            {
                DNIText.Text = "Ingrese DNI";
                passText.Text = "Ingrese contraseña";
                mailText.Text = "Ingrese e-mail";
                nombreText.Text = "Ingrese nombre";
            }
        }

        private void desbloquearButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ag.misUsuarios)
            {
                if (usuarioEnMemoria.DNI == item.DNI)
                {
                    ag.desbloquearUsuario(item.DNI);
                }
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ag.misUsuarios)
            {
                if (usuarioEnMemoria.DNI == item.DNI)
                {
                    ag.eliminarUsuario(item.DNI);
                }
            }
        }
    }
}
