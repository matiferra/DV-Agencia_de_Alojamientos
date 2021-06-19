using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class AgenciaManager
    {
        private DbSet<Usuario> misUsuarios;
        private MyContext contexto;

        public AgenciaManager()
        {
            inicializarAtributos();
        }

        

        private void inicializarAtributos()
        {
            try
            {
                //creo un contexto
                contexto = new MyContext();
                //cargo los usuarios
                contexto.Usuario.Load();
                misUsuarios = contexto.Usuario;
            }
            catch (Exception)
            {

            }
        }



        public List<Usuario> getUsuario()
        {
            using (var con = new MyContext())
            {
                return con.Usuario.ToList();
            }
        }


        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> salida = new List<List<string>>();
            foreach (Usuario u in contexto.Usuario)
                salida.Add(new List<string> { u.DNI.ToString(), u.nombre, u.mail, u.password, u.esAdmin.ToString(), u.bloqueado.ToString() });
            return salida;
        }

        public bool agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            try
            {
                Usuario nuevo = new Usuario(Dni, Nombre, Mail, Password, EsADM, Bloqueado);
                //contexto.usuarios.Add(nuevo);
                misUsuarios.Add(nuevo);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        public DataSet obtenerAlojamientos(string ciudad)
        {
            return null;
        }

        public DataSet buscarAlojamientos(string Ciudad, string Pdesde, string Phasta, string cantPersonas, string tipo)
        {



            if (string.IsNullOrEmpty(cantPersonas))
            {
                cantPersonas = "0";
            }

            if (tipo == "Hotel")
            {
                esHotel = true;
            }
            else
            {
                esHotel = false;
            }

            try
            {
               

            }
            catch (Exception ex)
            {
                // mensajeError = "error en buscoAlojamiento" + ex.Message;
            }


            return ds;
        }

        public DataSet obtenerAlojamientos()
        {
            return ds;
        }

        public bool agregarAlojamiento(string tipo, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv, string precio, string habitaciones, string banios) //Parametro Datos del Alojamiento ¿?
        {
            bool result;
            try
            {
                if (tipo == "Hotel")
                {
                    result = true;
                }
                else
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool modificarAlojamiento(string codigoInstancia, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv, string precioxDia,
                                         string habitaciones, string banios, string precioxPersona)
        {
            bool result;
            if (string.IsNullOrEmpty(precioxDia))
            {
                precioxDia = "0";
            }
            if (string.IsNullOrEmpty(habitaciones))
            {
                habitaciones = "0";
            }
            if (string.IsNullOrEmpty(banios))
            {
                banios = "0";
            }
            if (string.IsNullOrEmpty(precioxPersona))
            {
                precioxPersona = "0";
            }


            try
            {
              
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }



            return result;
        }

        public bool quitarAlojamiento(int codigo)
        {
            bool result;
            try
            {
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }


        /// <summary>
        /// recupero todos los usaurios
        /// </summary>
        /// <returns></returns>
        public DataSet getUsuario()
        {
            return null;
        }
        /// <summary>
        /// recupero UN usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DataSet buscarUsuario(string dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                dni = "0";
            }
            return null;
        }
        public DataSet buscarUsuarioxNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return null;
            }
            return null;
        }


        public bool sumarIntentosDeLogeo(int contadorIntentos, string dni)
        {
            return false;
        }

        public bool bloquearUsuario(string dni)
        {
            return false;
        }

        public bool agregarUsuario(string DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            bool result;
            try
            {
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool modificarUsuario(int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            bool result;
            try
            {
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool eliminarUsuario(string DNI)
        {
            bool result;
            try
            {
               
                result = true;
            }
            catch
            {
                result = false;

            }

            return result;
        }

        public bool login(string usuario, string pass)
        {
            return false;
        }

        public bool validoSiEsAdmin(string usuario)
        {
            return false;
        }

        public bool desbloquearUsuario(string DNI)
        {
            bool desbloqueado;
            try
            {
                desbloqueado = true;
            }
            catch
            {
                desbloqueado = false;
            }

            return desbloqueado;
        }

        public string recuperoDni(string usuario, string contraseña)
        {
            string resultado = "";
            return resultado;
        }

        public string cambiarContrasenia(string DNI, string oldPass, string newPass1, string newPass2)
        {
            //completen todos los campos y pulsen guardar
            //recupero contraseña actual de mi dataset
            //macheo si mi contraseña coincide con el campo de contra actual
            //Si es incorrecto mensaje de alerta avisando el asunto.
            //si pasa  lo proximo hacer es machear la contraseña nueva con la reigresar contraseña y verificar si son iguales
            return null;
        }



        public bool autenticarUsuario(string DNI, string password)
        {
            //LO DIVIDI EN DOS PARTES UNA EN EL METODO login Y OTRO validoSiEsAdmin  QUEDA PENDIENTE QUE LO BLOQUEE SI INTENTIO LOGEARSE 3 VECES

            bool autenticado = false;

            return autenticado;
        }


        public DataSet getTodasLasReservas()
        {
            return null;
        }
        public DataSet getReservasPorCliente(String dni)
        {
            return null;
        }





        public DataSet buscarReservas(string dni, string fdesde, string fhasta)
        {
            return null;
        }

        public bool reservar(int codAloj, string dniUsuario, DateTime Fdesde, DateTime Fhasta)
        {
            //PENDIENTE

            return false;
        }

        public bool modificarReserva(int ID, DateTime FDesde, DateTime FHasta, Alojamiento propiedad, Usuario persona, float precio)//Parametro Datos de Reserva ¿?
        {
            bool modificada = false;
            //PENDIENTE

            return modificada;
        }

        public bool eliminarReserva(int id)
        {
            //PENDIENTE

        }
    }
}
