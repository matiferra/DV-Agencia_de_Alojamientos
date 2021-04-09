Aclaraciones EJERCICIO 1

Respetamos el UML excepto por el método de la clase Alojamiento llamado igualCodigo.
El reemplazo consistió en volver estática la variable código la cual se va incrementando en cada construcción de un objeto de esta clase, con el fin de que no se repite el mismo código en dos objetos

Agregamos dos métodos más en la clase Agencia con el fin de subdividir la tarea del método masEstrellas que funciona como filtro de los Alojamientos que sean igual y superior a la cantidad de estrellas ingresadas por el usuario.

1 - public Agencia masEstrellas(int cantEstrellas){ }
Recibe del usuario el ingreso por teclado de un numero entero y este crea un objeto nuevo de Agencia que este a su vez posee un array llamado alojamientosAgencia al que llenamos de Alojamientos que cumplen con la condición.
Dentro del método tenemos un switch con los posibles ingresos de teclado del usuario y dentro de cada case utilizamos el siguiente método = "recolectar"

1-a private Alojamiento[] recolectar(int estrellas){ }

Este método recibe el parámetro de tipo entero que en verdad es el parámetro recibido en el método masEstrellas. 
Creamos un array de Alojamientos que va a sobre escribir el array que contiene el Objeto de tipo Agencia en el método masEstrellas. Dentro de este método utilizamos otro submétodo descripto abajo.

1-a private int conversionEntero(string atributo){ }

Este método recibe un parámetro de tipo string y lo convierte en entero pasando por los 10 casos posibles de ingresar el número de estrellas ya que el atributo de la clase Alojamiento llamado estrellas es de tipo string y el método masEstrellas recibe un parámetro de tipo entero.
por estrellas recibe un parámetro de tipo entero.

Otros agregados
En el Program o clase main agregamos varios métodos.
* Los de verificación usando try{ } catch() para atajar errores de ingresos de datos
* Los métodos para insertar Alojamientos como método de Administrador anidado dos métodos más que son "crearHotel" y "crearCabania"
* Sobrescribimos reutilizando los métodos de Agencia con el fin mostrar por consola los resultados según la opción que elija el Usuario en la clase Program.cs

También agregamos, comenzando con un if anidado y siguiendo con métodos anidados, el menú principal de selección de Usuario y métodos correspondiente para cada uno.

EJECUCION DEL PROGRAMA
Abrir solución "Plataformas TP 1" y compilar en el mismo Visual Studio 2019 o existe la posibilidad de crear archivos .exe por cada proyecto de la misma solución.
Generar archivo.exe:
	Clic derecho en proyecto => publicar => elegir carpeta => elegir destino => Finalizar. Luego clic en el botón Publicar.

FUNCIONAMIENTO
+ Elegir Usuario
A - Administrador contiene métodos de insertar Alojamientos ya sean Hoteles o Cabañas
B - Usuario contiene los siguientes de filtrado
	A - Ver Todos los Alojamientos
	B - Filtrar solo Hoteles
	C - Filtrar Cabaña según el precio deseado (requiere el ingreso de teclado de precio desde y precio hasta)
	D - Filtrar Alojamientos por estrellas (requiere el ingreso de un numero entero de cantidad de estrellas)

Para retroceder se usa la Opción "X"

==================================================================================================

EJERCICIO 2 

FUNCIONAMIENTO

- Elegir entre las opciones A y B
- En todo el funcionamiento del programa se cuenta con una opción X para salir o retroceder
A - Poblar centro cultural contiene los métodos para insertar Artistas, Esculturas o Cuadros divido por opciones:

A - Insertar Artista
B - Insertar Escultura
C - Insertar CuadroPrestado

B - Mostrar datos ingresados contiene los métodos que retornan los Artistas, Esculturas o Cuadros agregados en la opción A.

La opción B contiene los siguientes filtrados:
A - Mostrar todos
B - Mostrar Artista por orden Alfabético
C - Mostrar Obras ordenadas por año
D - Mostrar Obras de Artistas según Nacionalidad
E - Mostrar Cuadros de una misma Galería
F - Mostrar Todos los cuadros prestados
––
