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
    public class UsuarioDA
    {
        private List<Entidades.Usuario> misUsuarios;

        public UsuarioDA()
        {
            misUsuarios = new List<Entidades.Usuario>();
            inicializarAtributos();
        }

        private void inicializarAtributos()
        {
            //Cargo la cadena de conexión desde el archivo de properties
            string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;

            //Defino el string con la consulta que quiero realizar
            string queryString = "SELECT  dni,nombre,mail,pass,esAdmin,bloqueado  from dbo.Usuarios";

            // Creo una conexión SQL con un Using, de modo que al finalizar, la conexión se cierra y se liberan recursos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Defino el comando a enviar al motor SQL con la consulta y la conexión
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    //Abro la conexión
                    connection.Open();
                    //mi objecto DataReader va a obtener los resultados de la consulta, notar que a comando se le pide ExecuteReader()
                    SqlDataReader reader = command.ExecuteReader();
                    Entidades.Usuario aux;
                    //mientras haya registros/filas en mi DataReader, sigo leyendo
                    while (reader.Read())
                    {
                        aux = new Entidades.Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetBoolean(5));
                        misUsuarios.Add(aux);
                    }
                    //En este punto ya recorrí todas las filas del resultado de la query
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<List<string>> obtenerUsuarios()
        {
            List<List<string>> salida = new List<List<string>>();
            foreach (Entidades.Usuario u in misUsuarios)
                salida.Add(new List<string>() { u.DNI.ToString(), u.nombre, u.mail, u.password, u.esAdmin.ToString(), u.bloqueado.ToString() });
            return salida;
        }

        public bool agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            //primero me aseguro que lo pueda agregar a la base
            int resultadoQuery;
            string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            string queryString = "INSERT INTO [dbo].[Usuarios] ([dni],[nombre],[mail],[pass],[esAdmin],[bloqueado]) VALUES (@dni,@nombre,@mail,@password,@esadm,@bloqueado);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
                command.Parameters["@dni"].Value = Dni;
                command.Parameters["@nombre"].Value = Nombre;
                command.Parameters["@mail"].Value = Mail;
                command.Parameters["@password"].Value = Password;
                command.Parameters["@esadm"].Value = EsADM;
                command.Parameters["@bloqueado"].Value = Bloqueado;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            if (resultadoQuery == 1)
            {
                //Ahora sí lo agrego en la lista
                Entidades.Usuario nuevo = new Entidades.Usuario(Dni.ToString(), Nombre, Mail, Password, EsADM, Bloqueado);
                misUsuarios.Add(nuevo);
                return true;
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

        public bool eliminarUsuario(int Dni)
        {
            //primero me aseguro que lo pueda agregar a la base
            int resultadoQuery;
            string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            string queryString = "DELETE FROM [dbo].[Usuarios] WHERE dni=@dni;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));               
                command.Parameters["@dni"].Value = Dni;             
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            if (resultadoQuery == 1)
            {
                try
                {
                    //Ahora sí lo elimino en la lista
                    for (int i = 0; i < misUsuarios.Count; i++)
                        if (misUsuarios[i].DNI == Dni.ToString())
                            misUsuarios.RemoveAt(i);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

        public bool modificarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            //primero me aseguro que lo pueda agregar a la base
            int resultadoQuery;
            string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            string queryString = "UPDATE [dbo].[Usuarios] SET nombre=@nombre, mail=@mail,Password=@password, esAdmin=@esadm, bloqueado=@bloqueado WHERE DNI=@dni;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
                command.Parameters["@dni"].Value = Dni;
                command.Parameters["@nombre"].Value = Nombre;
                command.Parameters["@mail"].Value = Mail;
                command.Parameters["@password"].Value = Password;
                command.Parameters["@esadm"].Value = EsADM;
                command.Parameters["@bloqueado"].Value = Bloqueado;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            if (resultadoQuery == 1)
            {
                try
                {
                    //Ahora sí lo MODIFICO en la lista
                    for (int i = 0; i < misUsuarios.Count; i++)
                        if (misUsuarios[i].DNI == Dni.ToString())
                        {
                            misUsuarios[i].nombre = Nombre;
                            misUsuarios[i].mail = Mail;
                            misUsuarios[i].password = Password;
                            misUsuarios[i].esAdmin = EsADM;
                            misUsuarios[i].bloqueado = Bloqueado;
                        }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

        public bool login( string usuario , string pass)
        {
            DataSet ds = new DataSet();
            ConexionDB con = new ConexionDB();            
            string queryString = "SELECT  dni,nombre,mail,pass,esAdmin,bloqueado  from dbo.Usuarios where nombre = '" + usuario+ "' and pass = '" + pass +"'";
            
            using (SqlConnection connection = new SqlConnection(con.Conectarbd.ConnectionString))
            {
                       
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
             
        }


        public bool validoSiEsAdmin(string nombre)
        {
            DataSet ds = new DataSet();
            ConexionDB con = new ConexionDB();
            //string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            string queryString = "SELECT *  from dbo.Usuarios where esAdmin = 1 and nombre ='"+ nombre.Trim() + "'";

            using (SqlConnection connection = new SqlConnection(con.Conectarbd.ConnectionString))
            {
                try
                {
                    connection.Open();         
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }


    }
}
