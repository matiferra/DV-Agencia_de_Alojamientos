using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2  
{
    abstract class Cuadro : ObraArte
    {
        public double Base {get; set;}
        public double altura {get; set;}

        public Cuadro(double Base, double altura, string nombre, string nombreArtista, int anioCreacion, DateTime fechaIngreso)
            : base (nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.Base = Base;
            this.altura = altura;
        }
        public override string ToString()
        {
            return base.ToString()
                + $"\n Base = {Base}"
                + $"\n Atura = {altura}";
        }

    }
}
