using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;

            CentroCultural centro = new CentroCultural();

            do
            {
                opcion = menuBienvenida();

                if (opcion == "A")
                {
                    poblarCentroCultural(centro);
                }
                else if (opcion == "B")
                {
                    mostrarDatosIngresados(centro);
                }
                else
                {
                    Console.WriteLine("INGRESO MAL LA OPCION");
                }


            } while (opcion != "X");

        }
        public static string menuBienvenida()
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
            return Console.ReadLine().ToUpper().Trim();
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
                else
                {
                    Console.WriteLine("VUELVA INGRESAR UNA OPCION CORRECTA");
                    opcion = Console.ReadLine();
                }
            } while (opcion == "X");
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
            if (centro.artistas.ArtistasExp != null)
            {

                Console.WriteLine("*************** ARTISTAS ****************");
                foreach (var item in centro.artistas.ArtistasExp)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("*************** ESCULTURAS ****************");
            if (centro.artistas.ArtistasExp != null)
            {
                foreach (var item in centro.Obras.exposicion)
                {
                    if (item is Escultura)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            Console.WriteLine("*************** CUADROS ****************");
            if (centro.artistas.ArtistasExp != null)
            {
                foreach (var item in centro.Obras.exposicion)
                {
                    if (item is Cuadro)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

    }

}
