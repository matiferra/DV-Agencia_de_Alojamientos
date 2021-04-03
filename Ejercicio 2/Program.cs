using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_2
{

    class Program
    {

        static void Main(string[] args)
        {
            CentroCultural centro = new CentroCultural();
            menuBienvenida(centro);

        }
        public static void menuBienvenida(CentroCultural centro)
        {
            string opcion = null;
            do
            {

                Console.WriteLine("*************Bienvenido****************");
                Console.WriteLine("*Elija usuario  ***********************");
                Console.WriteLine("***************************************");
                Console.WriteLine("");
                Console.WriteLine("A - Poblar el Centro Cultural");
                Console.WriteLine("B - Mostrar Datos ingresados");
                Console.WriteLine("");
                Console.WriteLine("X - SALIR");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine().ToUpper().Trim();
                if (opcion == "A")
                {
                    poblarCentroCultural(centro);
                }
                else if (opcion == "B")
                {
                    mostrarDatosIngresados(centro);
                }
                else if (opcion == "X")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("INGRESO MAL LA OPCION");
                }
            }
            while (opcion != "X");

        }



        public static void poblarCentroCultural(CentroCultural centro)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("A - Insertar Artista");
                Console.WriteLine("B - Insertar Escultura");
                Console.WriteLine("C - Insertar CuadroPrestado\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();

                if (opcion.ToUpper().Trim() == "A")
                {

                    opcion = crearArtista(centro.artistas);
                }
                else if (opcion.ToUpper().Trim() == "B")
                {
                    opcion = crearEscultura(centro.Obras);
                }
                else if (opcion.ToUpper().Trim() == "C")
                {
                    opcion = crearCuadroPrestado(centro.Obras);
                }
                else if (opcion.ToUpper().Trim() != "A" && opcion.ToUpper().Trim() != "B" && opcion.ToUpper().Trim() != "C" && opcion.ToUpper().Trim() != "X")
                {
                    Console.WriteLine("VUELVA INGRESAR UNA OPCION CORRECTA");
                }

            } while (opcion != "X");
            menuBienvenida(centro);
        }


        public static string crearEscultura(ObrasExposicion obras)
        {
            string result = string.Empty;

            string nombre = string.Empty;
            string nombreArtista = string.Empty;
            int anioCreacion = 0;
            DateTime fechaIngreso = DateTime.MinValue;
            double peso = 0;
            double volumen = 0;

            Console.WriteLine("*********** NUEVA ESCULTURA ************");
            Console.WriteLine("*Ingrese Nombre = ");
            nombre = Console.ReadLine();
            Console.WriteLine("*Ingrese Nombre del artista = ");
            nombreArtista = Console.ReadLine();
            Console.WriteLine("*Ingrese Anio de creacion = ");
            anioCreacion = int.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Ingreso = ");
            fechaIngreso = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese el Peso = ");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese el Volumen = ");
            volumen = Double.Parse(Console.ReadLine());
            Console.WriteLine("************************************");
            try
            {
                obras.insertarObra(new Escultura(peso, volumen, nombre, nombreArtista, anioCreacion, fechaIngreso));
                Console.WriteLine("La escultura se inserto con exito!!");
                result = "X";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar escultura" + ex.Message);
            }
            return result;
        }
        public static string crearCuadroPrestado(ObrasExposicion obras)
        {
            string result = string.Empty;

            string nombre = string.Empty;
            string nombreArtista = string.Empty;
            int anioCreacion = 0;
            DateTime fechaIngreso = DateTime.MinValue;
            double Base = 0;
            double altura = 0;
            DateTime fechaDevolucion = DateTime.MinValue;
            string nombreGaleria = string.Empty;


            Console.WriteLine("*********** NUEVO CUADRO ************");
            Console.WriteLine("*Ingrese Nombre = ");
            nombre = Console.ReadLine();
            Console.WriteLine("*Ingrese Nombre del artista = ");
            nombreArtista = Console.ReadLine();
            Console.WriteLine("*Ingrese Anio de creacion = ");
            anioCreacion = int.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Ingreso = ");
            fechaIngreso = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese el Base = ");
            Base = Double.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese la Altura = ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Devolucion = ");
            fechaDevolucion = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Nombre de Galeria = ");
            nombreGaleria = Console.ReadLine();

            Console.WriteLine("************************************");

            try
            {
                obras.insertarObra(new CuadroPrestado(fechaDevolucion, nombreGaleria, Base, altura, nombre, nombreArtista, anioCreacion, fechaIngreso));
                Console.WriteLine("El cuadro se inserto con exito!!");
                result = "X";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar cuadro" + ex.Message);
            }
            return result;
        }
        public static string crearArtista(ArtistaExposicion artistas)
        {
            string result = string.Empty;

            string nombre = string.Empty;
            string nacionalidad = string.Empty;
            DateTime fechaNacimiento = DateTime.MinValue;
            DateTime fechaFallecimiento = DateTime.MaxValue;


            Console.WriteLine("*********** NUEVO ARTISTA ************");
            Console.WriteLine("*Ingrese Nombre del artista = ");
            nombre = Console.ReadLine();
            Console.WriteLine("*Ingrese Nacionalidad = ");
            nacionalidad = Console.ReadLine();
            Console.WriteLine("*Ingrese Fecha de nacimiento = ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de fallecimiento = ");
            fechaFallecimiento = DateTime.Parse(Console.ReadLine());
            try
            {
                artistas.ArtistasExp.Add(new Artista(nombre, nacionalidad, fechaNacimiento, fechaFallecimiento));
                Console.WriteLine("El artista se inserto con exito!!");
                result = "X";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar artista" + ex.Message);
            }
            return result;
        }

        public static void mostrarDatosIngresados(CentroCultural centro)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("A - Mostrar todos");
                Console.WriteLine("B - Mostrar Artista por orden Alfabetico");
                Console.WriteLine("C - Mostrar Obras ordenadas por año");
                Console.WriteLine("D - Mostrar Obras de Artistas segun Nacionalidad");
                Console.WriteLine("E - Mostrar Cuandros de una misma Galeria");
                Console.WriteLine("F - Mostrar Todos los cuadros prestados\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();

                if (opcion.ToUpper().Trim() == "A")
                {
                    mostrarTodos(centro);
                }
                else if (opcion.ToUpper().Trim() == "B")
                {
                    mostrarArtistasOrdenadosNombre(centro);
                }
                else if (opcion.ToUpper().Trim() == "C")
                {
                    mostrarObrasOrdenadasAnio(centro);
                }
                else if (opcion.ToUpper().Trim() == "D")
                {
                    mostrarArtistasNacionalidad(centro);
                }
                else if (opcion.ToUpper().Trim() == "E")
                {
                    mostrarCuadrosMismaGaleria(centro);

                }
                else if (opcion.ToUpper().Trim() == "F")
                {
                    mostrarTodosCuadrosPrestados(centro);

                }
            } while (opcion != "X");


        }

        public static void mostrarTodos(CentroCultural centro)
        {
            int contadorArt = 0;
            int contadorEsc = 0;
            int contadorCuadro = 0;


            Console.WriteLine("*************** ARTISTAS ****************");
            foreach (var item in centro.artistas.ArtistasExp)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                    contadorArt++;
                }
            }

            if (contadorArt == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("*************** ESCULTURAS ****************");

            foreach (var item in centro.Obras.exposicion)
            {
                if (item is Escultura)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                        contadorEsc++;
                    }
                }

            }

            if (contadorEsc == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("*************** CUADROS ****************");


            foreach (var item in centro.Obras.exposicion)
            {
                if (item is Cuadro)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                        contadorCuadro++;
                    }

                }

            }

            if (contadorCuadro == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }
        }


        public static void mostrarArtistasOrdenadosNombre(CentroCultural centro)
        {
            List<Artista> sorted = centro.artistas.ArtistasExp.OrderBy(x => x.nombre).ToList();
            
            Console.WriteLine(String.Join(Environment.NewLine, sorted));

        }

        public static void mostrarObrasOrdenadasAnio(CentroCultural centro)
        {
            int contador = 0;
            //   data = data.OrderBy(x => x.Name).ToArray();

            foreach (var item in centro.Obras.exposicion)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    contador++;
                }
            }
            
            if (contador == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }

        }
        public static void mostrarArtistasNacionalidad(CentroCultural centro)
        {
            ArtistaExposicion a = null;
            string nacionalidad = string.Empty;
            int contador = 0;

            Console.WriteLine("Ingrese Nacionalidad");
            nacionalidad = Console.ReadLine();

            a = centro.artistas.artistasNac(nacionalidad);
            foreach (var item in a.ArtistasExp)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    contador++;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }
        }
        public static void mostrarCuadrosMismaGaleria(CentroCultural centro)
        {
            string galeria = string.Empty;
            ObrasExposicion obras = null;
            int contador = 0;

            Console.WriteLine("Ingrese nombre Galeria");
            galeria = Console.ReadLine();
            obras = centro.Obras.todosLosCuadrosPrestados();
            if(obras != null)
            {
                 string[] nombresCuadrosGaleria = new string[obras.exposicion.Length];
                foreach (var item in obras.exposicion)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                        contador++;
                    }
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }
        }
        public static void mostrarTodosCuadrosPrestados(CentroCultural centro)
        {
            ObrasExposicion o = null;
            o = centro.Obras.todosLosCuadrosPrestados();
            int contador = 0;
            if (o != null)
            {
                foreach (var item in o.exposicion)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item);
                        contador++;
                    }
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }
            //TODO
        }

    }
}
