using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Hotel : Alojamiento 
    {


        private double precioxPersona { get; set; }

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




    }
}
