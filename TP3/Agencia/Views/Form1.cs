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
 
namespace Agencia.Views
{
    public partial class Form1 : Form
    {
        static Bussines.Agencia agencia = new Bussines.Agencia();
        static Bussines.AgenciaManager agenciaManager = new Bussines.AgenciaManager(agencia);
        static Bussines.Usuario usuario = new Bussines.Usuario();
        public Form1()
        {
            InitializeComponent();
            leerUsuarios();
            leerAlojamientos();
            AdmAlojamientos admAlojamientosForm = new AdmAlojamientos();
            admAlojamientosForm.MdiParent = this;
            AdmReservas admReservasForm = new AdmReservas();
            admReservasForm.MdiParent = this;
            AdmUsuarios admUsuarios = new AdmUsuarios();
            admUsuarios.MdiParent = this;
            Administrador adminForm = new Administrador(admUsuarios, admAlojamientosForm, admReservasForm, agenciaManager);
            adminForm.MdiParent = this;
            BusquedaAlojamiento busquedadAlojamientosForm = new BusquedaAlojamiento();
            busquedadAlojamientosForm.MdiParent = this;
            RecuperarContraseña cambiarContraseniasForm = new RecuperarContraseña();
            cambiarContraseniasForm.MdiParent = this;
            ResultadoBusqueda resultadoBusquedaForm = new ResultadoBusqueda();
            resultadoBusquedaForm.MdiParent = this;
            Cliente clienteForm = new Cliente(busquedadAlojamientosForm, cambiarContraseniasForm, resultadoBusquedaForm);
            clienteForm.MdiParent = this;
            RegistroUsuario registroUsuarioForm = new RegistroUsuario(agenciaManager);
            registroUsuarioForm.MdiParent = this;

            Login loginForm = new Login(adminForm, clienteForm, registroUsuarioForm, agenciaManager, usuario);
            loginForm.MdiParent = this;
            loginForm.Show();
        }


        private void leerUsuarios()
        {
            string fileName = "usuarios.txt";
            string sourcePath = @"C:\PlataformasTP\Usuarios";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string contenido = String.Empty;

            if (File.Exists(sourceFile))
            {
                contenido = File.ReadAllText(sourceFile);
                string[] lineas = contenido.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

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
                        agenciaManager.agregarUsuario(DNI, nombre, mail, password, esAdmin, bloqueado);
                        i = i + 6;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
        }

        private void leerAlojamientos()
        {
            //LEER
            string fileName = "Alojamientos.txt";
            string sourcePath = @"C:\PlataformasTP";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string contenido = String.Empty;

            if (File.Exists(sourceFile))
            {
                contenido = File.ReadAllText(sourceFile);
                string[] lineas = contenido.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

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

                string TipoAlojamiento;
                string ciudad;
                string barrio;
                string estrellas;
                int cantPersonas;
                bool tv;
                double precio;
                int habitaciones;
                int banios;


                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    TipoAlojamiento = lineas[i];
                    ciudad = lineas[i + 1];
                    barrio = lineas[i + 2];
                    estrellas = lineas[i + 3];
                    cantPersonas = int.Parse(lineas[i + 4]);
                    tv = bool.Parse(lineas[i + 5]);
                    precio = Double.Parse(lineas[i + 6]);



                    try
                    {
                        if (TipoAlojamiento == "Hotel")
                        {
                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxPersona
                            Bussines.Hotel hotel = new Bussines.Hotel(ciudad, barrio, estrellas, cantPersonas, tv, precio);
                            agenciaManager.miAgencia.insertarAlojamiento(hotel);
                        }
                        else
                        {
                            habitaciones = int.Parse(lineas[i + 7]);
                            banios = int.Parse(lineas[i + 8]);

                            //string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxDia, int habitaciones, int banios
                            Bussines.Cabania cabania = new Bussines.Cabania(ciudad, barrio, estrellas, cantPersonas, tv, precio, habitaciones, banios);

                            agenciaManager.miAgencia.insertarAlojamiento(cabania);
                        }
                        i = i + 9;
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
        }
    }

}
