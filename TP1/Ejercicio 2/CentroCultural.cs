using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class CentroCultural
    {
        public string nombre { get; set; }
        public ObrasExposicion Obras { get; set; }
        public ArtistaExposicion artistas { get; set; }

        public CentroCultural()
        {
            this.nombre = string.Empty;
            this.Obras = new ObrasExposicion(100);
            this.artistas = new ArtistaExposicion();
        }


        public string[] nombresObreasNacionalidad(string Nac)
        {
            //Obra.ObrasArtista()
            ArtistaExposicion a = null;
            a = artistas.artistasNac(Nac);

            String[] nombresObrasNacionalidad = new String[a.ArtistasExp.Count];

            foreach (var artista in a.ArtistasExp)
            {
                bool encontrada = false;
                int x = 0;
                while (x < Obras.exposicion.Length && encontrada == false)
                    if (Obras.exposicion[x].nombreArtista == artista.nombre)
                    {
                        for (int i = 0; i < nombresObrasNacionalidad.Length; i++)
                        {
                            if (nombresObrasNacionalidad[i] == null)
                            {
                                nombresObrasNacionalidad[i] = Obras.exposicion[x].nombre;
                            }
                        }
                        encontrada = true;
                    }
            }
            return nombresObrasNacionalidad;
        }



        public string[] nombresCuadrosGaleria(string Gal)
        {
            ObrasExposicion obras = null;

            obras = Obras.todosLosCuadrosPrestados();

            String[] nombresCuadrosGaleria = new String[obras.exposicion.Length];

            bool encontrado = false;
            int x = 0;

            foreach (var item in obras.exposicion)
            {
                encontrado = false;
                CuadroPrestado c = (CuadroPrestado)item;
                if (c != null)
                {
                    if (c.nombreGaleria == Gal)
                    {
                        while(x < nombresCuadrosGaleria.Length &&  encontrado == false)
                        {
                            if (nombresCuadrosGaleria[x] == null)
                            {
                                nombresCuadrosGaleria[x] = item.nombre;
                                encontrado = true;
                            }
                            x++;
                        }
                        
                    }
                }
            }

            return nombresCuadrosGaleria;
        }
    }
}
