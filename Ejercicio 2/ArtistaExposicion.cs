using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class ArtistaExposicion
    {
        Artista[] ArtistasExp { get; set; }

        public ArtistaExposicion(int cantArtistas)
        {
            ArtistasExp= new Artista[cantArtistas];
        }

        public int cantidadArtistas()
        {
            return 0;
        }

        public bool estaArtista(ObraArte o)
        {
            return true;
        }
        public bool estaLlena()
        {
            return true;
        }
        public bool hayArtista()
        {
            return true;
        }
        public Artista recuperaArtista(String nom)
        {
            Artista a = null;

            return a;
        }
        public ArtistaExposicion artistasNac(String Nac)
        {
            ArtistaExposicion a = null;
            
            return a;
        }



    }
}
