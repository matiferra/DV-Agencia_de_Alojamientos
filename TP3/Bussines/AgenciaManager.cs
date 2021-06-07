using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccess;

namespace Bussines
{
    public class AgenciaManager
    {

        AlojamientoDA aloDA = new AlojamientoDA();
        UsuarioDA usuarioDA = new UsuarioDA();
        CiudadesDA ciudades = new CiudadesDA();
        ReservaDA reservasDA = new ReservaDA();


        public Agencia miAgencia { set; get; }
        public List<Usuario> misUsuarios;
        public List<Reserva> misReservas;


        public AgenciaManager() { }

        public AgenciaManager(Agencia miAgencia)
        {
            this.miAgencia = miAgencia;
            misUsuarios = new List<Usuario>();
            misReservas = new List<Reserva>();

        }
        /// <summary>
        /// recupero todos las las ciudades
        /// </summary>
        /// <returns></returns>
        public DataTable getCiudades()
        {

            return ciudades.getCiudades();
        }

        /// <summary>
        /// recupero todos los alojamientos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet getAlojamiento(int id)
        {
            DataSet ds = new DataSet();
            return ds = aloDA.getAlojamientos(id);
        }

        /// <summary>
        /// busco Alojamientos por filtros
        /// </summary>
        /// <param name="Ciudad"></param>
        /// <param name="Pdesde"></param>
        /// <param name="Phasta"></param>
        /// <param name="cantPersonas"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        /// 
        public DataSet obtenerAlojamientos(string ciudad)
        {
            return aloDA.getAlojamientosAdmin(ciudad);
        }

        public DataSet buscarAlojamientos(string Ciudad, string Pdesde, string Phasta, string cantPersonas, string tipo)
        {
            bool esHotel;
            DataSet ds = new DataSet();

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
                ds = aloDA.buscoAlojamiento(Pdesde, Phasta, esHotel, cantPersonas, Ciudad);

            }
            catch (Exception ex)
            {
                // mensajeError = "error en buscoAlojamiento" + ex.Message;
            }


            return ds;
        }

        /// <summary>
        /// recupero todos los alojamientos de mi base de datos
        /// </summary>
        /// <returns></returns>
        public DataSet obtenerAlojamientos()
        {
            DataSet ds = aloDA.getAlojamientos();
            return ds;
        }
        /// <summary>
        /// Metodo que me permite agregar alojamientos
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="ciudad"></param>
        /// <param name="barrio"></param>
        /// <param name="estrellas"></param>
        /// <param name="cantPersonas"></param>
        /// <param name="tv"></param>
        /// <param name="precio"></param>
        /// <param name="habitaciones"></param>
        /// <param name="banios"></param>
        /// <returns></returns>
        public bool agregarAlojamiento(string tipo, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv, string precio, string habitaciones, string banios) //Parametro Datos del Alojamiento ¿?
        {
            bool result;
            try
            {
                if (tipo == "Hotel")
                {
                    aloDA.createAlojamiento(barrio, int.Parse(estrellas), int.Parse(cantPersonas), tv, true, ciudad, null, null, double.Parse(precio), null);
                    result = true;
                }
                else
                {
                    aloDA.createAlojamiento(barrio, int.Parse(estrellas), int.Parse(cantPersonas), tv, false, ciudad, int.Parse(habitaciones), double.Parse(precio), null, int.Parse(banios));
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// me permite modificar un alojamiento
        /// </summary>
        /// <param name="codigoInstancia"></param>
        /// <param name="ciudad"></param>
        /// <param name="barrio"></param>
        /// <param name="estrellas"></param>
        /// <param name="cantPersonas"></param>
        /// <param name="tv"></param>
        /// <param name="precioxDia"></param>
        /// <param name="habitaciones"></param>
        /// <param name="banios"></param>
        /// <param name="precioxPersona"></param>
        /// <returns></returns>
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
                aloDA.updateAlojamiento(int.Parse(codigoInstancia), barrio, estrellas, int.Parse(cantPersonas), tv, ciudad, int.Parse(habitaciones),
                                       double.Parse(precioxDia), double.Parse(precioxPersona), int.Parse(banios));
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }



            return result;
        }

        /// <summary>
        /// permite eliminar alojamiento
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public bool quitarAlojamiento(int codigo)
        {
            bool result;
            try
            {
                result = aloDA.deleteAlojamiento(codigo);
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
            return usuarioDA.obtenerUsuarios();
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
            return usuarioDA.obtenerUsuarios(int.Parse(dni));
        }
        public DataSet buscarUsuarioxNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return null;
            }
            return usuarioDA.obtenerUsuariosxNombre(nombre);
        }


        public bool sumarIntentosDeLogeo(int contadorIntentos, string dni)
        {
            return usuarioDA.sumarIntentosDeLogeo(contadorIntentos, dni);
        }

        public bool bloquearUsuario(string dni)
        {
            return usuarioDA.bloquearUsuario(dni);
        }



        /// <summary>
        /// Permite agregar usuario como administardor
        /// </summary>
        /// <param name="DNI"></param>
        /// <param name="nombre"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <param name="esAdmin"></param>
        /// <param name="bloqueado"></param>
        /// <returns></returns>
        public bool agregarUsuario(string DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            bool result;
            try
            {
                usuarioDA.agregarUsuario(int.Parse(DNI), nombre, mail, password, esAdmin, bloqueado);
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// permite modificar el usuario
        /// </summary>
        /// <param name="DNI"></param>
        /// <param name="nombre"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <param name="esAdmin"></param>
        /// <param name="bloqueado"></param>
        /// <returns></returns>
        public bool modificarUsuario(int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            bool result;
            try
            {
                usuarioDA.modificarUsuario(DNI, nombre, mail, password, esAdmin, bloqueado);

                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Permite eliminar usuario por id
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public bool eliminarUsuario(string DNI)
        {
            bool result;
            try
            {
                usuarioDA.eliminarUsuario(int.Parse(DNI));
                result = true;
            }
            catch
            {
                result = false;

            }

            return result;
        }

        /// <summary>
        /// verifica si existe y si son correctas las credenciales del usuario al logearse 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool login(string usuario, string pass)
        {
            return usuarioDA.login(usuario, pass);
        }

        /// <summary>
        /// busca por base si el usuario que esta ingresando es admin o cliente para determinar el form correspondiente
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool validoSiEsAdmin(string usuario)
        {
            return usuarioDA.validoSiEsAdmin(usuario);
        }
        /// <summary>
        /// desbloquear usuario
        /// </summary>
        /// <param name="DNI"></param>
        /// <returns></returns>
        public bool desbloquearUsuario(string DNI)
        {
            bool desbloqueado;
            try
            {
                usuarioDA.desbloquearUsuario(int.Parse(DNI));
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
            DataSet ds = usuarioDA.obtenerUsuarios(usuario, contraseña);
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                resultado = ds.Tables[0].Rows[0]["dni"].ToString();
            }

            return resultado;
        }

        public string cambiarContrasenia(string DNI, string oldPass, string newPass1, string newPass2)
        {
            //completen todos los campos y pulsen guardar
            //recupero contraseña actual de mi dataset
            //macheo si mi contraseña coincide con el campo de contra actual
            //Si es incorrecto mensaje de alerta avisando el asunto.
            //si pasa  lo proximo hacer es machear la contraseña nueva con la reigresar contraseña y verificar si son iguales
            string mensaje = "";
            DataSet ds = usuarioDA.obtenerUsuarios(int.Parse(DNI));

            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                string contrasenia = ds.Tables[0].Rows[0]["pass"].ToString();
                if (contrasenia.Trim() == oldPass.Trim())
                {
                    if (newPass1.Trim() == newPass2.Trim())
                    {
                        usuarioDA.cambiarContraseña(newPass2, int.Parse(DNI));
                        mensaje = "el cambio se ingreso con exito";
                    }
                    else
                    {
                        mensaje = "la nueva contraseña no coincide lo que tipifico en el campo reingrese su contraseña";
                    }
                }
                else
                {
                    mensaje = "la contraseña no coincide con la original";
                }
            }

            return mensaje;
        }



        /*
         pendiente a realizar      
         
         
         */
        public bool autenticarUsuario(string DNI, string password)
        {
            //LO DIVIDI EN DOS PARTES UNA EN EL METODO login Y OTRO validoSiEsAdmin  QUEDA PENDIENTE QUE LO BLOQUEE SI INTENTIO LOGEARSE 3 VECES

            bool autenticado = false;

            return autenticado;
        }


        public DataSet getTodasLasReservas()
        {
            return reservasDA.getTodasLasReservas();
        }
        public DataSet getReservasPorCliente(String dni)
        {
            return reservasDA.getReservasPorCliente(dni);
        }

        



        public DataSet buscarReservas(string dni, string fdesde, string fhasta)
        {
            return reservasDA.buscarReservas(dni, fdesde, fhasta);
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
            return reservasDA.deleteReserva(id);

            //PENDIENTE

        }

    }
}
