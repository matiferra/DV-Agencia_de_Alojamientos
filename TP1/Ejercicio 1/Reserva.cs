using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Reserva
    {
        private int ID { get; set; }
        private DateTime FDesde { get; set; }
        private DateTime FHasta { get; set; }
        private Alojamiento propiedad { get; set; }
        private Usuario persona { get; set; }
        private double precio { get; set; }


        public Reserva()
        { }

        public Reserva(int ID, DateTime FDesde, DateTime FHasta, Alojamiento propiedad, Usuario persona, double precio)
        {
            this.ID = ID;
            this.FDesde = FDesde;
            this.FHasta = FHasta;
            this.propiedad = propiedad;
            this.persona = persona;
            this.precio = precio;

        }

     

    }
}


