using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Agencia
    {
        public static int CantAloj { get; set; }
        public Alojamiento[] alojamientosAgencia { get; set; }



        public Agencia()
        {
            CantAloj = 50;
            alojamientosAgencia = new Alojamiento[CantAloj];
        }


        public bool estaAlojamiento(Alojamiento a)
        {
            bool esta = false;
            int i = 0;
            while (i < alojamientosAgencia.Length && esta != false)
            {
                if (alojamientosAgencia[i] == a)
                {
                    esta = true;
                }
                i++;
            }
            return esta;
        }

        public void insertarAlojamiento(Alojamiento a)
        {
            int x = 0;
            bool lugarVacio = false;

            while (alojamientosAgencia.Length > x && lugarVacio == false)
            {
                if (alojamientosAgencia[x] == null)
                {
                    alojamientosAgencia[x] = a;
                    lugarVacio = true;
                }
                x++;
            }

        }

        public Agencia soloHoteles()
        {
            Agencia ag = new Agencia();

            for (int i = 0; i < alojamientosAgencia.Length; i++)
            {
                if (alojamientosAgencia[i] is Hotel)
                {
                    ag.insertarAlojamiento(alojamientosAgencia[i]);
                }
            }

            return ag;
        }


        public bool estaLlena()
        {
            bool estalleno = true;
            int x = 0;

            while (x < alojamientosAgencia.Length && estalleno == true)
            {
                if (alojamientosAgencia[x] == null)
                {
                    estalleno = false;
                }
                x++;
            }

            return estalleno;
        }

        public bool hayAlojamiento()
        {

            if (estaLlena())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Agencia masEstrellas(int cantEstrellas)
        {
            Agencia ag = new Agencia();

            switch (cantEstrellas)
            {
                case 1:

                    ag.alojamientosAgencia = recolectar(cantEstrellas);
                    break;

                case 2:
                    ag.alojamientosAgencia = recolectar(cantEstrellas);
                    break;

                case 3:
                    ag.alojamientosAgencia = recolectar(cantEstrellas);
                    break;

                case 4:
                    ag.alojamientosAgencia = recolectar(cantEstrellas);
                    break;

                case 5:
                    ag.alojamientosAgencia = recolectar(cantEstrellas);
                    break;
            }



            return ag;
        }

        private int conversionEntero(string atributo)
        {
            int retorno;
            switch (atributo.ToLower().Trim())
            {
                case "uno":
                    retorno = 1;
                    break;

                case "dos":
                    retorno = 2;
                    break;

                case "tres":
                    retorno = 3;
                    break;

                case "cuatro":
                    retorno = 4;
                    break;

                case "cinco":
                    retorno = 5;
                    break;
                case "*":
                    retorno = 1;
                    break;

                case "**":
                    retorno = 2;
                    break;

                case "***":
                    retorno = 3;
                    break;

                case "****":
                    retorno = 4;
                    break;

                case "*****":
                    retorno = 5;
                    break;
                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }

        private Alojamiento[] recolectar(int estrellas)
        {
            Alojamiento[] masEstrellas = new Alojamiento[CantAloj];
            for (int x = 0; x < alojamientosAgencia.Length; x++)
            {
                if (alojamientosAgencia[x] != null)
                {
                    int cantEstrellas = conversionEntero(alojamientosAgencia[x].estrellas);
                    if (cantEstrellas >= estrellas)
                    {
                        masEstrellas[x] = alojamientosAgencia[x];
                    }
                }
            }

            return masEstrellas;
        }


        public Agencia cabaniasentrePrecios(double desde, double hasta)
        {
            Agencia ag = new Agencia();

            for (int x = 0; x < alojamientosAgencia.Length; x++)
            {
                if (alojamientosAgencia[x] is Cabania)
                {
                    Cabania cab = (Cabania)alojamientosAgencia[x];

                    if (cab.precioxDia > desde && cab.precioxDia <= hasta)
                    {
                        ag.insertarAlojamiento(alojamientosAgencia[x]);
                    }
                }
            }
            return ag;
        }

        public bool eliminarAlojamiento(Alojamiento a)
        {
            int x = 0;
            bool encontrado = false;
            while (x < alojamientosAgencia.Length && encontrado == false)
            {
                if (alojamientosAgencia[x].codigoInstancia == a.codigoInstancia)
                {
                    alojamientosAgencia[x] = null;
                    encontrado = true;

                }

            }
            return encontrado;

        }

        public bool modificarAlojamiento(Alojamiento a)
        {
            int x = 0;
            bool modificado = false;
            while (x < alojamientosAgencia.Length && modificado == false)
            {
                if (alojamientosAgencia[x].codigoInstancia == a.codigoInstancia)
                {
                    alojamientosAgencia[x] = a;
                    modificado = true;

                }

            }
            return modificado;
        }

        public Agencia alojamientosEntrePrecios(double desde, double hasta)
        {
            Agencia ag = new Agencia();

            for (int x = 0; x < alojamientosAgencia.Length; x++)
            {
                Alojamiento a = alojamientosAgencia[x];
                if (a.getPrecio() > desde && a.getPrecio() <= hasta) // Agregue un metodo abstracto getPrecio en 		Alojamientos que cabania lo implementa como PrecioxDia y hotel como precioXPersona
                {
                    ag.insertarAlojamiento(alojamientosAgencia[x]);
                }

            }
            return ag;
        }

    }

}
