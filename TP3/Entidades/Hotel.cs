using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public  class Hotel : Alojamiento 
    {
         
        private double precioxPersona;

        public Hotel(string ciudad, string barrio, string estrellas, int cantPersonas, Boolean tv, double precioxPersona) 
            : base(ciudad, barrio, estrellas, cantPersonas, tv)
        {
            this.precioxPersona = precioxPersona;
        }        

    }
}
