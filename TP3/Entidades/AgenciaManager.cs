using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades
{
    public class AgenciaManager
    {
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

    }
}
