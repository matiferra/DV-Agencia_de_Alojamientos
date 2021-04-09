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
                Console.WriteLine("***************************************");
                Console.WriteLine("*************Bienvenido****************");
                Console.WriteLine("***************************************");
                Console.WriteLine("");
                Console.WriteLine("A - Poblar el Centro Cultural");
                Console.WriteLine("B - Mostrar Datos ingresados");
                Console.WriteLine("");
                Console.WriteLine("X - SALIR");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine().ToUpper().Trim();
                if (opcion.ToUpper().Trim() == "A")
                {
                    poblarCentroCultural(centro);
                }
                else if (opcion.ToUpper().Trim() == "B")
                {
                    mostrarDatosIngresados(centro);
                }
                else if (opcion.ToUpper().Trim() == "X")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("INGRESO MAL LA OPCION");
                }
            }
            while (opcion.ToUpper().Trim() != "X");

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
            anioCreacion = verificarInt(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Ingreso = ");
            fechaIngreso = verificarFecha(Console.ReadLine());
            Console.WriteLine("*Ingrese el Peso = ");
            peso = verificarDouble(Console.ReadLine());
            Console.WriteLine("*Ingrese el Volumen = ");
            volumen = verificarDouble(Console.ReadLine());
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
            anioCreacion = verificarInt(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Ingreso = ");
            fechaIngreso = verificarFecha(Console.ReadLine());
            Console.WriteLine("*Ingrese el Base = ");
            Base = verificarDouble(Console.ReadLine());
            Console.WriteLine("*Ingrese la Altura = ");
            altura = verificarDouble(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de Devolucion = ");
            fechaDevolucion = verificarFecha(Console.ReadLine());
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
            fechaNacimiento = verificarFecha(Console.ReadLine());
            Console.WriteLine("*Ingrese Fecha de fallecimiento = ");
            fechaFallecimiento = verificarFecha(Console.ReadLine());
            try
            {
                artistas.insertarArtista(new Artista(nombre, nacionalidad, fechaNacimiento, fechaFallecimiento));
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
            var a = centro.Obras.exposicion.ToList();
            List<ObraArte> guardo = new List<ObraArte>();
            foreach (var item in a)
            {
                if (item != null)
                {
                    guardo.Add(item);
                    contador++;
                }
            }
            List<ObraArte> sorted = guardo.OrderBy(x => x.anioCreacion).ToList();

            Console.WriteLine(String.Join(Environment.NewLine, sorted));

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
            int contador = 0;

            Console.WriteLine("Ingrese nombre Galeria");
            galeria = Console.ReadLine();

            string[] nombresCuadrosGaleria = new string[100];
            nombresCuadrosGaleria = centro.nombresCuadrosGaleria(galeria);

            Console.WriteLine("\nNombre de Cuadros");
            if (nombresCuadrosGaleria != null)
            {
                foreach (var item in nombresCuadrosGaleria)
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

        public static DateTime verificarFecha(string datoIngresado)
        {
            bool ok;
            DateTime fecha = DateTime.MinValue;
            do
            {
                ok = true;
                if (ok == true)
                {
                    try
                    {
                        fecha = DateTime.Parse(datoIngresado);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ingrese en formato dd/mm/yyyy");
                        datoIngresado = Console.ReadLine();
                        ok = false;
                    }
                }
            } while (ok != true);

            return fecha;
        }

        public static int verificarInt(string datoIngresado)
        {
            bool ok;
            int entero = 0;
            do
            {
                ok = true;
                if (ok == true)
                {
                    try
                    {
                        entero = int.Parse(datoIngresado);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ingrese en un numero entero");
                        datoIngresado = Console.ReadLine();
                        ok = false;
                    }
                }
            } while (ok != true);

            return entero;
        }

        public static Double verificarDouble(string datoIngresado)
        {
            bool ok;
            double real = 0;
            do
            {
                ok = true;
                if (ok == true)
                {
                    try
                    {
                        real = Double.Parse(datoIngresado);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ingrese en un numero entero con coma");
                        datoIngresado = Console.ReadLine();
                        ok = false;
                    }
                }
            } while (ok != true);

            return real;
        }

    }
}
