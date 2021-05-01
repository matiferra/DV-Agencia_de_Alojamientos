using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2 
{
    class Escultura : ObraArte
    {
        public double peso { get; set; }
        public double volumen { get; set; }

        public Escultura(double peso, double volumen, string nombre, string nombreArtista, int anioCreacion, DateTime fechaIngreso) 
            : base(nombre, nombreArtista, anioCreacion, fechaIngreso)
        {
            this.peso = peso;
            this.volumen = volumen;
        }

        
        public override string ToString()
        {
            return base.ToString()
                + $"\n Peso = {peso}"
                + $"\n Volumen = {volumen}";
        }
    }
}
