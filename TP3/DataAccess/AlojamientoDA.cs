using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AlojamientoDA
    {

        public DataSet getAlojamientos()
        {
            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " barrio,estrellas,cantidadDePersonas,";
            queryString += "(case when tv = 0";
            queryString += "then 'No'";
            queryString += "when tv = 1 ";
            queryString += "then 'si'";
            queryString += "end) tv,";
            queryString += "id_alojamiento,eshotel";
            queryString += ",Ciudades.nombre id_ciudad,cantidad_de_habitaciones,";
            queryString += " cantidadDeBanios,precio_por_dia,precio_por_persona";
            queryString += " from alojamientos as alojamientos";
            queryString += " INNER JOIN Ciudades Ciudades ON Ciudades.id_ciudad = alojamientos.id_ciudad";
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }

        public DataSet getAlojamientosAdmin(string ciudad)
        {
            
            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " barrio,estrellas,cantidadDePersonas,";
            queryString += "(case when tv = 0";
            queryString += "then 'No'";
            queryString += "when tv = 1 ";
            queryString += "then 'si'";
            queryString += "end) tv,";
            queryString += "id_alojamiento,eshotel";
            queryString += ",Ciudades.nombre id_ciudad,cantidad_de_habitaciones,";
            queryString += " cantidadDeBanios,precio_por_dia,precio_por_persona";
            queryString += " from alojamientos as alojamientos";
            queryString += " INNER JOIN Ciudades Ciudades ON Ciudades.id_ciudad = alojamientos.id_ciudad";
            queryString += " WHERE Ciudades.nombre = @ciudad";
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.SelectCommand.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudad;
            da.Fill(ds);
            _conn.cerrar();
            return ds;
        }
        


        public DataSet getAlojamientos(int id)
        {

            DataSet ds = new DataSet();
            string queryString = "select";
            queryString += " barrio,estrellas,cantidadDePersonas,";
            queryString += "(case when tv = 0";
            queryString += "then 'No'";
            queryString += "when tv = 1 ";
            queryString += "then 'si'";
            queryString += "end) tv,";
            queryString += "id_alojamiento,eshotel";
            queryString += ",Ciudades.nombre id_ciudad,cantidad_de_habitaciones,";
            queryString += " cantidadDeBanios,precio_por_dia,precio_por_persona";
            queryString += " from alojamientos as alojamientos";
            queryString += " INNER JOIN Ciudades Ciudades ON Ciudades.id_ciudad = alojamientos.id_ciudad";
            queryString += " WHERE alojamientos.id_alojamiento = " + id;
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            da.Fill(ds);
            _conn.cerrar();
            return ds;

        }


        public bool updateAlojamiento(int id, string barrio, string estrellas, int cantidadDePersonas,
                                      bool tv, string id_ciudad, int cantidad_de_habitaciones,
                                      double precio_por_dia, double precio_por_persona, int cantidadDeBanios)
        {

            int resultadoQuery;
            string queryString = "UPDATE [dbo].[Alojamientos] SET   " +
                                "  barrio = @barrio , " +
                                " estrellas = @estrellas ," +
                                " cantidadDePersonas = @cantidadDePersonas ," +
                                " tv= @tv ," +                              
                                " id_ciudad= @id_ciudad ," +
                                " cantidad_de_habitaciones= @cantidad_de_habitaciones ," +
                                " precio_por_dia= @precio_por_dia ," +
                                " precio_por_persona= @precio_por_persona ," +
                                " cantidadDeBanios= @cantidadDeBanios " +
                                "  WHERE id_alojamiento=@id_alojamiento;";
            ConexionDB con = new ConexionDB();
            SqlCommand command = new SqlCommand(queryString, con.Conectarbd);
            command.Parameters.Add(new SqlParameter("@id_alojamiento", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@barrio", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@estrellas", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@cantidadDePersonas", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@tv", SqlDbType.Bit));
     
            command.Parameters.Add(new SqlParameter("@cantidad_de_habitaciones", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@precio_por_persona", SqlDbType.Decimal));
            command.Parameters.Add(new SqlParameter("@precio_por_dia", SqlDbType.Decimal));
            command.Parameters.Add(new SqlParameter("@id_ciudad", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@cantidadDeBanios", SqlDbType.Int));

            command.Parameters["@id_alojamiento"].Value = id;
            command.Parameters["@barrio"].Value = barrio;
            command.Parameters["@estrellas"].Value = estrellas;
            command.Parameters["@cantidadDePersonas"].Value = cantidadDePersonas;
            command.Parameters["@tv"].Value = tv;        
            command.Parameters["@id_ciudad"].Value = id_ciudad;
            command.Parameters["@cantidad_de_habitaciones"].Value = cantidad_de_habitaciones;
            command.Parameters["@precio_por_dia"].Value = precio_por_dia;
            command.Parameters["@precio_por_persona"].Value = precio_por_persona;
            command.Parameters["@cantidadDeBanios"].Value = cantidadDeBanios;

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

        public bool deleteAlojamiento(int id)
        {          
            string queryString = "DELETE FROM [dbo].[Alojamientos] WHERE id_alojamiento = @id_alojamiento;";
            ConexionDB connection = new ConexionDB();
            SqlCommand command = new SqlCommand(queryString, connection.Conectarbd);
            command.Parameters.Add(new SqlParameter("@id_alojamiento", SqlDbType.Int));
            command.Parameters["@id_alojamiento"].Value = id;

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

        public void createAlojamiento(string barrio, int estrellas, int cantidadDePersonas,
                                      bool tv, bool eshotel, string id_ciudad, int? cantidad_de_habitaciones,
                                      double? precio_por_dia, double? precio_por_persona, int? cantidadDeBanios)
        {

            DataSet ds = new DataSet();
            ConexionDB _conn = new ConexionDB();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "INSERT_ALOJAMIENTO";
            command.Parameters.Add("@barrio", SqlDbType.VarChar).Value = barrio;
            command.Parameters.Add("@estrellas", SqlDbType.VarChar).Value = (estrellas).ToString();
            command.Parameters.Add("@cantidadDePersonas", SqlDbType.VarChar).Value = cantidadDePersonas.ToString();
            command.Parameters.Add("@tv", SqlDbType.Bit).Value = tv;
            command.Parameters.Add("@eshotel", SqlDbType.Bit).Value = eshotel;
            command.Parameters.Add("@id_ciudad", SqlDbType.VarChar).Value = id_ciudad;
            command.Parameters.Add("@cantidad_de_habitaciones", SqlDbType.VarChar).Value = cantidad_de_habitaciones.ToString();
            command.Parameters.Add("@precio_por_dia", SqlDbType.VarChar).Value = precio_por_dia.ToString();
            command.Parameters.Add("@precio_por_persona", SqlDbType.VarChar).Value = precio_por_persona.ToString();
            command.Parameters.Add("@cantidadDeBanios", SqlDbType.VarChar).Value = cantidadDeBanios.ToString();
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

        public DataSet buscoAlojamiento(string Pdesde, string Phasta, bool esHotel, string cant, string ciudad)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select ";
                query += " barrio, ";
                query += " estrellas,  ";
                query += " cantidadDePersonas, ";
                query += " (case when tv = 0  ";
                query += "  then 'No'  "; ;
                query += "  when tv = 1 ";
                query += "  then 'si'  ";
                query += "  end) tv, ";
                query += " id_alojamiento, ";
                query += "  eshotel, ";
                query += " Ciudades.nombre id_ciudad, ";
                query += " cantidad_de_habitaciones, ";
                query += " cantidadDeBanios, ";
                query += " precio_por_dia, ";
                query += " precio_por_persona ";
                query += " from  ";
                query += "    alojamientos alojamientos   ";
                query += " INNER JOIN Ciudades Ciudades ON Ciudades.id_ciudad = alojamientos.id_ciudad  ";
                query += " where ";
                query += "    ISNULL(cantidadDePersonas, '') = (CASE WHEN ISNULL(@cantidadDePersonas,'') = '' ";
                query += "                                          then ISNULL(cantidadDePersonas,'')  ";
                query += "                                          else ISNULL(@cantidadDePersonas, '') ";
                query += "                                          end ) and ";
                query += "    ISNULL(alojamientos.id_ciudad, '') = (CASE WHEN ISNULL(@id_ciudad,'') = ''";
                query += "                                 then alojamientos.id_ciudad   ";
                query += "                                 else @id_ciudad  ";
                query += "                                 end ) and   ";
                query += "eshotel = @eshotel ";

                if (!string.IsNullOrEmpty(Pdesde) && !string.IsNullOrEmpty(Phasta))
                {
                    if (esHotel)
                    {
                        query += "and precio_por_persona  BETWEEN @pdesde and @phasta ";
                    }
                    else
                    {
                        query += " and precio_por_dia BETWEEN @pdesde and @phasta ";
                    }
                }

                ConexionDB _conn = new ConexionDB();
                _conn.abrir();
                SqlDataAdapter da = new SqlDataAdapter(query, _conn.Conectarbd);
                da.SelectCommand.Parameters.Add("@cantidadDePersonas", SqlDbType.Int).Value = cant;
                da.SelectCommand.Parameters.Add("@eshotel", SqlDbType.Bit).Value = esHotel;
                da.SelectCommand.Parameters.Add("@id_ciudad", SqlDbType.VarChar).Value = ciudad;
                if (!string.IsNullOrEmpty(Pdesde) && !string.IsNullOrEmpty(Phasta))
                {
                    da.SelectCommand.Parameters.Add("@pdesde", SqlDbType.Decimal).Value = double.Parse(Pdesde);
                    da.SelectCommand.Parameters.Add("@phasta", SqlDbType.Decimal).Value = double.Parse(Phasta);
                }

                da.Fill(ds);
                _conn.cerrar();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ds;

            //DataSet ds = new DataSet(); 
            //ConexionDB _conn = new ConexionDB();
            //try
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "BUSCO_ALOJAMIENTO_CLIENTE";
            //    cmd.Parameters.Add("@cantidadDePersonas", SqlDbType.Int).Value = cant;
            //    cmd.Parameters.Add("@eshotel", SqlDbType.Bit).Value = esHotel;
            //    cmd.Parameters.Add("@id_ciudad", SqlDbType.VarChar).Value = ciudad;
            //    cmd.Parameters.Add("@pdesde", SqlDbType.DateTime).Value = Pdesde;
            //    cmd.Parameters.Add("@phasta", SqlDbType.DateTime).Value = Phasta;
            //    cmd.Connection = _conn.Conectarbd;

            //    _conn.abrir();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);    
            //    da.Fill(ds);
            //    _conn.cerrar();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return ds;

        }

    }
}
