using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines
{
   public  class Reserva
    {
        public int contador { get; set; } = 0;
        public int ID { get; set; }
        public DateTime FDesde { get; set; }
        public DateTime FHasta { get; set; }
        public Alojamiento propiedad { get; set; } 
        public Usuario persona { get; set; }
        public float precio { get; set; }


        public Reserva()
        { }

        public Reserva(DateTime FDesde, DateTime FHasta, Alojamiento propiedad, Usuario persona, float precio)
        {
            this.contador++;
            this.ID = contador++;
            this.FDesde = FDesde;
            this.FHasta = FHasta;
            this.propiedad = propiedad;
            this.persona = persona;
            this.precio = precio;

        }

     

    }
}


