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
                    while (opcion != "S")
                    {
                        opcion = menuVerAlojamientos();
                        if(opcion == "A")
                        {
                            opcion = listaDeAlojamiento(agencia);

                        }else if(opcion == "B")
                        {
                            opcion = soloHoteles(agencia);

                        }
                        else if (opcion == "C")
                        {
                            opcion = cabaniasentrePrecios(agencia);
                        }
                        else if (opcion == "D")
                        {
                            opcion = masEstrellas(agencia);
                        }
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
        public static string cabaniasentrePrecios(Agencia agencia)
        {
            string result = string.Empty;
            Agencia temp = new Agencia();
            double desde;
            double hasta;

            Console.WriteLine("Ingrese precio desde");
            desde = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese precio hasta");
            hasta = double.Parse(Console.ReadLine());

            temp = agencia.cabaniasentrePrecios(desde, hasta);
            foreach (var item in temp.alojamientosAgencia)
            {
                if(item != null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("***************************************");
            Console.WriteLine("X - para volver");
            result = Console.ReadLine();
            return result.ToUpper().Trim();

        }

        public static string soloHoteles(Agencia agencia)
        {
            string result = string.Empty;
            Agencia temp = new Agencia();
            temp = agencia.soloHoteles();
            foreach (var item in temp.alojamientosAgencia)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("***************************************");
            Console.WriteLine("X - para volver");
            result = Console.ReadLine();
            return result.ToUpper().Trim();
        }
        public static string masEstrellas(Agencia agencia)
        {
            string result = string.Empty;
            Agencia temp = new Agencia();
            int cantEstrellas;


            Console.WriteLine("Ingrese a partir de cuantas estrellas");
            cantEstrellas = int.Parse(Console.ReadLine());


            temp = agencia.masEstrellas(cantEstrellas);
            foreach (var item in temp.alojamientosAgencia)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
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

        public static string menuVerAlojamientos()
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


