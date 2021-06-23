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
        private DbSet<Alojamiento> alojamientos;
        private DbSet<Reserva> reservas;
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
                //contexto.Alojamiento.Load();
                contexto.Reserva.Load();
                misUsuarios = contexto.Usuario;
                //alojamientos = contexto.Alojamiento;
                reservas = contexto.Reserva;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void prueba(int dni)
        {
            var query = from resr in reservas
                        join user in misUsuarios
                        on resr.id_usuario.id equals user.id
                        select new custom
                        {
                            nombreReserva = resr.precio.ToString(),
                            nombreUser = user.nombre

                        };

        }




        // ----------------------- METODOS ALOJAMIENTOS -----------------------

        public List<List<string>> obtenerAlojamientos(string ciudad)
        {
            return null;
        }

        public List<string> obtenerAlojamientos()
        {
            return null;
        }

       /* public List<string> buscarAlojamientos(string Ciudad, string Pdesde, string Phasta, string cantPersonas, string tipo)
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
       */


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


        // ----------------------- METODOS RESERVAS -----------------------
        public List<List<string>> buscarReservas(string dni, string fdesde, string fhasta)
        {
            return null;
        }



        public List<List<string>> getTodasLasReservas()
        {
            return null;
        }
        public List<List<string>> getReservasPorCliente(String dni)
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
            return false;
        }


        // ----------------------- METODOS USUARIOS -----------------------

        /// <summary>
        /// recupero UN usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public List<string> buscarUsuario(string dni)
        {
            List<string> usuario = null;

            if (string.IsNullOrEmpty(dni))
            {
                dni = "0";
            }

            foreach (Usuario u in contexto.Usuario)
            {
                if (dni == u.DNI.ToString())
                {
                    usuario.Add(u.DNI.ToString());
                    usuario.Add(u.nombre);
                    usuario.Add(u.mail);
                    usuario.Add(u.pass.ToString());
                    usuario.Add(u.bloqueado.ToString());
                    usuario.Add(u.intentosLogueo.ToString());
                }
            }

            return usuario;
        }
        public List<string> buscarUsuarioxNombre(string nombre)
        {
            List<string> usuario = new List<string>();

            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "";
            }

            foreach (Usuario u in contexto.Usuario)
            {
                if (nombre == u.nombre)
                {
                    usuario.Add(u.DNI.ToString());
                    usuario.Add(u.nombre);
                    usuario.Add(u.mail);
                    usuario.Add(u.pass.ToString());
                    usuario.Add(u.esAdmin.ToString());
                    usuario.Add(u.bloqueado.ToString());
                    usuario.Add(u.intentosLogueo.ToString());
                  
                }
            }

            return usuario;
        }

        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> usuarios = new List<List<string>>();
            foreach (Usuario u in contexto.Usuario)
                usuarios.Add(new List<string> { u.DNI.ToString(), u.nombre, u.mail, u.pass, u.esAdmin.ToString(), u.bloqueado.ToString(), u.intentosLogueo.ToString() });
            return usuarios;
        }



        public bool bloquearUsuario(string dni)
        {
            bool bloqueado = false;
            foreach (Usuario u in contexto.Usuario)
            {
                if (dni == u.DNI.ToString())
                {
                    if (u.bloqueado == false)
                    {
                        u.bloqueado = true;
                        bloqueado = true;
                    }
                }
            }

            return bloqueado;
        }

        public bool agregarUsuario(int DNI, string nombre, string mail, string pass, bool esAdmin, bool bloqueado)
        {
            try
            {
                Usuario usuario = new Usuario(DNI, nombre,  mail, pass, esAdmin, bloqueado);
                misUsuarios.Add(usuario);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
        public bool modificarUsuario(int dni, string nombre, string mail, string pass, bool esAdmin, bool bloqueado)
        {
            bool salida = false;
            foreach (Usuario u in contexto.Usuario)
                if (u.DNI == dni)
                {
                    u.nombre = nombre;
                    u.mail = mail;
                    u.pass = pass;
                    u.esAdmin = esAdmin;
                    u.bloqueado = bloqueado;
                    contexto.Usuario.Update(u);
                    salida = true;
                }
            if (salida)
            {
                contexto.SaveChanges();
            }
            return salida;
        }

        public Usuario recuperarUsuarioObjeto(int DNI) {
            Usuario user = null;
            int i = 0;

            while (user == null && i < misUsuarios.Count())
            {
                if(DNI == misUsuarios.ElementAt(i).DNI)
                {
                    user = misUsuarios.ElementAt(i);
                }

                i++;
            }
            return user;
        }

        public bool eliminarUsuario(int Dni)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario = recuperarUsuarioObjeto(Dni);
                if(usuario!= null)
                { 
                    contexto.Usuario.Remove(usuario);
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool autenticar(string dni, string password)
        {
            bool respuesta = false;
            if (misUsuarios != null)
            {
                foreach (Usuario u in misUsuarios)
                {
                    if (dni == u.nombre.ToString())
                    {
                        if (password == u.pass)
                        {
                            respuesta = true;
                        }
                        else
                        {
                            u.intentosLogueo++;
                            if (u.intentosLogueo >= 3)
                            {
                                u.bloqueado = true;
                            }
                            contexto.Usuario.Update(u);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("no paso");
            }
           
         
            return respuesta;
       }

      
        public bool desbloquearUsuario(string dni)
        {
            bool desbloqueado = false;
            foreach (Usuario u in contexto.Usuario)
            {
                if (dni == u.DNI.ToString())
                {
                    if (u.bloqueado == true)
                    {
                        u.bloqueado = false;
                        desbloqueado = true;
                    }
                }
            }

            return desbloqueado;
        }

        public int recuperoDni(string usuario, string contrasenia)
        {
            int resultado = 0;

            foreach (Usuario user in misUsuarios)
            {
                if(usuario == user.nombre && contrasenia == user.pass)
                {
                    resultado = user.DNI;
                }
            }
            return resultado;
        }

        public string cambiarContrasenia(int DNI, string oldPass, string newPass1, string newPass2)
        {
            
            bool respuesta = false;
            bool encontrado = false;
            int i = 0;
            
            string mensaje = "";
            while ( encontrado == false && i < misUsuarios.Count())
            {
                Usuario u = misUsuarios.First;
               if (u.DNI == DNI)
                {
                    if(u.pass == oldPass)
                    {
                        if(newPass1 == newPass2)
                        {
                            u.pass = newPass1;
                            contexto.Usuario.Update(u);
                            respuesta = true;
                            mensaje = "La contraseña ha sido modificada con exito";
                        } else {
                            mensaje = "Las contraseñas ingresadas no coinciden ";
                        }
                    }else { 
                        mensaje = "La contraseña ingresada es incorrecta ";
                    } 
                }
            }
            if (respuesta)
            {
                contexto.SaveChanges();
            }

            return mensaje;
        }


        public void cerrar()
        {
            contexto.Dispose();
        }

    }


}
