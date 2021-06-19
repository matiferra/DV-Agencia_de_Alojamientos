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
        private MyContext contexto;
        public List<Usuario> getUsuario()
        {
            using (var con = new MyContext())
            {
                return con.Usuario.ToList();
            }
        }

        private void inicializarAtributos()
        {
            try
            {
                //creo un contexto
                contexto = new MyContext();
                //cargo los usuarios
                contexto.Usuario.Load();
                misUsuarios = contexto.Usuario;
            }
            catch (Exception)
            {

            }
        }

        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> salida = new List<List<string>>();
            foreach (Usuario u in contexto.Usuario)
                salida.Add(new List<string> { u.DNI.ToString(), u.nombre, u.mail, u.password, u.esAdmin.ToString(), u.bloqueado.ToString() });
            return salida;
        }

        public bool agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            try
            {
                Usuario nuevo = new Usuario(Dni, Nombre, Mail, Password, EsADM, Bloqueado);
                //contexto.usuarios.Add(nuevo);
                misUsuarios.Add(nuevo);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
