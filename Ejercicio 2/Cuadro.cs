using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Cuadro : ObraArte
    {
        public double Base {get; set;}
        public double altura {get; set;}

        public Cuadro(double Base, double altura, int codigo, string nombre, string nombreArtista, int anioCreacion, DateTime fechaIngreso)
            : base (codigo, nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.Base = Base;
            this.altura = altura;
        }
    }
}
