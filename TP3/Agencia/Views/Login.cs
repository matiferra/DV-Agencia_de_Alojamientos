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
using System.IO;

namespace Agencia
{
    public partial class Login : Form
    {
        Administrador admin;
        Cliente client;
        static Bussines.Agencia a = new Bussines.Agencia();
        static Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);

        string usuario;
        string contrasenia;

        public Login()
        {
            leerUsuarios();
            InitializeComponent();
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

        public void ocultarRegistro()
        {
            string select = seleccion.SelectedItem.ToString();

            if (select == "Administrador")
            {
                registro.Visible = false;

            }
            else if (select == "Cliente")
            {
                registro.Visible = true;
            }

        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String selec = seleccion.SelectedItem.ToString();

            usuario = txtUsername.Text;
            contrasenia = txtPassword.Text;
            int i = 0;
            bool encontrado = false;
            if (selec == "Administrador")
            {
                while (i <= ag.misUsuarios.Count - 1 && encontrado == false)
                {

                    if (ag.misUsuarios.ElementAt(i).nombre == usuario)
                    {
                        encontrado = true;
                        if (ag.misUsuarios.ElementAt(i).password == contrasenia)
                        {
                            if (ag.misUsuarios.ElementAt(i).esAdmin == true)
                            {
                                this.Hide();
                                admin = new Administrador();
                                admin.Show();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o Contraseña Incorrecto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrecto");
                        }
                    }
                    i++;
                }
                i = 0;
                if (encontrado == false)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto");
                }
                encontrado = false;
            }
            else
            {
                while (i <= ag.misUsuarios.Count - 1 && encontrado == false)
                {
                    if (ag.misUsuarios.ElementAt(i).nombre == usuario)
                    {
                        encontrado = true;
                        if (ag.misUsuarios.ElementAt(i).password == contrasenia)
                        {
                            if (ag.misUsuarios.ElementAt(i).esAdmin == false)
                            {
                                if (ag.misUsuarios.ElementAt(i).bloqueado == false)
                                {
                                    this.Hide();
                                    client = new Cliente();
                                    client.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Este usuario esta temporalmente bloqueado");
                                }
                            }
                            else
                            {
                                encontrado = true;
                                MessageBox.Show("Usuario o Contraseña Incorrecto");
                            }
                        }
                        else
                        {
                            ag.misUsuarios.ElementAt(i).intentosLogueo++;
                            MessageBox.Show("Usuario o Contraseña Incorrecto");
                            if (ag.misUsuarios.ElementAt(i).intentosLogueo >= 3)
                            {
                                MessageBox.Show("Fueron mas de 3 intentos\nSe ha bloqueado tu usuario");
                                ag.misUsuarios.ElementAt(i).bloqueado = true;
                            }
                        }
                    }
                    i++;
                }
                i = 0;
                if (encontrado == false)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto");
                }
                encontrado = false;
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

        private void seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ocultarRegistro();
        }

    }
}
