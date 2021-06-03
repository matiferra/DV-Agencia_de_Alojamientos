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

        public DataTable getCiudades()
        {

            return ciudades.getCiudades();
        }
 


        public DataSet buscarAlojamientos(string Ciudad, string Pdesde, string Phasta, string cantPersonas, string tipo )
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

        public DataSet obtenerAlojamientos()
        {
            DataSet ds = aloDA.getAlojamientos();
            return ds;        
        }

        public bool agregarAlojamiento(string tipo, string ciudad, string barrio, string estrellas, string cantPersonas, bool tv,string precio, string habitaciones, string banios) //Parametro Datos del Alojamiento ¿?
        {
            bool result;   
            try
            {
                if (tipo == "Hotel")
                {
                    aloDA.createAlojamiento(barrio, int.Parse(estrellas), int.Parse(cantPersonas),tv,true, ciudad, null, null, double.Parse(precio), null);
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

                    //    agregarAlojamiento(codigo, ciudad, barrio, estrellas, cantPersonas, tv, precioxDia, habitaciones, banios);

                    }

                }
            }

            return true;
        }

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
                if (item.DNI == DNI)
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
                    if (user.intentosLogueo >= 3)
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
                    if (oldPass == item.password)
                    {
                        if (newPass1 == newPass2)
                        {
                            item.password = newPass1;
                            cambiada = 3;
                        }
                        else
                        {
                            cambiada = 2;
                        }
                    }
                    else
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
                if (item.DNI == DNI)
                {
                    user = item;
                }
            }

            return user;
        }

        public bool login(string usuario, string pass)
        {
            return usuarioDA.login(usuario, pass);
        }
        public bool validoSiEsAdmin(string usuario)
        {
            return usuarioDA.validoSiEsAdmin(usuario);
        }


    }
}
