using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;
            Agencia agencia = new Agencia();
            do
            {
                opcion = menuBienvenida();
                if (opcion == "A")
                {
                    menuAdministrador(agencia);
                }
                else if (opcion == "B")
                {
                    menuCliente(agencia);
                }
                else if (opcion == "X")
                {
                    Console.WriteLine("Gracias por usar la App!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion correcta");
                    opcion = Console.ReadLine();
                }
            } while (opcion != "X");

        }

        public static void listaDeAlojamiento(Agencia agencia)
        {
            int x = 1;
            foreach (var item in agencia.alojamientosAgencia)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(x);
                    x++;
                }
            }
            if (x == 1)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--------NO HAY REGISTROS CARGADOS------");
                Console.WriteLine("---------------------------------------");
            }

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
        public static void cabaniasentrePrecios(Agencia agencia)
        {
            Agencia temp = new Agencia();
            int contador = 0;
            double desde;
            double hasta;

            Console.WriteLine("Ingrese precio desde");
            desde = verificarDouble(Console.ReadLine());

            Console.WriteLine("Ingrese precio hasta");
            hasta = verificarDouble(Console.ReadLine());

            temp = agencia.cabaniasentrePrecios(desde, hasta);
            foreach (var item in temp.alojamientosAgencia)
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
            Console.WriteLine("***************************************");
            Console.ReadLine();

        }

        public static void soloHoteles(Agencia agencia)
        {
            Agencia temp = new Agencia();
            temp = agencia.soloHoteles();
            int contador = 0;
            foreach (var item in temp.alojamientosAgencia)
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



            Console.ReadLine();
        }
        public static void masEstrellas(Agencia agencia)
        {
            Agencia temp = new Agencia();
            int cantEstrellas;
            int contador = 0;
            Console.WriteLine("Ingrese a partir de cuantas estrellas");
            cantEstrellas = verificarInt(Console.ReadLine());

            temp = agencia.masEstrellas(cantEstrellas);
            foreach (var item in temp.alojamientosAgencia)
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
            Console.WriteLine("***************************************");
            Console.ReadLine();
        }


        #region Menues
        public static string menuBienvenida()
        {
            Console.WriteLine("*************Bienvenido****************");
            Console.WriteLine("*Elija usuario  ***********************");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.WriteLine("A - Administrador");
            Console.WriteLine("B - Cliente");
            Console.WriteLine("");
            Console.WriteLine("X - SALIR");
            Console.WriteLine("***************************************");
            return Console.ReadLine().ToUpper().Trim();
        }

        public static void menuAdministrador(Agencia agencia)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("\n***************************************");
                Console.WriteLine("**Opciones de Administrador************");
                Console.WriteLine("***************************************");
                Console.WriteLine("A - Insertar Alojamiento\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();
                if (opcion.ToUpper().Trim() == "A")
                {
                    ingresarAlojamiento(agencia);
                }
                else if (opcion.ToUpper().Trim() != "X")
                {
                    Console.WriteLine("Ingrese una opcion correcta");
                    opcion = Console.ReadLine();
                }

            } while (opcion.ToUpper().Trim() != "X");

        }
        public static void menuCliente(Agencia agencia)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("**Opciones de Cliente******************");
                Console.WriteLine("***************************************");
                Console.WriteLine("A - ver Alojamientos\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();
                if (opcion.ToUpper().Trim() == "A")
                {
                    menuVerAlojamientos(agencia);
                }
                else if (opcion.ToUpper().Trim() != "X")
                {
                    Console.WriteLine("Ingrese una opcion correcta");
                    opcion = Console.ReadLine();
                }

            } while (opcion.ToUpper().Trim() != "X");
        }

        public static void menuVerAlojamientos(Agencia agencia)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("**Opciones de Cliente******************");
                Console.WriteLine("***************************************");
                Console.WriteLine("A - Ver Todos los Alojamientos");
                Console.WriteLine("B - Filtrar solo Hoteles");
                Console.WriteLine("C - Filtrar Cabaña segun el precio deseado");
                Console.WriteLine("D - Filtrar Alojamientos por estrellas\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();

                if (opcion == "A")
                {
                    listaDeAlojamiento(agencia);
                }
                else if (opcion == "B")
                {
                    soloHoteles(agencia);
                }
                else if (opcion == "C")
                {
                    cabaniasentrePrecios(agencia);
                }
                else if (opcion == "D")
                {
                    masEstrellas(agencia);
                }
            } while (opcion != "X");

        }
        #endregion


        public static void ingresarAlojamiento(Agencia a)
        {
            string opcion = string.Empty;
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("A - Insertar Hotel");
                Console.WriteLine("B - Insertar Cabaña\n");
                Console.WriteLine("X - Volver");
                Console.WriteLine("***************************************");
                opcion = Console.ReadLine();
                if (opcion.ToUpper().Trim() == "A")
                {
                    crearHotel(a);
                }
                else if (opcion.ToUpper().Trim() == "B")
                {
                    crearCabania(a);
                }
                else if (opcion.ToUpper().Trim() != "A" && opcion.ToUpper().Trim() != "B" && opcion.ToUpper().Trim() != "X")
                {
                    Console.WriteLine("VUELVA INGRESAR UNA OPCION CORRECTA");
                    opcion = Console.ReadLine();
                }
            } while (opcion != "X");

        }

        public static void crearHotel(Agencia a)
        {
            string result = string.Empty;
            string ciudad = string.Empty;
            string barrio = string.Empty;
            string estrellas = string.Empty;
            int cantPersonas = 0;
            bool tv = false;
            double precioxPersona = 0;

            Console.WriteLine("*********** NUEVO HOTEL ************");
            Console.WriteLine("*Ingrese Ciudad = ");
            ciudad = Console.ReadLine();
            Console.WriteLine("*Ingrese Barrio = ");
            barrio = Console.ReadLine();
            Console.WriteLine("*Ingrese Estrellas = ");
            estrellas = Console.ReadLine();
            Console.WriteLine("*Ingrese Limite de Personas = ");
            cantPersonas = verificarInt(Console.ReadLine());
            tv = seteoTv();
            Console.WriteLine("*Ingrese Precio por Persona = ");
            precioxPersona = verificarInt(Console.ReadLine());
            Console.WriteLine("************************************");
            try
            {
                a.insertarAlojamiento(new Hotel(ciudad, barrio, estrellas, cantPersonas, tv, precioxPersona));
                Console.WriteLine("El Hotel se inserto con exito!!");
                result = "X";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar alojamiento" + ex.Message);
            }
            Console.ReadLine();
        }

        private static bool seteoTv()
        {
            bool tv = false;
            string opcionTV = "incorrecto";
            while (opcionTV == "incorrecto")
            {
                Console.WriteLine("* Desea que tenga TV? Ingrese SI o NO");
                opcionTV = Console.ReadLine();

                if (opcionTV.ToUpper().Trim() == "SI")
                {
                    tv = true;
                    opcionTV = "correcto";
                }
                else if (opcionTV.ToUpper().Trim() == "NO")
                {
                    tv = false;
                    opcionTV = "correcto";
                }
                else
                {
                    opcionTV = "incorrecto";
                }
            }
            return tv;
        }

        public static void crearCabania(Agencia a)
        {
            string ciudad = string.Empty;
            string barrio = string.Empty;
            string estrellas = string.Empty;
            int cantPersonas = 0;
            bool tv = false;
            int precioxDia = 0;
            int habitaciones = 0;
            int banios = 0;

            Console.WriteLine("*********** NUEVO CABAÑA ************");
            Console.WriteLine("*Ingrese Ciudad = ");
            ciudad = Console.ReadLine();
            Console.WriteLine("*Ingrese Barrio = ");
            barrio = Console.ReadLine();
            Console.WriteLine("*Ingrese Estrellas = ");
            estrellas = Console.ReadLine();
            Console.WriteLine("*Ingrese Limite de Personas = ");
            cantPersonas = verificarInt(Console.ReadLine());
            tv = seteoTv();
            Console.WriteLine("*Ingrese Precio por Dia= ");
            precioxDia = verificarInt(Console.ReadLine());
            Console.WriteLine("*Ingrese Numero de Habitacion = ");
            habitaciones = verificarInt(Console.ReadLine());
            Console.WriteLine("*Ingrese Numero de Baños = ");
            banios = verificarInt(Console.ReadLine());

            try
            {
                a.insertarAlojamiento(new Cabania(ciudad, barrio, estrellas, cantPersonas, tv, precioxDia, habitaciones, banios));
                Console.WriteLine("La cabaña se inserto con exito!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar alojamiento" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}


