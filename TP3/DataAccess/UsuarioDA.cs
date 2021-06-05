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
        //  private List<Entidades.Usuario> misUsuarios;

        //public UsuarioDA()
        //{
        //    //  misUsuarios = new List<Entidades.Usuario>();
        //    inicializarAtributos();
        //}

        //private void inicializarAtributos()
        //{
        //    //Cargo la cadena de conexión desde el archivo de properties
        //    string connectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;

        //    //Defino el string con la consulta que quiero realizar
        //    string queryString = "SELECT  dni,nombre,mail,pass,esAdmin,bloqueado  from dbo.Usuarios";

        //    // Creo una conexión SQL con un Using, de modo que al finalizar, la conexión se cierra y se liberan recursos
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        // Defino el comando a enviar al motor SQL con la consulta y la conexión
        //        SqlCommand command = new SqlCommand(queryString, connection);

        //        try
        //        {
        //            //Abro la conexión
        //            connection.Open();
        //            //mi objecto DataReader va a obtener los resultados de la consulta, notar que a comando se le pide ExecuteReader()
        //            SqlDataReader reader = command.ExecuteReader();
        //            // Entidades.Usuario aux;
        //            //mientras haya registros/filas en mi DataReader, sigo leyendo
        //            while (reader.Read())
        //            {
        //                //aux = new Entidades.Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetBoolean(5));
        //                //misUsuarios.Add(aux);
        //            }
        //            //En este punto ya recorrí todas las filas del resultado de la query
        //            reader.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}

        public DataSet obtenerUsuarios()
        {
            DataSet ds = new DataSet();
            string queryString = "select ";
            queryString += " dni, mail, pass, bloqueado, intentosLogeo, nombre, esAdmin ";
            queryString += " FROM Usuarios ";
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }

        public DataSet obtenerUsuarios(int dni = 0)
        {
            DataSet ds = new DataSet();
            string queryString = "select ";
            queryString += " dni, mail, pass, bloqueado, intentosLogeo, nombre, esAdmin ";
            queryString += " FROM Usuarios ";
            if (dni != 0)
            {
                queryString += " where dni like '%" + dni + "%'";
            }

            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }

        public void agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
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
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

        public bool eliminarUsuario(int Dni)
        {
            ConexionDB connection = new ConexionDB();
            string queryString = "DELETE FROM [dbo].[Usuarios] WHERE dni=@dni;";

            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            command.Parameters["@dni"].Value = Dni;
            try
            {
                connection.abrir();
                command.ExecuteNonQuery();
                connection.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool modificarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        {
            //primero me aseguro que lo pueda agregar a la base
          
            string queryString = "UPDATE [dbo].[Usuarios] SET nombre=@nombre, mail=@mail,pass=@password, esAdmin=@esadm, bloqueado = @bloqueado  WHERE dni=@dni;";
            ConexionDB con = new ConexionDB();
            SqlCommand command = new SqlCommand(queryString, con.Conectarbd);
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
                con.abrir();
                command.ExecuteNonQuery();
                con.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool login(string usuario, string pass)
        {
            DataSet ds = new DataSet();
            ConexionDB con = new ConexionDB();
            string queryString = "SELECT  dni,nombre,mail,pass,esAdmin,bloqueado  from dbo.Usuarios where nombre = '" + usuario + "' and pass = '" + pass + "'";

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
            string queryString = "SELECT *  from dbo.Usuarios where esAdmin = 1 and nombre ='" + nombre.Trim() + "'";

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

        public bool  desbloquearUsuario(int Dni)
        {
            ConexionDB connection = new ConexionDB();
            string queryString = "UPDATE [dbo].[Usuarios] SET bloqueado = 0  WHERE dni=@dni;";

            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            command.Parameters["@dni"].Value = Dni;
            try
            {
                connection.abrir();
                command.ExecuteNonQuery();
                connection.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public void cambiarContraseña(string pass , int dni)
        {
            ConexionDB connection = new ConexionDB();
            string queryString = "UPDATE [dbo].[Usuarios] SET pass = @pass  WHERE dni=@dni;";

            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar));
            command.Parameters["@dni"].Value = dni;
            command.Parameters["@pass"].Value = pass;
            try
            {
                connection.abrir();
                command.ExecuteNonQuery();
                connection.cerrar();
               // return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // return false;
            }
        }

    }
}
