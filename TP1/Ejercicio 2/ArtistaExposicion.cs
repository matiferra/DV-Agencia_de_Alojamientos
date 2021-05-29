using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2 
{
    class ArtistaExposicion
    {
        public List<Artista> ArtistasExp { get; set; }

        public ArtistaExposicion()
        {
            ArtistasExp = new List<Artista>();
        }

        public void insertarArtista(Artista artista)
        {
            ArtistasExp.Add(artista);
        }

        public int cantidadArtistas()
        {
            return ArtistasExp.Count;
        }

        public bool estaArtista(ObraArte o)
        {
            foreach (var item in ArtistasExp)
            {
                if(item.nombre == o.nombreArtista)
                {
                    return true;
                }
            }
            return false;
        }
        public bool estaLlena()
        {
            return ArtistasExp.Capacity == ArtistasExp.Count ? true : false;
        }
        public bool hayArtista()
        {
            return ArtistasExp.Count != 0 ? true : false;
        }
        public Artista recuperaArtista(string nom)
        {

            foreach (var item in ArtistasExp)
            {
                if(item.nombre == nom)
                {
                    return item;
                }
            }

            return null;
        }
        public ArtistaExposicion artistasNac(string Nac)
        {
            ArtistaExposicion artistasConMismaNacionalidad = new ArtistaExposicion();
            foreach (var item in ArtistasExp)
            {
                if (item.nacionalidad == Nac)
                {
                    artistasConMismaNacionalidad.ArtistasExp.Add(item);
                }
            }        
            return artistasConMismaNacionalidad;
        }

    }
}
