using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
    public class AgenciaManager
    {



        private Agencia miAgencia { set; get; }
        public List<Usuario> misUsuarios;
        public List<Reserva> misReservas;


        public AgenciaManager() { }

        public AgenciaManager(Agencia miAgencia)
        {
            this.miAgencia = miAgencia;
            misUsuarios = new List<Usuario>();
            misReservas = new List<Reserva>();

        }

        public List<List<string>> buscarAlojamientos(string Ciudad, DateTime Pdesde, DateTime Phasta, int cantPersonas, string tipo)
        {
            List<List<string>> lista = new List<List<string>>();

            tipo.ToUpper();

            List<string> alojamientos = new List<string>();

            foreach (var item in miAgencia.misAlojamientos)
            {
                if (tipo == "HOTEL" && item is Hotel)
                {
                    Hotel hotel = (Hotel)item;
                    alojamientos.Add("HOTEL: \nciudad: " + hotel.ciudad +
                        "\nbarrio: " + hotel.barrio +
                        "\nestellas: " + hotel.estrellas +
                        "\ncantidad de personas: " + hotel.cantPersonas +
                        "\nPrecio por persona: " + hotel.getPrecio());
                }

                if (tipo == "CABANIA" && item is Cabania)
                {
                    Cabania cabania = (Cabania)item;
                    alojamientos.Add("CABAÑA \nciudad: " + cabania.ciudad +
                        "\nbarrio: " + cabania.barrio +
                        "\nestellas: " + cabania.estrellas +
                        "\ncantidad de personas: " + cabania.cantPersonas +
                        "\nTV: " + cabania.tv +
                        "\nPrecio por dia: " + cabania.getPrecio() +
                        "\nhabitaciones: " + cabania.habitaciones +
                        "\nbaños: " + cabania.getPrecio());
                }

            }


            lista.Add(alojamientos);


            return lista;
        }

        public bool agregarAlojamiento(int codigoInstancia, string ciudad, string barrio, string estrellas, int cantPersonas, bool tv, double precioxDia = 0, int habitaciones = 0, int banios = 0, double precioxPersona = 0) //Parametro Datos del Alojamiento ¿?
        {
            if (precioxDia != 0)
            {
                miAgencia.misAlojamientos.Add(new Cabania(ciudad, barrio, estrellas, cantPersonas, tv, precioxDia, habitaciones, banios));
            }
            else if (precioxPersona != 0)
            {
                miAgencia.misAlojamientos.Add(new Hotel(ciudad, barrio, estrellas, cantPersonas, tv, precioxPersona));
            }

            return true;
        }

        public bool modificarAlojamiento(int codigoInstancia, string ciudad, string barrio, string estrellas, int cantPersonas, bool tv, double precioxDia = 0, int habitaciones = 0, int banios = 0, double precioxPersona = 0)//Parametro Datos del Alojamiento ¿?
        {
            for (int i = 0; i < miAgencia.misAlojamientos.Count; i++)
            {
                if (codigoInstancia == miAgencia.misAlojamientos[i].codigoInstancia)
                {
                    if (miAgencia.misAlojamientos[i] is Hotel)
                    {
                        Hotel hotel = new Hotel(ciudad, barrio, estrellas, cantPersonas, tv, precioxPersona);

                        hotel.codigoInstancia = miAgencia.misAlojamientos[i].codigoInstancia;

                        miAgencia.misAlojamientos[i] = hotel;

                    }
                    if (miAgencia.misAlojamientos[i] is Cabania)
                    {
                        int codigo = miAgencia.misAlojamientos[i].codigoInstancia;

                        // COMO SERIA UN UPDATE EN BASE DE DATOS
                        quitarAlojamiento(codigo);

                        agregarAlojamiento(codigo, ciudad, barrio, estrellas, cantPersonas, tv, precioxDia, habitaciones, banios);

                    }

                }
            }

            return true;
        }

        public bool quitarAlojamiento(int codigo)
        {
            bool eliminado = false;

            foreach (var item in miAgencia.misAlojamientos)
            {
                if (item.codigoInstancia == codigo)
                {
                    miAgencia.misAlojamientos.Remove(item);
                    eliminado = true;

                }
            }

            return eliminado;
        }

        public List<List<string>> buscarReservas(int DNIusuario)
        {
            List<List<string>> lista = null;

            return lista;
        }

        public bool reservar(int codAloj, string dniUsuario, DateTime Fdesde, DateTime Fhasta)
        {
            bool reservado = true;
            Usuario usuario = null;
            Alojamiento alojamiento = null;
            float precio = 0;

            TimeSpan difFechas = Fhasta - Fdesde;
            int dias = difFechas.Days;

            foreach (var item in misUsuarios)
            {
                if (item.DNI == dniUsuario)
                {
                    usuario = item;
                }
            }

            foreach (var item in miAgencia.misAlojamientos)
            {
                if (item.codigoInstancia == codAloj)
                {
                    alojamiento = item;
                }
            }

            if (alojamiento is Hotel)
            {
                Hotel hotel = (Hotel)alojamiento;

                double precioHotel = hotel.getPrecio() * hotel.cantPersonas * dias;

                precio = (float)precioHotel;
            }

            if (alojamiento is Cabania)
            {
                Cabania cabania = (Cabania)alojamiento;

                double precioCabania = cabania.getPrecio() * dias;

                precio = (float)precioCabania;
            }

            try
            {
                Reserva reserva = new Reserva(Fdesde, Fhasta, alojamiento, usuario, precio);
                misReservas.Add(reserva);

            }
            catch (Exception e)
            {
                reservado = false;
            }

            return reservado;
        }

        public bool modificarReserva(int ID, DateTime FDesde, DateTime FHasta, Alojamiento propiedad, Usuario persona, float precio)//Parametro Datos de Reserva ¿?
        {
            bool modificada = false;

            foreach (var item in misReservas)
            {
                if (item.ID == ID)
                {
                    int codigo = item.ID;

                    eliminarReserva(codigo);

                    Reserva r = new Reserva(FDesde, FHasta, propiedad, persona, precio);

                    r.ID = codigo;

                    misReservas.Add(r);

                    modificada = true;

                }
            }

            return modificada;
        }

        public bool eliminarReserva(int codigo)
        {
            bool eliminada = false;

            foreach (var item in misReservas)
            {
                if (item.ID == codigo)
                {
                    misReservas.Remove(item);
                    eliminada = true;
                }
            }

            return eliminada;
        }

        public bool autenticarUsuario(string DNI, string password)
        {
            Usuario user = null;
            foreach (var item in misUsuarios)
            {
                if(item.DNI == DNI)
                {
                    user = item;
                }
            }

            bool autenticado = false;

            foreach (var item in misUsuarios)
            {

                if (DNI == item.DNI && password == item.password)
                {
                    autenticado = true;
                }
                else
                {
                    user.intentosLogueo++;
                    if(user.intentosLogueo >= 3)
                    {
                        user.bloqueado = true;
                    }
                    autenticado = false;
                }
            }

            return autenticado;
        }

        public bool desbloquearUsuario(string DNI)
        {
            bool desbloqueado = false;

            foreach (var item in misUsuarios)
            {
                if (item.DNI == DNI)
                {
                    if (item.bloqueado)
                    {
                        item.bloqueado = false;
                        desbloqueado = true;
                        item.intentosLogueo = 0;
                    }
                }
            }

            return desbloqueado;
        }

        public bool agregarUsuario(string DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado) //Parametro Datos del Usuario ¿?
        {
            Usuario usuario = new Usuario(DNI, nombre, mail, password, esAdmin, bloqueado);

            misUsuarios.Add(usuario);

            return true;
        }

        public bool modificarUsuario(int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado) //Parametro Datos del Usuario ¿?
        {
            bool modificado = false;

            return modificado;
        }

        public bool eliminarUsuario(string DNI)
        {
            bool eliminado = false;

            foreach (var item in misUsuarios)
            {
                if (item.DNI == DNI)
                {
                    misUsuarios.Remove(item);
                    eliminado = true;
                }
            }

            return eliminado;
        }

        public int cambiarContrasenia(string DNI, string oldPass, string newPass1, string newPass2)
        {

            //1 = MAL PASS VIEJO
            //2 = MAL PASS NUEVO
            //3 = CAMBIADA

            int cambiada = 0;

            foreach (var item in misUsuarios)
            {
                if (item.DNI == DNI)
                {
                    if(oldPass == item.password)
                    {
                        if(newPass1 == newPass2){
                            item.password = newPass1;
                            cambiada = 3;
                        } else
                        {
                            cambiada = 2;
                        }
                    } else
                    {
                        cambiada = 1;
                    }
                }
            }

            return cambiada;
        }


        public Usuario buscarUsuario(string DNI)
        {
            Usuario user = null;

            foreach (var item in misUsuarios)
            {
                if(item.DNI == DNI)
                {
                    user = item;
                }
            }

            return user;
        }

    }
}
