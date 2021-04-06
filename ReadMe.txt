Aclaraciones EJERCICIO 1

Respetamos el UML excepto por el metodo de la clase Alojamiento llamado igualCodigo.
El remplazo consistio en volver estatica la variable codigo la cual se va incrementando en cada costruccion de un objeto de esta clase, con el fin de que no se repite el mismo codigo en dos objetos

Agregamos dos metodos mas en la clase Agencia con el fin de subdividir la tarea del metodo masEstrellas que funciona como filtro de los Alojamientos que sean igual y superior a la cantidad de estrellas ingresadas por el usuario.

1 - public Agencia masEstrellas(int cantEstrellas){ }
Recibe del usuario el ingreso por teclado de un numero entero y este crea un objeto nuevo de Agencia que este a su vez posee un array llamado alojamientosAgencia al que llenamos de Alojamientos que cumplen con la condicion.
Dentro del metodo tenemos un switch con los posibles ingresos de teclado del usuario y dentro de cada case utilizamos el siguiente metodo = "recoletar"

1-a private Alojamiento[] recolectar(int estrellas){ }

Este metodo recibe el parametro de tipo entero que en verdad es el parametro recibido en el metodo masEstrellas. 
Creamos un array de Alojamientos que va a sobreescribir el array que contiene el Objeto de tipo Agencia en el metodo masEstrellas. Dentro de este metodo utilizamos otro submetodo descripto abajo.

1-a private int conversionEntero(string atributo){ }

Este metodo recibe un parametro de tipo string y lo convierte en entero pasando por los 10 casos posibles de ingresar el numero de estrellas ya que el atributo de la clase Alojamiento llamado estrellas es de tipo string y el metodo masEstrellas recibe un parametro de tipo entero.
por estrellas recibe un parametro de tipo entero.

Otros agregados
En el Program o clase main agregamos varios metodos.
* Los de verificacion usando try{ } catch() para atajar errores de ingresos de datos
* Los metodos para insertar Alojamientos como metodo de Administrador anidado dos metodos mas que son "crearHotel" y "crearCabania"
* Sobreescribimos reutilazando los metodos de Agencia con el fin mostrar por consola los resultados segun la opcion que elija el Usuario.

Tambien agregamos, comenzando con un if anidado y siguiendo con metodos anidados, el menu principal de seleccion de Usuario y metodos correspondiesta para cada uno.

EJECUCION DEL PROGRAMA
Abrir solucion "Plataformas TP 1" y compilar en el mismo Visual Studio 2019 o existe la posibilidad de crear archivos .exe por cada proyecto de la misma solucion.
Generar archivo.exe:
	Click derecho en proyecto => publicar => elegir carpeta => elegir destino => Finalizar. Luego click en el boton Publicar.

FUNCIONAMIENTO
+ Elegir Usuario
A - Administrador contiene metodos de insertar Alojamientos ya sean Hoteles o Cabañas
B - Usuario contiene los siguientes de filtrado
	A - Ver Todos los Alojamientos
	B - Filtrar solo Hoteles
	C - Filtrar Cabaña segun el precio deseado (requiere el ingreso de teclado de precio desde y precio hasta)
	D - Filtrar Alojamientos por estrellas (requiere el ingreso de un numero entero de cantidad de estrellas)

Para retrocer se usa la Opcion "X"

