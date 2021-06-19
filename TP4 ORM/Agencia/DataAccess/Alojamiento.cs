using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Alojamiento
    {
        public int id { get; set; }
        public string barrio { get; set; }
        public string estrellas { get; set; }
        public int cantidadDePersonas { get; set; }
        public bool tv { get; set; }
        public Ciudades id_ciudad { get; set; }
        public int cantidad_de_habitaciones { get; set; }
        public double precio_por_dia { get; set; }
        public double precio_por_persona { get; set; }
        public int cantidadDeBanios { get; set; }

    }
}
