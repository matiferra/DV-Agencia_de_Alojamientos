using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Usuario
    {
        private int DNI { get; set; }
        private string nombre{ get; set; }
        private string mail{ get; set; }
        private string password { get; set; }
        private bool esAdmin { get; set; }
        private bool bloqueado { get; set; }

        public Usuario()
            { }
        public Usuario(int DNI, string nombre, string mail, string password, bool esAdmin, bool bloqueado)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.mail = mail;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = bloqueado;
        }
    }
}
