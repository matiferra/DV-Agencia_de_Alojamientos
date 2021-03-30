using System;

namespace TP_1
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
                    opcion = menuAdministrador();
                    while (opcion != "X")
                    {
                        opcion = ingresarAlojamiento(opcion, agencia);
                    }
                }
                else if (opcion == "B")
                {
                    opcion = menuCliente();
                    while (opcion != "X")
                    {
                        opcion = listaDeAlojamiento(agencia);
                    }
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
            } while (opcion != "A" || opcion != "B" || opcion != "X");

            #region CODIGO COMENTADO
            /*
           Agencia a1 = new Agencia();
           Hotel h1 = new Hotel(1, "Buenos Aires", "Congreso", "dos", 50, true, 10);
           //Console.WriteLine(h1);
           a1.insertarAlojamiento(h1);

           Console.WriteLine("*********************");
           Hotel h2 = new Hotel(2, "Bariloche", "Cerro Otto", "cinco", 80, true, 15);
           //Console.WriteLine(h2);
           a1.insertarAlojamiento(h2);

           Console.WriteLine("*********************");
           Cabania c1 = new Cabania(1, "Mendoza", "Montaña", "tres", 12, false, 16000, 6, 2);
           //Console.WriteLine(c1);
           a1.insertarAlojamiento(c1);


           Console.WriteLine("*********************");
           Cabania c2 = new Cabania(2, "Salta", "Purmamarca", "cuatro", 10, false, 13000, 4, 2);
           //Console.WriteLine(c2);
           a1.insertarAlojamiento(c2);


           Console.WriteLine("*********************");
           Cabania c3 = new Cabania(3, "Ciudad de Cordoba", "Alberdi", "tres", 11, false, 12000, 5, 2);
           //Console.WriteLine(c3);
           a1.insertarAlojamiento(c3);


           Console.WriteLine("*********************");
           Console.WriteLine("*********ALOJAMIENTOS INSERTADOS************");

           foreach (var item in a1.alojamientosAgencia)
           {
               if( item != null)
               {
                   Console.WriteLine(item);
               }
           }

           Console.ReadLine();

           Console.WriteLine("*********************");

           Agencia soloHoteles = a1.soloHoteles();

           Console.WriteLine("********** SOLO HOTELES ***********");
           int x = 0;
           bool encontrado = true;
           while( soloHoteles.alojamientosAgencia.Length > x && encontrado == true )
           {
               Console.WriteLine(soloHoteles.alojamientosAgencia[x]);

               if (soloHoteles.alojamientosAgencia[x] == null)
               {
                   encontrado = false;
               }
               x++;
           }
           Console.ReadLine();

           Console.WriteLine("********** MAS DE 3 Estrellas ***********");
           Agencia masEstrellas = a1.masEstrellas(3);

           foreach (var item in masEstrellas.alojamientosAgencia)
           {
               if (item != null)
               {
                   Console.WriteLine(item);
               }
           }

           Console.ReadLine();

           Console.WriteLine("********** Cabania entre precio y precio ***********");
           Agencia cabaniasentrePrecios = a1.cabaniasentrePrecios(11000, 15000);

           foreach (var item in cabaniasentrePrecios.alojamientosAgencia)
           {
               if (item != null)
               {
                   Console.WriteLine(item);
               }
           }
           Console.ReadLine();
           Console.WriteLine("Hay Alojamiento? "+a1.hayAlojamiento());
           Console.WriteLine("Esta Llena? " + a1.estaLlena());

           */
            #endregion
        }

        public static string listaDeAlojamiento(Agencia agencia)
        {
            string result = string.Empty;
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

            Console.WriteLine("***************************************");
            Console.WriteLine("X - para volver");
            result = Console.ReadLine();
            return result.ToUpper().Trim();
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

        public static string menuAdministrador()
        {
            Console.WriteLine("\n***************************************");
            Console.WriteLine("**Opciones de Administrador************");
            Console.WriteLine("***************************************");
            Console.WriteLine("A - Insertar Alojamiento\n");
            Console.WriteLine("X - Volver");
            Console.WriteLine("***************************************");
            return Console.ReadLine().ToUpper().Trim();
        }

        public static string menuCliente()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("**Opciones de Cliente******************");
            Console.WriteLine("***************************************");
            Console.WriteLine("A - ver Alojamientos\n");
            Console.WriteLine("X - Volver");
            Console.WriteLine("***************************************");

            return Console.ReadLine();
        }
        #endregion


        public static string ingresarAlojamiento(string opcionAdmin, Agencia a)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("A - Insertar Hotel");
            Console.WriteLine("B - Insertar Cabaña\n");
            Console.WriteLine("x - Volver");
            Console.WriteLine("***************************************");
            opcionAdmin = Console.ReadLine();

            while (opcionAdmin != "X")
            {
                if (opcionAdmin.ToUpper().Trim() == "A")
                {
                    opcionAdmin = crearHotel(a);
                }
                else if (opcionAdmin.ToUpper().Trim() == "B")
                {
                    opcionAdmin = crearCabania(a);
                }
                else
                {
                    Console.WriteLine("VUELVA INGRESAR UNA OPCION CORRECTA");
                    opcionAdmin = Console.ReadLine();
                }
            }
            return menuAdministrador();
        }

        public static string crearHotel(Agencia a)
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
            cantPersonas = int.Parse(Console.ReadLine());
            tv = seteoTv();
            Console.WriteLine("*Ingrese Precio por Persona = ");
            precioxPersona = int.Parse(Console.ReadLine());
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
            return result;
        }

        private static bool seteoTv()
        {
            bool tv = false;
            string opcionTV = "incorrecto";
            while (opcionTV == "incorrecto")
            {
                Console.WriteLine("* Desea que tenga TV? Ingrese SI o NO");
                opcionTV = Console.ReadLine();

                if (opcionTV == "SI")
                {
                    tv = true;
                    opcionTV = "correcto";
                }
                else if (opcionTV == "NO")
                {
                    tv = false;
                    opcionTV = "correcto";
                }
            }
            return tv;
        }

        public static string crearCabania(Agencia a)
        {
            string result = string.Empty;
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
            cantPersonas = int.Parse(Console.ReadLine());
            tv = seteoTv();
            Console.WriteLine("*Ingrese Precio por Dia= ");
            precioxDia = int.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Numero de Habitacion = ");
            habitaciones = int.Parse(Console.ReadLine());
            Console.WriteLine("*Ingrese Numero de Baños = ");
            banios = int.Parse(Console.ReadLine());

            try
            {
                a.insertarAlojamiento(new Cabania(ciudad, barrio, estrellas, cantPersonas, tv, precioxDia, habitaciones, banios));
                Console.WriteLine("La cabaña se inserto con exito!!");
                result = "X";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar alojamiento" + ex.Message);
            }
            return result;

        }
    }
}


