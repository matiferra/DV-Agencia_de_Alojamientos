using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
  public  class Cabania : Alojamiento 
    {
        private double precioxDia;
        public int habitaciones { get; set; } 
        public int banios { get; set; }
        public Cabania(string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxDia, int habitaciones, int banios)
            : base(ciudad, barrio, estrellas, cantPersonas, tv)
        {
            this.precioxDia = precioxDia;
            this.habitaciones = habitaciones;
            this.banios = banios;
            this.tv = tv;

        }



        public override string ToString()
        {
            return
                "\nCABAÑA\n" + 
                base.ToString() +
                "\nPrecio por Dia: " + precioxDia +
                "\nHabitaciones: " + habitaciones +
                 "\nbanios: " + banios;
        }


        public override double getPrecio()
        {
            return this.precioxDia;
        }


    }
}
