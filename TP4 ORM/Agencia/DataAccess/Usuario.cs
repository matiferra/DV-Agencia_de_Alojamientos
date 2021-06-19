using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Entidades;

namespace DataAccess
{

    public class Usuario
    {
        public int id { get; set; }
        public int DNI { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public bool esAdmin { get; set; }
        public bool bloqueado { get; set; }
        public int intentosLogueo { get; set; }

        public Usuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            DNI = Dni;
            nombre = Nombre;
            mail = Mail;
            password = Password;
            esAdmin = EsADM;
            bloqueado = Bloqueado;
        }

    }
}
