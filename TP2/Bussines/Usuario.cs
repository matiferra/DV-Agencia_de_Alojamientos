using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
    public class Usuario
    {
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public bool esAdmin { get; set; }
        public bool bloqueado { get; set; }

        public Usuario()
        {
        }
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
