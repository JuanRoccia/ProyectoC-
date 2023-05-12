namespace RegistroTesla
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        // ========================================================== //
        // Estructura para almacenar información de un Tesla
        struct TeslaInfo
        {
            public int Id;
            public string Model;
            public int Year;
            public double KmA;
            public double KmS;
            public string Color;
            public string Owner;
        }

        static void Main(string[] args)
        {
            // ========================================================== //
            // Lista para guardar en el registro de cada TeslaInfo
            List<TeslaInfo> teslaList = new List<TeslaInfo>();

            // Teslas por defecto
            TeslaInfo tesla1 = new TeslaInfo { Id = 1, Model = "S", Year = 2023, KmA = 10000, KmS = 15000, Color = "blue", Owner = "Pedro Perez" };
            TeslaInfo tesla2 = new TeslaInfo { Id = 2, Model = "X", Year = 2012, KmA = 20000, KmS = 25000, Color = "grey", Owner = "Rodrigo Ramirez" };
            TeslaInfo tesla3 = new TeslaInfo { Id = 3, Model = "Y", Year = 2017, KmA = 30000, KmS = 35000, Color = "red", Owner = "Pablo Torres" };
            teslaList.Add(tesla1);
            teslaList.Add(tesla2);
            teslaList.Add(tesla3);

            // Inicio del ID
            int id = 1;
            // Si la lista ya cuenta con objetos, el nuevo id debe ser el mayor
            if (teslaList.Count > 0)
            {
                int maxId = teslaList.Max(tesla => tesla.Id);
                id = maxId + 1;
            }
            // Inicio del bucle
            while (true)
            {
                // ========================================================== //
                // Menu de opciones:
                Console.WriteLine("\n¿Qué desea hacer?");
                Console.WriteLine("1. Dar de alta un tesla.");
                Console.WriteLine("2. Eliminar un tesla.");
                Console.WriteLine("3. Mostrar un listado de los Tesla ordenados por año.");
                Console.WriteLine("4. Reordenar por el listado de los Tesla por kms.");
                Console.WriteLine("5. Mostrar el Tesla más kms.");
                Console.WriteLine("6. Mostrar listado de teslas.");
                Console.WriteLine("7. Salir.\n");

                int option = int.Parse(Console.ReadLine());



                // ========================================================== //
                // Dar de alta un tesla.
                if (option == 1)
                {
                    Console.Write("Modelo: ");
                    string model = Console.ReadLine();

                    Console.Write("Año: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("Kilometraje Actual: ");
                    double kma = double.Parse(Console.ReadLine());

                    Console.Write("Kilometraje Service: ");
                    double kms = double.Parse(Console.ReadLine());

                    Console.Write("Color: ");
                    string color = Console.ReadLine();

                    Console.Write("Dueño: ");
                    string owner = Console.ReadLine();

                    // Crear un nuevo TeslaInfo y asignar los valores ingresados
                    TeslaInfo nuevoTesla = new TeslaInfo
                    {
                        Id = id,
                        Model = model,
                        Year = year,
                        KmA = kma,
                        KmS = kms,
                        Color = color,
                        Owner = owner
                    };

                    // Agregar el nuevo TeslaInfo a la lista general del registro
                    teslaList.Add(nuevoTesla);

                    // Incremeno del id
                    id += 1;
                }



                // ========================================================== //
                // Eliminar un tesla.
                if (option == 2)
                {
                    Console.WriteLine("Ingrese el ID del Tesla que desea eliminar:");
                    int idIngresado = int.Parse(Console.ReadLine());

                    // Buscar el Tesla a eliminar en la lista
                    TeslaInfo teslaAEliminar = teslaList.Find(tesla => tesla.Id == idIngresado);

                    teslaList.Remove(teslaAEliminar);

                    // Esto borra por posicion de listas
                    // teslaList.RemoveAt(idIngresado);
                }



                // ========================================================== //
                // Mostrar un listado de los Tesla ordenados por año.
                if (option == 3)
                {
                    // Ordenar la lista de Teslas por año
                    var teslaListOrdenada = teslaList.OrderBy(tesla => tesla.Year).ToList();

                    Console.WriteLine("\nContenido de la lista ordenada por año:");
                    foreach (TeslaInfo tesla in teslaListOrdenada)
                    {
                        Console.WriteLine($"ID: {tesla.Id}, Modelo: {tesla.Model}, Año: {tesla.Year}, Kilometraje Actual: {tesla.KmA}, Kilometraje Service: {tesla.KmS}, Color: {tesla.Color}, Dueño: {tesla.Owner}");
                    }
                }



                // ========================================================== //
                // Reordenar por el listado de los Tesla por kms.
                if (option == 4)
                {
                    // Ordenar la lista de Teslas por kilometraje
                    var teslaListOrdenada = teslaList.OrderBy(tesla => tesla.KmA).ToList();

                    Console.WriteLine("\nContenido de la lista ordenada por kilometraje actual:");
                    foreach (TeslaInfo tesla in teslaListOrdenada)
                    {
                        Console.WriteLine($"ID: {tesla.Id}, Modelo: {tesla.Model}, Año: {tesla.Year}, Kilometraje Actual: {tesla.KmA}, Kilometraje Service: {tesla.KmS}, Color: {tesla.Color}, Dueño: {tesla.Owner}");
                    }
                }



                // ========================================================== //
                // Mostrar el Tesla más kms.
                if (option == 5)
                {
                    // Encontrar el Tesla con más kilometraje
                    var teslaConMasKm = teslaList.OrderByDescending(tesla => tesla.KmS).First();

                    // Esto solo muestra el valor mas alto
                    //var teslaConMas = teslaList.Max(tesla => tesla.KmS);

                    Console.WriteLine("\nTesla con mayor kilometraje service:");
                    Console.WriteLine($"\nID: {teslaConMasKm.Id}\nModelo: {teslaConMasKm.Model}\nAño: {teslaConMasKm.Year}\nKilometraje Actual: {teslaConMasKm.KmA}\nKilometraje Service: {teslaConMasKm.KmS}\nColor: {teslaConMasKm.Color}\nDueño: {teslaConMasKm.Owner}");
                }


                // ========================================================== //
                // Para mostrar solo en opcion 1 o 2.
                if (option == 1 || option == 2 || option == 6)
                {
                    // Mostrar elementos de los TeslaInfo en la lista general
                    Console.WriteLine("\nContenido de la lista:");
                    foreach (TeslaInfo tesla in teslaList)
                    {
                        Console.WriteLine($"\nID: {tesla.Id},Modelo: {tesla.Model}Año: {tesla.Year}Kilometraje Actual: {tesla.KmA}Kilometraje Service: {tesla.KmS}Color: {tesla.Color}Dueño: {tesla.Owner}");
                    }
                    // Mostrar el número de elementos TeslaInfo en la lista
                    Console.WriteLine($"\nNúmero de Teslas en la lista: {teslaList.Count}");
                }

                // ========================================================== //
                // Finalizar el bucle.
                if (option == 7) { Console.WriteLine("\nHasta luego."); break; }

            }

        }
    }
}