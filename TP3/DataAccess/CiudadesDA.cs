using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CiudadesDA
    {
        public DataTable getCiudades()
        {
            string queryString = "select ";
            queryString += " id_ciudad, nombre from ciudades";
            ConexionDB _conn = new ConexionDB();
            _conn.abrir();
            SqlDataAdapter da = new SqlDataAdapter(queryString, _conn.Conectarbd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _conn.cerrar();

            return dt;
        }

    }
}
