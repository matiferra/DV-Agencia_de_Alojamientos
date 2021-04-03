using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    abstract class Alojamiento 
    {
        public static int codigo { get; set; } = 0;
        public int codigoInstancia { get; set; }
        public string ciudad { get; set; }
        public string barrio { get; set; }
        public string estrellas { get; set; }
        public int cantPersonas { get; set; }
        public Boolean tv { get; set; }

        public Alojamiento()
        {
            codigo++;
            this.codigoInstancia = codigo;
         }
        public Alojamiento(string ciudad, string barrio, string estrellas, int cantPersonas, bool tv)
        {
            codigo++;
            this.codigoInstancia = codigo;
            this.ciudad = ciudad;
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantPersonas = cantPersonas;
            this.tv = tv;
        }


        public Boolean igualCodigo(Alojamiento a)
        {


            return false;
        }


        public override string ToString()
        {
            return
                "id: " + codigoInstancia +
                "\nCiudad: " + ciudad +
                "\nBarrio: " + barrio +
                "\nEstrellas: " + estrellas +
                "\nCantidad de Personas: " + cantPersonas +
                "\nTv: " + tv;
        }

    }
}
