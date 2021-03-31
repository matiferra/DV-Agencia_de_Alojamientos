using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class CentroCultural
    {
        public string nombre { get; set; }
        public ObrasExposicion Obra { get; set; }
        public ArtistaExposicion artista { get; set; }

        public string[] nombresObreasNacionalidad(string Nac)
        {
            //Obra.ObrasArtista()
            ArtistaExposicion a = null;
            a = artista.artistasNac(Nac);

            String[] nombresObrasNacionalidad = new String[a.ArtistasExp.Count];

            foreach (var artista in a.ArtistasExp)
            {
                bool encontrada = false;
                int x = 0;
                while (x < Obra.exposicion.Length && encontrada == false)
                    if (Obra.exposicion[x].nombreArtista == artista.nombre)
                    {
                        for (int i = 0; i < nombresObrasNacionalidad.Length; i++)
                        {
                            if (nombresObrasNacionalidad[i] == null)
                            {
                                nombresObrasNacionalidad[i] = Obra.exposicion[x].nombre;
                            }
                        }
                        encontrada = true;
                    }
            }
            return nombresObrasNacionalidad;
        }



    public string nombresCuadrosGaleria(string Gal)
    {

        return "";
    }
}
}
