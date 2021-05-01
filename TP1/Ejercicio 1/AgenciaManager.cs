using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class AgenciaManager
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
            List<List<string>> lista = null;

            return lista;
        }

        public bool agregarAlojamiento(Alojamiento a) //Parametro Datos del Alojamiento ¿?
        {
            bool agregado = false;

            return agregado;
        }

        public bool modificarAlojamiento(Alojamiento a)//Parametro Datos del Alojamiento ¿?
        {
            bool modificado = false;

            return modificado;
        }

        public bool quitarAlojamiento(int codigo)
        {
            bool eliminado = false;

            return eliminado;
        }

        public List<List<string>> buscarReservas(int DNIusuario)
        {
            List<List<string>> lista = null;

            return lista;
        }

        public bool reservar(int codAloj, int dniUsuario, DateTime Fdesde, DateTime Fhasta)
        {
            bool reservado = false;

            return reservado;
        }

        public bool modificarReserva(Reserva r)//Parametro Datos de Reserva ¿?
        {
            bool modificada = false;

            return modificada;
        }

        public bool eliminarReserva(int codigo)
        {
            bool modificada = false;

            return modificada;
        }

        public bool autenticarUsuario(int DNI, string password)
        {
            bool autenticado = false;

            return autenticado;
        }

        public bool desbloquearUsuario(int DNI)
        {
            bool desbloqueado = false;

            return desbloqueado;
        }

        public bool agregarUsuario(Usuario a) //Parametro Datos del Usuario ¿?
        {
            bool agregado = false;

            return agregado;
        }

        public bool modificarUsuario(Usuario a) //Parametro Datos del Usuario ¿?
        {
            bool modificado = false;

            return modificado;
        }

        public bool eliminarUsuario(int DNI) 
        {
            bool eliminado = false;

            return eliminado;
        }

    }
}
