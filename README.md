# ProyectoC# - Registro de Tesla
Proyecto 1 Tema 3

Este proyecto de consola en C# tiene como objetivo implementar un sistema básico para registrar información de vehículos Tesla. Fue desarrollado para cumplir con las pautas del Proyecto 1 Tema 3 del Grupo 35.

## Características

La primera versión del sistema incluye las siguientes funcionalidades:

1. Dar de alta un Tesla.
2. Eliminar un Tesla.
3. Mostrar un listado de los Tesla ordenados por año.
4. Reordenar por el listado de los Tesla por kilometraje.
5. Mostrar el Tesla con más kilometraje.

## Requisitos

- Se pueden usar listas.
- No se pueden usar clases, sólo `struct` y `enums`.

## Instrucciones

1. Descargue el archivo .ZIP o .RAR del proyecto.
2. Extraiga el contenido del archivo en una ubicación de su elección.
3. Abra la solución en Visual Studio u otro IDE compatible con C#.
4. Compile y ejecute el proyecto.
5. Siga las instrucciones en la consola para utilizar las funcionalidades del sistema.

## Fecha de apertura

Jueves, 27 de abril de 2023, 12:00 AM

## Fecha de entrega

Domingo, 14 de mayo de 2023, 11:59 PM

## Notas

Cualquier cuestión que se asuma o necesite aclarar, está debidamente documentada en el código fuente.

## Autores

Fernandes Carlos Andres, Roccia Juan Manuel  y Tapia Ivan Gonzalo.

# Documentación del programa

Este programa permite realizar diferentes acciones sobre una colección de vehículos Tesla. Las principales funcionalidades son:

1. Dar de alta un nuevo Tesla.
2. Eliminar un Tesla existente.
3. Mostrar el listado de Teslas ordenados por año.
4. Mostrar el listado de Teslas ordenados por kilometraje.
5. Mostrar el Tesla con mayor kilometraje.
6. Mostrar la lista completa de Teslas.

## Dar de alta un nuevo Tesla

Para dar de alta un nuevo Tesla, el usuario debe ingresar los datos requeridos, que incluyen el modelo, el año, el kilometraje actual, el color y el nombre del propietario. El ID se genera automáticamente y el kilometraje para el próximo servicio se calcula sumando 5000 km al kilometraje actual.

## Eliminar un Tesla

Para eliminar un Tesla, el usuario debe ingresar el ID del Tesla que desea eliminar. El programa busca este ID en la lista de Teslas y, si lo encuentra, elimina el Tesla correspondiente.

## Ordenar los Teslas

El programa puede mostrar los Teslas ordenados por año o por kilometraje. En ambos casos, se crea una nueva lista con los años o los kilometrajes, se ordena esta lista y luego se usa para reordenar la lista original de Teslas.

## Kilometraje del servicio

Cuando se da de alta un nuevo Tesla, se establece un kilometraje para el próximo servicio. Este se calcula sumando 5000 km al kilometraje actual. Esto significa que, según el programa, cada Tesla necesita un servicio cada 5000 km.

## Kilometraje máximo

El programa puede mostrar el Tesla con el mayor kilometraje. Para hacer esto, se crea una lista con los kilometrajes de todos los Teslas, se ordena y se toma el último elemento. Luego, se busca este kilometraje en la lista de Teslas para encontrar el Tesla correspondiente.

## Decisiones de implementación

La elección de implementar las funcionalidades de esta manera se basa en la simplicidad.El programa pide al usuario que ingrese la información necesaria cuando es necesario.

Por otro lado, se podría mejorar la forma en que se manejan los datos en el programa. Actualmente, se usan listas de cadenas para representar a cada Tesla, lo cual puede ser confuso y propenso a errores. Sería más apropiado usar una clase `Tesla` con propiedades para cada uno de los campos que se manejan.

Además, se podrían agregar más validaciones para los datos ingresados por el usuario para asegurar que sean correctos y coherentes. Por ejemplo, se podría verificar que el año y el kilometraje sean números positivos, que el modelo sea uno de los modelos existentes de Tesla, etc.

# Justificación de las decisiones de implementación

## Estructura de datos

Se optó por utilizar listas de strings para representar los datos de cada Tesla. Esta es una opción simple y directa que facilita la interacción con el usuario a través de la consola ya que almacena todos los datos como strings.

## Interacción con el usuario

El programa en cada paso, le pide al usuario que ingrese la información necesaria y muestra mensajes claros para indicar lo que está sucediendo.

## Ordenación de los Teslas

Para ordenar los Teslas por año o por kilometraje, se decidió crear una lista separada con los años o los kilometrajes, ordenar esta lista y luego usarla para reordenar la lista original de Teslas. Este enfoque es simple y efectivo.

## Kilometraje del servicio

Se estableció que cada Tesla necesita un servicio cada 5000 km. Esto es una simplificación y podría no ser adecuado en la vida real. Sin embargo, para los fines de este programa, es una opción razonable que facilita la implementación.

## Kilometraje máximo

Para encontrar el Tesla con el mayor kilometraje, se crea una lista con los kilometrajes, se ordena y se toma el último elemento. Luego, se busca este kilometraje en la lista de Teslas para encontrar el Tesla correspondiente. Esta es una forma simple y efectiva de encontrar el Tesla con el mayor kilometraje.


