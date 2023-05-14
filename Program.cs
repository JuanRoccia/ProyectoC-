namespace TeslaProject
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo listas que van a contener los datos de cada tesla:
            //ID|modelo|año   |kmActual |kmService|color| nombre dueño;
            List<string> tesla1 = new List<string>() { "0", "S", "2021", "10000", "20000", "BLUE", "PEDRO PEREZ" };
            List<string> tesla2 = new List<string>() { "1", "X", "2021", "20000", "30000", "GREY", "RODRIGO RAMIREZ" };
            List<string> tesla3 = new List<string>() { "2", "Y", "2017", "35000", "40000", "RED", "PABLO TORRES" };
            List<string> tesla4 = new List<string>() { "3", "3", "2016", "45000", "50000", "GREEN", "EZEQUIEL RAMIREZ" };
            List<string> tesla5 = new List<string>() { "4", "Y", "2017", "55000", "60000", "BLACK", "FRANCO GUTIERREZ" };

            // Creo una lista de listas para ir guardando listas pertenecientes a cada tesla
            List<List<string>> listOfTeslas = new List<List<string>>();

            // Agrego cada tesla a la lista de teslas con List.Add();
            listOfTeslas.Add(tesla1);
            listOfTeslas.Add(tesla2);
            listOfTeslas.Add(tesla3);
            listOfTeslas.Add(tesla4);
            listOfTeslas.Add(tesla5);

            // ID DE TESLAS, comienza en 5 ya que anteriormente creamos los primeros teslas
            int id = 5;

            // Con el bucle while controlamos la ejecución del programa
            while (true)
            {
                Console.WriteLine("=======================================================================");
                Console.WriteLine("BIENVENIDO AL PROGRAMA DE TESLA, INGRESE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine("=======================================================================");
                Console.WriteLine("1 - dar de alta un tesla");
                Console.WriteLine("2 - eliminar un tesla");
                Console.WriteLine("3 - mostrar listado tesla ordenado por año");
                Console.WriteLine("4 - mostrar listado tesla ordenado por kilometros");
                Console.WriteLine("5 - mostrar el tesla con mas km");
                Console.WriteLine("6 - ver lista completa de teslas");
                Console.WriteLine("7 - salir del programa");
                Console.WriteLine("=======================================================================");
                string respuesta = Console.ReadLine();

                // OPCIÓN 1 DAR DE ALTA UN TESLA
                if (respuesta == "1")
                {
                    // Creo una lista para ir guardando los datos del tesla que voy a dar de alta
                    List<string> newTesla = new List<string>() { };

                    Console.WriteLine("Va a dar de alta un tesla");

                    // ID a string
                    string stringID = id.ToString();
                    newTesla.Add(stringID);

                    // Voy asignando variables que ingresa el usuario, con .Add(variable), a la lista newTesla creada anteriormente
                    Console.WriteLine("Paso 1 de 5, ingrese el modelo: ");
                    string modelo = Console.ReadLine();
                    newTesla.Add(modelo.ToUpper());

                    Console.WriteLine("Paso 2 de 5, ingrese el año: ");
                    string year = Console.ReadLine();
                    newTesla.Add(year);

                    Console.WriteLine("Paso 3 de 5, ingrese el kilometraje actual del vehiculo: ");
                    // Este dato debe ser un número obligatoriamente, ya que luego se realizarán operaciones matemáticas con el mismo
                    string kmActual = Console.ReadLine();
                    newTesla.Add(kmActual);

                    // Se implementa la lógica que el km de service sea cada 10000km(sería a los 10, 20, 30, 40mil, etc.)
                    // Se busca el siguiente multiplo de 10000, utilizando int.Parse(), dividimos por 10mil, le sumamos 1 y lo multiplicamos por 10000
                    int kmService = (int.Parse(kmActual) / 10000 + 1) * 10000;
                    newTesla.Add(Convert.ToString(kmService));
                    Console.WriteLine($"El próximo service es a los: {kmService}km.");

                    Console.WriteLine("Paso 4 de 5, ingrese el color: ");
                    string color = Console.ReadLine();
                    newTesla.Add(color.ToUpper());

                    Console.WriteLine("Paso 5 de 6, ingrese el nombre y apellido del dueño: ");
                    string owner = Console.ReadLine();
                    newTesla.Add(owner.ToUpper());


                    // Agrego la lista newTesla a la lista de teslas general(listOfTeslas)
                    listOfTeslas.Add(newTesla);

                    Console.WriteLine("Agregó un tesla correctamente");

                    // Incrementamos el id cada vez que almacenamos un tesla
                    id += 1;
                }
                // FIN OPCIÓN 1

                // OPCIÓN 2 ELIMINAR UN TESLA
                else if
                    (respuesta == "2")
                {
                    // Mostrar id's disponibles
                    Console.WriteLine("ID's de Teslas disponibles");
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {
                        Console.Write(listOfTeslas[i][0] + " | ");
                    }

                    // Voy a eliminar por índice de la lista listOfTeslas con RemoveAt(), utilizando el ID de tesla
                    Console.Write("\nIngrese el ID del tesla que desea eliminar: ");
                    string var = Console.ReadLine();

                    bool idEncontrado = false;

                    // Voy a recorrer la lista de teslas y buscar el ID ingresado que coincida con ID de tesla
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {
                        if (listOfTeslas[i][0] == var)
                        {
                            // Voy a eliminar la lista cuyo ID coincida con la posición en listOfTeslas
                            listOfTeslas.RemoveAt(i);
                            Console.WriteLine($"Eliminó el tesla con ID: {var}");
                            idEncontrado = true;
                            break;
                        }
                    }

                    if (!idEncontrado)
                    {
                        Console.WriteLine("Debe ingresar un número ID que coincida con un tesla.");
                    }
                }
                // FIN OCPIÓN 2

                // OPCIÓN 3 MOSTRAR EL LISTADO ORDENADO POR AÑO
                else if (respuesta == "3")
                {
                    Console.WriteLine("Listado de tesla ordenados por año");

                    List<int> listanio = new List<int>();

                    int anio;
                    // Con el índice de los años,creo una lista 
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {

                        anio = Convert.ToInt32(listOfTeslas[i][2]);
                        listanio.Add(anio);
                    }

                    // Ordeno la lista
                    listanio.Sort();


                    List<List<string>> listastring = listOfTeslas;
                    List<List<string>> nuevalista = new List<List<string>>();
                    string valorstr;

                    // Se rearma la lista original, por orden de año
                    for (int j = 0; j < listOfTeslas.Count; j++)
                    {
                        valorstr = Convert.ToString(listanio[j]);

                        for (int i = 0; i < listOfTeslas.Count; i++)
                        {

                            if (listOfTeslas[i].Contains(valorstr))
                            {
                                // Si el valor no existe se agrega a la lista(evita repetidos)
                                if (nuevalista.Contains(listOfTeslas[i]) == false)
                                {
                                    nuevalista.Add(listOfTeslas[i]);
                                }
                            }
                        }
                    }

                    // Imprimo la lista en orden
                    foreach (var list in nuevalista)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("=======================================================================");

                }
                //FIN OPCIÓN 3

                //OPCIÓN 4 MOSTRAR EL LISTADO ORDENADO POR KILOMETRAJE
                else if (respuesta == "4")
                {
                    Console.WriteLine("listado de tesla ordenados por kilometraje");
                    List<int> listakm = new List<int>();
                    int km;
                    // Con el índice de los km,creo una lista 
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {

                        km = Convert.ToInt32(listOfTeslas[i][3]);
                        listakm.Add(km);
                    }
                    listakm.Sort();
                    List<List<string>> listastringkm = listOfTeslas;
                    List<List<string>> nuevalistakm = new List<List<string>>();
                    string valorstrkm;
                    for (int j = 0; j < listOfTeslas.Count; j++)
                    {
                        valorstrkm = Convert.ToString(listakm[j]);

                        for (int i = 0; i < listOfTeslas.Count; i++)
                        {

                            if (listOfTeslas[i].Contains(valorstrkm))
                            {
                                // Si el valor no existe se agrega a la lista(evita repetidos)
                                if (nuevalistakm.Contains(listOfTeslas[i]) == false)
                                {
                                    nuevalistakm.Add(listOfTeslas[i]);
                                }
                            }
                        }
                    }
                    foreach (var list in nuevalistakm)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("=======================================================================");

                }
                // FIN OPCIÓN 4

                // ÓPCION 5 MOSTRAR EL TESLA CON MAS KM
                else if (respuesta == "5")
                {
                    Console.WriteLine("tesla con mas kilometros");
                    List<int> listakm = new List<int>();
                    int km;
                    // Con el índice de los km,creo una lista 
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {

                        km = Convert.ToInt32(listOfTeslas[i][3]);
                        listakm.Add(km);
                    }

                    // Se ordena la lista
                    listakm.Sort();
                    // Agarro el último valor de la lista ordenada
                    string ultimo = Convert.ToString(listakm[listakm.Count - 1]);
                    // Busco ese valor en la lista de teslas
                    List<string> ult = listOfTeslas.Find(x => x.Contains(ultimo));

                    Console.WriteLine($" Modelo: {ult[1]}, Kms: {ult[3]}, Año: {ult[2]}, Dueño: {ult[6]}");

                }
                // FIN OPCIÓN 5

                // OPCIÓN 6 VER LISTADO DE TESLAS
                else if (respuesta == "6")
                {
                    // Se recorre la lista de teslas, y se separa cada elemento de cada tesla con una ", " usando .Join()
                    foreach (var list in listOfTeslas)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                }
                // FIN OPCIÓN 6

                // OPCIÓN 7 CERRAR EL PROGRAMA
                else if (respuesta == "7")
                {
                    Console.WriteLine("Hasta luego");
                    break;
                }
                //FIN OPCIÓN 7

                //OPCIÓN AUXILIAR O NO VALIDA
                else
                {
                    Console.WriteLine("La opción ingresada no es valida");
                }
                //FIN OPCIÓN AUX.
            }
        }

    }

}