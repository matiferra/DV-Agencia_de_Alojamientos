using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Bussines
{


    public class AgenciaManager
    {
        private DbSet<Entities.Usuario> misUsuarios;
        private DbSet<Entities.Alojamiento> alojamientos;
        private DbSet<Entities.Reserva> reservas;
        private DbSet<Entities.Ciudades> ciudades;
        private MyContext contexto;

        public AgenciaManager()
        {
            inicializarAtributos();
        }



        private void inicializarAtributos()
        {
            try
            {
                contexto = new MyContext();

                contexto.Usuario.Load();
                contexto.Alojamiento.Load();
                contexto.Reserva.Load();
                contexto.Ciudades.Load();

                misUsuarios = contexto.Usuario;
                alojamientos = contexto.Alojamiento;
                reservas = contexto.Reserva;
                ciudades = contexto.Ciudades;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        // ----------------------- METODOS ALOJAMIENTOS -----------------------

        //public List<List<string>> obtenerAlojamientos(string ciudad)
        //{
        //    var query = from alojamientosDB in alojamientos
        //                select alojamientosDB;


        //    List<List<string>> alojamientos = new List<List<string>>();
        //    foreach (Usuario u in query)
        //        alojamientos.Add(new List<string> { u.DNI.ToString(), u.nombre, u.mail, u.pass, u.esAdmin.ToString(), u.bloqueado.ToString(), u.intentosLogueo.ToString() });
        //    return alojamientos;

        //    return null;
        //}

        public List<List<string>> obtenerAlojamientos()
        {
            List<List<string>> salida = new List<List<string>>();
            /* var query = from alojamiento in alojamientos
                         select alojamineto

             if(query != null)
              {
                  foreach (Entities.Alojamiento u in query)
                  {
                      salida.Add(new List<string> {null, null, u.id.ToString(), u.barrio, u.estrellas.ToString(), u.cantidadDePersonas.ToString(),
                                                u.tv.ToString(), u.esHotel.ToString(), u.id_ciudad.ToString(),u.cantidad_de_habitaciones.ToString(),
                                                u.precio_por_dia.ToString(), u.precio_por_persona.ToString(), u.cantidadDeBanios.ToString()});
                  }
              }
             */
            if (alojamientos.Count() > 0 || alojamientos != null)
            {
                foreach (Entities.Alojamiento u in alojamientos)
                    salida.Add(new List<string> {null, null, u.id.ToString(), u.barrio, u.estrellas.ToString(), u.cantidadDePersonas.ToString(),
                                              u.tv.ToString(), u.esHotel.ToString(), u.ciudad.nombre.ToString(),u.cantidad_de_habitaciones.ToString(),
                                              u.precio_por_dia.ToString(), u.precio_por_persona.ToString(), u.cantidadDeBanios.ToString()});
            }

            return salida;
        }

        public List<List<string>> buscarAlojamientos(string Ciudad, string Pdesde, string Phasta, string cantPersonas, string tipo, string fDesde, string fHasta)
        {

            List<List<string>> resultadoBusqueda = new List<List<string>>();

            List<Entities.Alojamiento> alojamientosFiltrados = new List<Entities.Alojamiento>();

            var queryReservas = from reserva in reservas
                                select reserva;

            List<List<string>> alojamientosReservados = new List<List<string>>();

            if (string.IsNullOrEmpty(cantPersonas))
            {
                cantPersonas = "0";
            }



            //REVISAR


            /*if(tipo == "Hotel")
            {
                queryLala = queryLala.where(d=> d.precio_por_persona == double.Parse(Phasta))
            }
            if (tipo == "cabania")
            {
            }                queryLala = queryLala.where(d => d.precio_por_dia == double.Parse(Phasta))
            */

            IEnumerable<Entities.Alojamiento> queryAlojamientos = null;


            if (tipo == "Hotel")
            {
                queryAlojamientos = from alojamiento in alojamientos
                                    where alojamiento.precio_por_persona <= double.Parse(Phasta)
                                    && alojamiento.precio_por_persona >= double.Parse(Pdesde)
                                    && alojamiento.cantidadDePersonas >= int.Parse(cantPersonas)
                                    && alojamiento.esHotel == true
                                    select alojamiento;
            }
            else
            {
                queryAlojamientos = from alojamiento in alojamientos
                                    where alojamiento.precio_por_dia <= double.Parse(Phasta)
                                    && alojamiento.precio_por_dia >= double.Parse(Pdesde)
                                    && alojamiento.cantidadDePersonas >= int.Parse(cantPersonas)
                                    && alojamiento.esHotel == false
                                    select alojamiento;
            }



            /* var queryAlojamientos = from alojamiento in alojamientos
                                    where alojamiento.precio_por_persona <= double.Parse(Phasta)
                                    && alojamiento.precio_por_persona >= double.Parse(Pdesde)
                                    && alojamiento.precio_por_dia <= double.Parse(Phasta)
                                    && alojamiento.precio_por_dia >= double.Parse(Pdesde)
                                    && alojamiento.cantidadDePersonas >= int.Parse(cantPersonas)
                                    select alojamiento;
            */
            //var estan = queryLala.Where(x => x.precio_por_dia == 0);


            //if (Phasta != null)
            //{
            //    queryAlojamientos = queryAlojamientos.Where(d => d.precio_por_persona == Phasta);
            //}



            foreach (Entities.Alojamiento a in queryAlojamientos)
            {
                alojamientosFiltrados.Add(a);
            }

            foreach (Entities.Alojamiento u in alojamientosFiltrados.ToList())
            {
                foreach (Entities.Reserva r in queryReservas)
                {
                    if (u.id == r.id_alojamiento.id)
                    {
                        alojamientosReservados.Add(new List<string> { u.id.ToString(), r.FDesde.ToString(), r.FHasta.ToString() });
                        alojamientosFiltrados.Remove(u);
                    }
                }
            }

            foreach (List<string> alojamiento in alojamientosReservados.ToList())
            {

                if (DateTime.Parse(fDesde) >= DateTime.Parse(alojamiento.ElementAt(1)) && DateTime.Parse(fHasta) <= DateTime.Parse(alojamiento.ElementAt(2)))
                {
                    //X ------------------- ENTRE FECHAS
                    alojamientosReservados.Remove(alojamiento);
                }
                if (DateTime.Parse(fHasta) >= DateTime.Parse(alojamiento.ElementAt(1)) && DateTime.Parse(fHasta) <= DateTime.Parse(alojamiento.ElementAt(2)))
                {
                    //X -------------------COMIENZO y ENTRE FECHAS
                    alojamientosReservados.Remove(alojamiento);
                }
                if (DateTime.Parse(fDesde) <= DateTime.Parse(alojamiento.ElementAt(1)) && DateTime.Parse(fDesde) >= DateTime.Parse(alojamiento.ElementAt(1)) && DateTime.Parse(fHasta) <= DateTime.Parse(alojamiento.ElementAt(2)) && DateTime.Parse(fDesde) >= DateTime.Parse(alojamiento.ElementAt(1)))
                {
                    //COMIENTO ANTERIOS y ENTRE FECHAS y FIN DESPUES
                    alojamientosReservados.Remove(alojamiento);
                }
                if (DateTime.Parse(fDesde) >= DateTime.Parse(alojamiento.ElementAt(1)) && DateTime.Parse(fDesde) <= DateTime.Parse(alojamiento.ElementAt(2)))
                {
                    //ENTRE FECHAS y FIN
                    alojamientosReservados.Remove(alojamiento);
                }
               

            }


            foreach (Entities.Alojamiento alojamiento in alojamientosFiltrados.ToList())
            {
                resultadoBusqueda.Add(new List<string>{ "", alojamiento.barrio, alojamiento.estrellas, alojamiento.cantidadDePersonas.ToString(),
                alojamiento.tv.ToString(), alojamiento.ciudad.nombre.ToString(), alojamiento.cantidad_de_habitaciones.ToString(),
                alojamiento.precio_por_dia.ToString(),  alojamiento.precio_por_persona.ToString(),
                alojamiento.cantidadDeBanios.ToString(),alojamiento.id.ToString()});
            }


            foreach (List<string> aloja in alojamientosReservados.ToList())
            {

                Entities.Alojamiento alojamiento = buscarAlojamientoxID(int.Parse(aloja.ElementAt(0)));

                resultadoBusqueda.Add(new List<string>{ "", alojamiento.barrio, alojamiento.estrellas, alojamiento.cantidadDePersonas.ToString(),
                alojamiento.tv.ToString(), alojamiento.ciudad.nombre.ToString(), alojamiento.cantidad_de_habitaciones.ToString(),
                alojamiento.precio_por_dia.ToString(),  alojamiento.precio_por_persona.ToString(),
                alojamiento.cantidadDeBanios.ToString(),alojamiento.id.ToString()});
            }

            return resultadoBusqueda;

        }

        public List<Entities.Ciudades> getCiudades()
        {
            var ciudades = contexto.Ciudades.ToList();
            return ciudades;
        }

        public Entities.Ciudades getCiudadesxID(int id)
        {
            Entities.Ciudades ciudad = new Entities.Ciudades();

            var query = from ciudadDB in ciudades
                        where ciudadDB.id == id
                        select ciudadDB;

            ciudad = query.FirstOrDefault();

            return ciudad;
        }


        public bool agregarAlojamiento(string tipo, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv, string precio, string habitaciones, string banios) //Parametro Datos del Alojamiento ¿?
        {
            bool result;

            Entities.Ciudades ciudadObjeto =new Entities.Ciudades();
            ciudadObjeto = getCiudadesxID(int.Parse(ciudad));
            try
            {
                if (tipo == "Hotel")
                {
                    Entities.Alojamiento Alojamiento = new Entities.Alojamiento(
                    barrio, estrellas, int.Parse(cantPersonas), tv, ciudadObjeto, 0,
                    0, double.Parse(precio), 1, true);
                    alojamientos.Add(Alojamiento);
                    contexto.SaveChanges();
                }
                else
                {
                    Entities.Alojamiento Alojamiento = new Entities.Alojamiento(
                    barrio, estrellas, int.Parse(cantPersonas), tv, ciudadObjeto, int.Parse(habitaciones),
                    double.Parse(precio), 0, int.Parse(banios), false);
                    alojamientos.Add(Alojamiento);
                    contexto.SaveChanges();
                }
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public Entities.Alojamiento buscarAlojamientoxID(int codigo)
        {

            var query = from alojamientoDB in alojamientos
                        where alojamientoDB.id == codigo
                        select alojamientoDB;

            Entities.Alojamiento alojamiento = query.FirstOrDefault();


            return alojamiento;
        }
        public bool modificarAlojamiento(string codigoInstancia, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv, string precioxDia,
                                         string habitaciones, string banios, string precioxPersona)
        {

            Entities.Ciudades ciudadObjeto = getCiudadesxID(int.Parse(ciudad));

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
                var alojamiento = contexto.Alojamiento.Find(int.Parse(codigoInstancia));
                alojamiento.ciudad = ciudadObjeto;
                alojamiento.barrio = barrio;
                alojamiento.estrellas = estrellas;
                alojamiento.tv = tv;

                if (alojamiento.esHotel == true)
                {
                    alojamiento.precio_por_persona = int.Parse(precioxPersona);
                }
                else
                {
                    alojamiento.cantidadDeBanios = int.Parse(banios);
                    alojamiento.precio_por_dia = double.Parse(precioxDia);
                    alojamiento.cantidad_de_habitaciones = int.Parse(habitaciones);
                }

                contexto.Alojamiento.Update(alojamiento);
                contexto.SaveChanges();
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
            bool result = false;

            var query = from alojamiento in alojamientos
                        where alojamiento.id == codigo
                        select alojamiento;

            if (query != null)
            {
                Entities.Alojamiento alojamiento = query.FirstOrDefault();

                contexto.Alojamiento.Remove(alojamiento);
                contexto.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }


        // ----------------------- METODOS RESERVAS -----------------------
        //public List<List<string>> buscarReservas(string dni, string fdesde, string fhasta)

        //{
        //    List<List<string>> resultado = new List<List<string>>();
        //    var query = from reservaDB in reservas
        //                where reservaDB.usuario.DNI == dni
        //                && reservaDB.FDesde >= DateTime.Parse(fdesde)
        //                && reservaDB.FHasta <= DateTime.Parse(fhasta)
        //                select reservaDB;
        //    foreach (Entities.Reserva reservas in query)
        //    {
        //        resultado.Add(new List<string> { reservas.FDesde.ToString(), reservas.FHasta.ToString(),
        //            reservas.tipoAlojamiento.nombre, reservas.usuario.DNI.ToString(), reservas.precio.ToString()});
        //    }
        //    return resultado;
        //}

        public List<List<string>> getTodasLasReservasCliente()
        {
            List<List<string>> resultado = new List<List<string>>();
            var query = from reservaDB in reservas
                        select reservaDB;
            foreach (Entities.Reserva reservas in query)
            {
                resultado.Add(new List<string> { "", reservas.FDesde.ToString(), reservas.FHasta.ToString(),
                    reservas.id_alojamiento.ciudad.nombre.ToString(), reservas.precio.ToString(), reservas.id_alojamiento.id.ToString(), reservas.id.ToString()});
            }
            return resultado;
        }
        
            public List<List<string>> getTodasLasReservas()
        {
            List<List<string>> resultado = new List<List<string>>();
            var query = from reservaDB in reservas
                        select reservaDB;
            foreach (Entities.Reserva reservas in query)
            {
                resultado.Add(new List<string> { "", "", reservas.id_usuario.nombre.ToString(),
                    reservas.FDesde.ToString(), reservas.FHasta.ToString(),
                    reservas.precio.ToString(), reservas.id_alojamiento.id.ToString(), reservas.id.ToString()});
            }
            return resultado;
        }
        public List<List<string>> getTodasLasReservasxCiudad(string ciudad)
        {
            List<List<string>> resultado = new List<List<string>>();
            var query = from reservaDB in reservas
                        where reservaDB.id_alojamiento.ciudad.nombre == ciudad
                        select reservaDB;
            foreach (Entities.Reserva reservas in query)
            {
                resultado.Add(new List<string> { "", "", reservas.id_usuario.nombre.ToString(),
                    reservas.FDesde.ToString(), reservas.FHasta.ToString(),
                    reservas.precio.ToString(), reservas.id_alojamiento.id.ToString(), reservas.id.ToString()});
            }
            return resultado;
        }

        //public List<List<string>> getReservasPorCliente(String dni)
        //{
        //    List<List<string>> resultado = new List<List<string>>();
        //    var query = from reservaDB in reservas
        //                where reservaDB.usuario.DNI == dni
        //                select reservaDB;
        //    foreach (Entities.Reserva reservas in query)
        //    {
        //        resultado.Add(new List<string> { reservas.FDesde.ToString(), reservas.FHasta.ToString(),
        //            reservas.tipoAlojamiento.nombre, reservas.usuario.DNI.ToString(), reservas.precio.ToString()});
        //    }
        //    return resultado;
        //}

        public bool reservar(int codAloj, string dniUsuario, DateTime Fdesde, DateTime Fhasta)
        {
            Entities.Usuario usuario = new Entities.Usuario();
            usuario = buscarUsuarioxDNI(int.Parse(dniUsuario));

            bool result = false;

            var queryAlojamiento = from alojamientoDB in alojamientos
                                   where alojamientoDB.id == codAloj
                                   select alojamientoDB;

            if (queryAlojamiento != null)
            {
                Entities.Alojamiento alojamiento = queryAlojamiento.FirstOrDefault();

                if (alojamiento != null)
                {
                    Entities.Reserva reservita = new Entities.Reserva();
                    reservita.FDesde = Fdesde;
                    reservita.FHasta = Fhasta;
                    reservita.id_usuario = usuario;
                    reservita.id_alojamiento = alojamiento;


                    contexto.Reserva.Add(reservita);
                    contexto.SaveChanges();
                    result = true;
                }

                else
                {
                    result = false;
                }

            }
            return result;
        }

        public bool modificarReserva(int ID, DateTime FDesde, DateTime FHasta, Entities.Alojamiento propiedad, Entities.Usuario persona, float precio)//Parametro Datos de Reserva ¿?
        {
            bool modificada = false;
            var query = from reservaDB in reservas
                        where reservaDB.id == ID
                        select reservaDB;
            Entities.Reserva reserva = query.FirstOrDefault();
            if (reserva != null)
            {
            }
            return modificada;
        }


        public bool eliminarReserva(int id)
        {
            bool result = false;
            var query = from reservaDB in reservas
                        where reservaDB.id == id
                        select reservaDB;
            if (query != null)
            {
                Entities.Reserva reserva = query.FirstOrDefault();
                if (reserva != null)
                {
                    contexto.Reserva.Remove(reserva);
                    contexto.SaveChanges();
                    result = true;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        // ----------------------- METODOS USUARIOS -----------------------

        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> salida = new List<List<string>>();

            foreach (Entities.Usuario u in misUsuarios)
                salida.Add(new List<string> { null, null, null, u.DNI.ToString(), u.mail, u.bloqueado.ToString(), u.nombre, u.esAdmin.ToString(), u.pass, u.id.ToString() });
            return salida;
        }

        public List<List<string>> obtenerUsuarios(string dni)
        {

            List<List<string>> salida = new List<List<string>>();
            var query = (from user in misUsuarios
                         select user);
            if (!string.IsNullOrEmpty(dni))
            {
                query = query.Where(d => d.DNI == int.Parse(dni));
            }


            foreach (Entities.Usuario u in query)
                salida.Add(new List<string> { null, null, null, u.DNI.ToString(), u.mail, u.bloqueado.ToString(), u.nombre, u.esAdmin.ToString(), u.pass, u.id.ToString() });
            return salida;
        }

        public List<string> buscarUsuarioxNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "";
            }

            var query = from usuarioDB in misUsuarios
                        where usuarioDB.nombre == nombre
                        select usuarioDB;

            List<string> usuario = new List<string>();

            foreach (Entities.Usuario u in query)
            {
                usuario.Add(u.DNI.ToString());
                usuario.Add(u.nombre);
                usuario.Add(u.mail);
                usuario.Add(u.pass.ToString());
                usuario.Add(u.esAdmin.ToString());
                usuario.Add(u.bloqueado.ToString());
                usuario.Add(u.intentosLogueo.ToString());
            }

            return usuario;
        }

        public Entities.Usuario buscarUsuarioxDNI(int dni)
        {
            var query = from usuarioDB in misUsuarios
                        where usuarioDB.DNI == dni
                        select usuarioDB;

            Entities.Usuario usuario = null;

            if (query != null)
            {
                usuario = query.FirstOrDefault();
            }

            return usuario;
        }

        public bool agregarUsuario(int DNI, string nombre, string mail, string pass, bool esAdmin, bool bloqueado)
        {

            try
            {
                Entities.Usuario usuario = new Entities.Usuario(DNI, nombre, mail, pass, esAdmin, bloqueado);
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
            bool respuesta = false;
            foreach (Entities.Usuario u in contexto.Usuario)
            {
                if (u.DNI == dni)
                {
                    u.nombre = nombre;
                    u.mail = mail;
                    u.pass = pass;
                    u.esAdmin = esAdmin;
                    u.bloqueado = bloqueado;
                    contexto.Usuario.Update(u);
                    respuesta = true;
                }
            }
            if (respuesta)
            {
                contexto.SaveChanges();
            }
            return respuesta;
        }

        public bool eliminarUsuario(int id)
        {
            bool respuesta = false;

            try
            {
                var usuario = contexto.Usuario.Find(id);
                contexto.Usuario.Remove(usuario);
                contexto.SaveChanges();
                respuesta = true;

                return respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool autenticar(string nombre, string password)
        {
            bool respuesta = false;
            var query = from usuarioDB in misUsuarios
                        where usuarioDB.nombre == nombre
                        select usuarioDB;

            if (misUsuarios != null)
            {
                foreach (Entities.Usuario u in query)
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

            return respuesta;
        }


        public bool desbloquearUsuario(int id, bool valido)
        {
            bool desbloqueado = false;

            if (valido == true)
            {
                var usuario = contexto.Usuario.Find(id);
                usuario.bloqueado = false;
                contexto.Usuario.Update(usuario);
                contexto.SaveChanges();
                desbloqueado = true;
            }

            return desbloqueado;
        }

        public int recuperoDni(string usuario, string contrasenia)
        {

            // SE USA EN LA VIEW DE CAMBAIR CONTRASEÑA

            int resultado = 0;
            var query = (from usuarioDB in misUsuarios
                         where usuarioDB.nombre == usuario && usuarioDB.pass == contrasenia
                         select usuarioDB).FirstOrDefault();

            resultado = query.DNI;
            return resultado;
        }


        public string cambiarContrasenia(int DNI, string oldPass, string newPass1, string newPass2)
        {

            //REVISAR EL FOREACH

            bool respuesta = false;
            string mensaje = "";
            var query = from usuario in misUsuarios
                        where usuario.DNI == DNI
                        select usuario;

            //Usuario asd = query.First<>; ALA LA LA

            foreach (Entities.Usuario u in query)
            {
                if (u.pass == oldPass)
                {
                    if (newPass1 == newPass2)
                    {
                        u.pass = newPass1;
                        contexto.Usuario.Update(u);
                        respuesta = true;
                        mensaje = "La contraseña ha sido modificada con exito";

                    }
                    else
                    {
                        mensaje = "Las contraseñas ingresadas no coinciden ";
                    }
                }
                else
                {
                    mensaje = "La contraseña ingresada es incorrecta ";
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
