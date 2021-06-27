using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Alojamiento
    {
        public int id { get; set; }
        public string barrio { get; set; }
        public string estrellas { get; set; }
        public int cantidadDePersonas { get; set; }
        public bool tv { get; set; }
        public Ciudades ciudad { get; set; }
        public int cantidad_de_habitaciones { get; set; }
        public double precio_por_dia { get; set; }
        public double precio_por_persona { get; set; }
        public int cantidadDeBanios { get; set; }
        public bool esHotel { get; set; }



        public Alojamiento()
        {

        }

        public Alojamiento(string barrio, string estrellas, int cantidadDePersonas,
                           bool tv, Ciudades ciudad, int cantidad_de_habitaciones, double precio_por_dia, 
                           double precio_por_persona, int cantidadDeBanios, bool esHotel)

        {
       
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantidadDePersonas = cantidadDePersonas;
            this.tv = tv;
            this.ciudad = ciudad;            
            this.cantidad_de_habitaciones = cantidad_de_habitaciones;
            this.precio_por_dia = precio_por_dia;
            this.precio_por_persona = precio_por_persona;
            this.cantidadDeBanios = cantidadDeBanios;
            this.esHotel = esHotel;

        }


    }
}
