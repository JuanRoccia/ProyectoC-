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

# Documentación del programa

Este programa permite realizar diferentes acciones sobre una colección de vehículos Tesla. Las principales funcionalidades son:

1. Dar de alta un nuevo Tesla.
2. Eliminar un Tesla existente.
3. Mostrar el listado de Teslas ordenados por año.
4. Mostrar el listado de Teslas ordenados por kilometraje.
5. Mostrar el Tesla con mayor kilometraje.
6. Mostrar la lista completa de Teslas.

La elección de implementar las funcionalidades de esta manera se basa en la simplicidad. El programa pide al usuario que ingrese la información necesaria cuando es necesario.

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

## Kilometraje del servicio - Nueva versión

El kilometraje para el próximo servicio, se calcula automáticamente. Para hacer esto, se toma el kilometraje actual, se divide por 10,000 (ignorando el residuo, porque estamos usando una división de enteros), se le suma 1 y luego se multiplica por 10,000. Este cálculo encuentra el próximo múltiplo de 10,000 después del kilometraje actual, que se utiliza como el kilometraje para el próximo servicio. 

## Kilometraje máximo

Para encontrar el Tesla con el mayor kilometraje, se crea una lista con los kilometrajes, se ordena y se toma el último elemento. Luego, se busca este kilometraje en la lista de Teslas para encontrar el Tesla correspondiente. Esta es una forma simple y efectiva de encontrar el Tesla con el mayor kilometraje.

## Notas

Además, cualquier cuestión que se asuma o necesite aclarar, está debidamente documentada en el código fuente.

## Autores

Fernandes Carlos Andres, Roccia Juan Manuel  y Tapia Ivan Gonzalo.
