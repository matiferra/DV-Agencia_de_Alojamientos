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
                queryString += " where dni = '" + dni + "'";
            }

            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }

        public DataSet obtenerUsuariosxNombre(string nombre)
        {
            DataSet ds = new DataSet();
            string queryString = "select ";
            queryString += " dni, mail, pass, bloqueado, intentosLogeo, nombre, esAdmin ";
            queryString += " FROM Usuarios ";
            queryString += " where nombre = '" + nombre + "'";
            
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }

        public bool sumarIntentosDeLogeo(int contadorIntentos, string dni)
        {
            ConexionDB connection = new ConexionDB();
            string queryString = "UPDATE [dbo].[Usuarios] SET intentosLogeo = @contadorIntentos WHERE dni=@dni;";

            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            command.Parameters["@dni"].Value = dni;
            command.Parameters.Add(new SqlParameter("@contadorIntentos", SqlDbType.Int));
            command.Parameters["@contadorIntentos"].Value = contadorIntentos;

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
        public bool bloquearUsuario(string dni)
        {
            ConexionDB connection = new ConexionDB();
            string queryString = "UPDATE [dbo].[Usuarios] SET bloqueado = 1, intentosLogeo = 0 WHERE dni=@dni";

            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
            command.Parameters["@dni"].Value = dni;

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

        public DataSet obtenerUsuarios(string usuario,string contrasenia){
            DataSet ds = new DataSet();
            string queryString = "select top 1 ";
            queryString += " dni, mail, pass, bloqueado, intentosLogeo, nombre, esAdmin ";
            queryString += " FROM Usuarios ";          
            queryString += " where nombre = '" + usuario+"'";
            queryString += " and  pass = '" + contrasenia+"'";


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
                        string guardoDNI = ds.Tables[0].Rows[0]["dni"].ToString();
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
