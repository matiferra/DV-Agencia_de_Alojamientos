using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Artista
    {
        public string nombre { get; set; }
        public string nacionalidad { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaFallecimiento { get; set; }

        public Artista (string nombre, string nacionalidad, DateTime fechaNacimiento, DateTime fechaFallecimiento)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.fechaNacimiento= fechaNacimiento;
            this.fechaFallecimiento = fechaFallecimiento;
        }

    }
}
