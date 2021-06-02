using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Agencia
    {
        public static int CantAloj { get; set; }
        public Alojamiento[] alojamientosAgencia { get; set; }
        public List<Alojamiento> misAlojamientos { get; set; }
        public int cantAlojamientos  { get; set; }

        public Agencia()
        {
            misAlojamientos = new List<Alojamiento>();
            CantAloj = 50;
            alojamientosAgencia = new Alojamiento[CantAloj];
        }   
    }

}
