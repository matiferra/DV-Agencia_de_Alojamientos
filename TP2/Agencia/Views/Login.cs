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

        string usuario;
        string contrasenia;

        public Login()
        {
            InitializeComponent();
        }

        private void leerUsuarios()
        {
            //LEER
            string fileName = "alojamientos.txt";
            string sourcePath = @"C:\plataformas";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string contenido = String.Empty;

            if (File.Exists(sourceFile))
            {
                contenido = File.ReadAllText(sourceFile);
                string[] lineas = contenido.Split(new[] { Environment.NewLine },
                                                    StringSplitOptions.None
                );

                //LINEAS DEL ARCHIVO
                //1 - Tipo Alojamiento
                //2 - ciudad
                //3 - barrio
                //4 - estrellas
                //5 - cantPersonas
                //6 - tv
                //7 - precio
                //8 - habitaciones
                //9 - banios

                for (int i = 0; i < lineas.Length; i++)
                {
                    try
                    {
                        if (lineas[0] == "Hotel")
                        {
                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxPersona
                            Bussines.Hotel hotel = new Bussines.Hotel(lineas[1], lineas[2], lineas[3], int.Parse(lineas[4]), bool.Parse(lineas[5]), Double.Parse(lineas[6]));
                            a.insertarAlojamiento(hotel);
                        }
                        else
                        {
                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxDia, int habitaciones, int banios
                            Bussines.Cabania cabania = new Bussines.Cabania(lineas[1], lineas[2], lineas[3], int.Parse(lineas[4]), bool.Parse(lineas[5]), Double.Parse(lineas[6]), int.Parse(lineas[7]), int.Parse(lineas[8]));

                            a.insertarAlojamiento(cabania);

                        }
                        i = i + 10;
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

            Bussines.AgenciaManager ag = new Bussines.AgenciaManager(a);
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
        String selec =seleccion.SelectedItem.ToString();

            usuario = txtUsername.Text;
            contrasenia = txtPassword.Text;

            if (selec == "Administrador")
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

        private void Login_Load(object sender, EventArgs e) { 
        
            
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
