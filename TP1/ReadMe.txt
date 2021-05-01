Aclaraciones EJERCICIO 1

Respetamos el UML excepto por el método de la clase Alojamiento llamado igualCodigo().
El reemplazo consistió en volver estática la variable código la cual se va incrementando en cada construcción de un objeto de esta clase, con el fin de que no se repita el mismo código en dos objetos diferentes.

Agregamos dos métodos más en la clase Agencia con el objetivo de subdividir la tarea del método masEstrellas() que funciona como filtro de los Alojamientos que tengan igual o superior cantidad de estrellas a las ingresadas por el usuario.

1 - public Agencia masEstrellas(int cantEstrellas){ }
Recibe del usuario el ingreso por teclado de un número entero y este crea un objeto nuevo de Agencia que a su vez posee un array llamado alojamientosAgencia[] al que llenamos de Alojamientos que cumplen con la condición.
Dentro del método tenemos un switch con los posibles ingresos de teclado del usuario y dentro de cada clase utilizamos el método recolectar().

1-a private Alojamiento[] recolectar(int estrellas){ }

Este método recibe un parámetro de tipo entero que es el mismo parámetro recibido en el método masEstrellas(). 
Creamos un array de Alojamientos que va a sobreescribir el array que contiene el Objeto de tipo Agencia en el método masEstrellas(). Dentro de este método utilizamos otro submétodo llamado conversionEntero().

1-a private int conversionEntero(string atributo){ }

Este método recibe un parámetro de tipo string y lo convierte en entero ya que el atributo de la clase Alojamiento llamado estrellas es de tipo string y el método masEstrellas() recibe un parámetro de tipo entero.

Otros agregados

En el Program o clase main agregamos varios métodos.

* Los de verificación usando try{ } catch() para atajar errores de ingresos de datos
* Los métodos para insertar Alojamientos como usuario Administrador anidando dos métodos más que son crearHotel() y crearCabania()
* Sobreescribimos reutilizando los métodos de Agencia con el fin de mostrar por consola los resultados según la opción que elija el Usuario.

También agregamos, comenzando con un if anidado y siguiendo con métodos anidados, el menú principal de selección de Usuario y métodos correspondientes para cada uno.




EJECUCIÓN DEL PROGRAMA

Abrir la solución "Plataformas TP 1" y compilar en el mismo Visual Studio 2019 o crear un archivo .exe por cada proyecto.
Generar archivo.exe:
	Click derecho en proyecto => publicar => elegir carpeta => elegir destino => Finalizar. Luego click en el botón Publicar.


FUNCIONAMIENTO

+ Elegir Usuario

A - Administrador contiene los métodos para insertar Alojamientos ya sean Hoteles o Cabañas
B - Usuario contiene las siguientes opciones de filtrado:
	A - Ver Todos los Alojamientos
	B - Filtrar solo Hoteles
	C - Filtrar Cabaña según el precio deseado (requiere el ingreso por teclado de precio desde y precio hasta)
	D - Filtrar Alojamientos por estrellas (requiere el ingreso de un número entero de cantidad de estrellas)

Para retroceder se usa la Opción "X" en todos los menús.


======================================================================

EJERCICIO 2 

Aclaraciones

En el UML dentro de la clase Cuadro existe un atributo llamado base, que hace referencia a la medida de la base de un objeto. Por ser “base” una palabra reservada en C#, definimos la variable con letra capital.

Otros agregados

En el Program o clase main agregamos varios métodos.

* Los de verificación usando try{ } catch() para atajar errores de ingresos de datos
* Los métodos para poblar el Centro Cultural utilizando los métodos creados en las clases ArtistaExposicion y ObraExposicion. 
* Reutilizamos los métodos de estas dos clases con el fin de mostrar por consola los resultados según la opción que elija el Usuario.

También agregamos el método menuBienvenida() que contiene el menú principal dentro del cual desarrollamos distintos métodos que a su vez contienen distintos submenús.



FUNCIONAMIENTO

- Elegir entre las opciones del menú principal.
- En todo el funcionamiento del programa se cuenta con una opción X para salir o retroceder

1 - Poblar Centro Cultural contiene los métodos para insertar objetos por consola. Las opciones son:

A - Insertar Artista
B - Insertar Escultura
C - Insertar CuadroPrestado

2 - Mostrar datos ingresados contiene los métodos que retornan los Artistas, Esculturas o Cuadros agregados en la opción 1.

Esta opción contiene los siguientes métodos para mostrar por pantalla:

A - Mostrar todos
B - Mostrar Artista por orden Alfabético
C - Mostrar Obras ordenadas por año
D - Mostrar Obras de Artistas según Nacionalidad. (Requiere el ingreso por teclado de una cadena de texto que especifique la nacionalidad) 
E - Mostrar Cuadros de una misma Galería  (Requiere el ingreso por teclado de una cadena de texto que especifique el nombre de la Galería)
F - Mostrar Todos los cuadros prestados

