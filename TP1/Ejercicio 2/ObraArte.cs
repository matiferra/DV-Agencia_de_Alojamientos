using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2 
{
    class ObraArte
    {
        public static int codigo { get; set; } = 0;
        public int codigoObraArte { get; set; }
        public string nombre{ get; set; }
        public string nombreArtista{ get; set; }
        public int anioCreacion{ get; set; }
        public DateTime fechaIngreso{ get; set; }

        public ObraArte(string nombre, string nombreArtista, int anioCreacion, DateTime fechaIngreso)
        {
            codigo++;
            this.codigoObraArte = codigo;
            this.nombre = nombre;
            this.nombreArtista = nombreArtista;
            this.anioCreacion = anioCreacion;
            this.fechaIngreso = fechaIngreso;
        }
        override
        public string ToString()
        {
            return
                $" codigo: {codigoObraArte} " +
                $"\n Nombre: {nombre}" +
                $"\n Nombre de Artista: {nombreArtista}" +
                $"\n Año de Creacion: {anioCreacion} " +
                "\n Fecha de Ingreso: " + fechaIngreso.ToString("dd/mm/yyyy");
            
        }
    }
}
