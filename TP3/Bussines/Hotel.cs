using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
   public  class Hotel : Alojamiento 
    {
         
        private double precioxPersona;

        public Hotel(string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxPersona) 
            : base(ciudad, barrio, estrellas, cantPersonas, tv)
        {
            this.precioxPersona = precioxPersona;
        }

        
        public override string ToString()
        {
            return
                "\nHOTEL\n"+
                base.ToString() +
                "\nPrecio por Persona: " + precioxPersona;
        }

        public override double getPrecio()
        {
            return this.precioxPersona;
        }



    }
}
