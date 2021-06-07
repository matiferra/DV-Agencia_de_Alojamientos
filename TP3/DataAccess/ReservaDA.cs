using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace DataAccess
{
    public class ReservaDA
    {


        public DataSet buscarReservas(string dni, string desdeFecha, string hastaFecha)
        {

            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " fdesde, fhasta, Ciudades.nombre as ciudad, precio, Alojamientos.id_alojamiento as alojamiento, id_reserva";
            queryString += " from reservas as Reservas, Ciudades, Usuarios, Alojamientos";
            queryString += " WHERE Ciudades.id_ciudad = Alojamientos.id_ciudad";
            queryString += " AND Usuarios.dni = Reservas.id_usuario";
            queryString += " AND Reservas.id_alojamiento = Alojamientos.id_alojamiento";
            queryString += " AND Usuarios.dni = @dni";
            queryString += " AND Reservas.fhasta = @desdeFecha";
            queryString += " AND Reservas.fdesde = @hastaFecha";

            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.SelectCommand.Parameters.Add("@desdeFecha", SqlDbType.DateTime).Value = desdeFecha;
            da.SelectCommand.Parameters.Add("@hastaFecha", SqlDbType.DateTime).Value = hastaFecha;
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            da.Fill(ds);
            _conn.cerrar();
            return ds;

        }
        


        public DataSet getTodasLasReservas()//PARA ADMIN
        {
            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " id_reserva, fdesde,fhasta, Ciudades.nombre as ciudad, Usuarios.nombre as usuario, precio";
            queryString += " from Reservas as Reservas, Alojamientos, Usuarios, Ciudades"; //EN BD reservas ??
            queryString += " WHERE Ciudades.id_ciudad = Alojamientos.id_ciudad";
            queryString += " AND Usuarios.dni = Reservas.id_usuario";
            queryString += " AND Reservas.id_alojamiento = Alojamientos.id_alojamiento";
            
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }


        public DataSet getReservasPorCliente(string dni)
        {

            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " fdesde, fhasta, Ciudades.nombre as ciudad, precio, Alojamientos.id_alojamiento as alojamiento, id_reserva";
            queryString += " from reservas as Reservas, Ciudades, Usuarios, Alojamientos";
            queryString += " WHERE Ciudades.id_ciudad = Alojamientos.id_ciudad";
            queryString += " AND Usuarios.dni = Reservas.id_usuario";
            queryString += " AND Reservas.id_alojamiento = Alojamientos.id_alojamiento";
            queryString += " AND Usuarios.dni = @dni";
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            if(da != null)
            {

            da.Fill(ds);
            }
            _conn.cerrar();
            return ds;

        }


        public bool updateReserva(int id_reserva, DateTime FDesde, DateTime FHasta, int usuario, float precio, int id_alojamiento)
        {
            int resultadoQuery;
            string queryString = "UPDATE [dbo].[Reservas] SET   " +
                                "  fdesde = @FDesde , " +
                                " fhasta = @FHasta ," +
                                " id_usuario = @usuario ," +
                                " precio= @precio ," +
                                " id_alojamiento= @id_alojamiento," +
                                " WHERE id_reserva=@id_reserva;";
            ConexionDB con = new ConexionDB();
            SqlCommand command = new SqlCommand(queryString, con.Conectarbd);
            command.Parameters.Add(new SqlParameter("@FDesde", SqlDbType.DateTime));
            command.Parameters.Add(new SqlParameter("@FHasta", SqlDbType.DateTime));
            command.Parameters.Add(new SqlParameter("@usuario", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@precio", SqlDbType.Float));
            command.Parameters.Add(new SqlParameter("@id_reserva", SqlDbType.Int));
            command.Parameters.Add("@id_alojamiento", SqlDbType.Int).Value = id_alojamiento.ToString();

            command.Parameters["@id_reserva"].Value = id_reserva;
            command.Parameters["@FDesde"].Value = FDesde;
            command.Parameters["@FHasta"].Value = FHasta;
            command.Parameters["@usuario"].Value = usuario;
            command.Parameters["@precio"].Value = precio;
            command.Parameters["@id_alojamiento"].Value = id_alojamiento;
            try
            {
                con.abrir();
                resultadoQuery = command.ExecuteNonQuery();
                con.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public bool deleteReserva(int id)
        {
            string queryString = "DELETE FROM [dbo].[Reservas] WHERE id_reserva = "+ id;
            ConexionDB connection = new ConexionDB();
            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
           //command.Parameters.Add(new SqlParameter("@id_reserva", SqlDbType.Int));
           // c/ ommand.Parameters["@id_reserva"].Value = id;
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

        public void createReserva(DateTime FDesde, DateTime FHasta, int id_usuario, float precio, int id_alojamiento)
        {

            DataSet ds = new DataSet();
            ConexionDB _conn = new ConexionDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "INSERT INTO RESERVAS VALUES ('";
            command.Parameters.Add("@FHasta", SqlDbType.DateTime).Value = FHasta;
            command.Parameters.Add("@FDesde", SqlDbType.DateTime).Value = FDesde;
            command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario;
            command.Parameters.Add("@precio", SqlDbType.Float).Value = precio.ToString();
            command.Parameters.Add("@id_alojamiento", SqlDbType.Int).Value = id_alojamiento.ToString();
            command.CommandText = "')";
            command.Connection = _conn.Conectarbd;

            try
            {
                _conn.abrir();
                command.ExecuteNonQuery();
                _conn.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



    }
}

