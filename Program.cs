namespace TeslaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo listas que van a contener los datos de cada tesla, el primer valor de la lista es el ID

            List<string> tesla1 = new List<string>() { "0", "S", "2021", "10000", "15000", "BLUE", "PEDRO PEREZ" };
            List<string> tesla2 = new List<string>() { "1", "X", "2021", "20000", "25000", "GREY", "RODRIGO RAMIREZ" };
            List<string> tesla3 = new List<string>() { "2", "Y", "2017", "30000", "35000", "RED", "PABLO TORRES" };
            List<string> tesla4 = new List<string>() { "3", "3", "2016", "40000", "45000", "GREEN", "EZEQUIEL RAMIREZ" };
            List<string> tesla5 = new List<string>() { "4", "Y", "2017", "50000", "55000", "BLACK", "FRANCO GUTIERREZ" };

            //creo una lista de listas para ir guardando listas pertenecientes a cada tesla
            List<List<string>> listOfTeslas = new List<List<string>>();

            //agrego cada tesla a la lista de teslas con List.Add();
            listOfTeslas.Add(tesla1);
            listOfTeslas.Add(tesla2);
            listOfTeslas.Add(tesla3);
            listOfTeslas.Add(tesla4);
            listOfTeslas.Add(tesla5);

            //ID DE TESLAS, comienza en 5 ya que anteriormente creamos los primeros teslas
            int id = 5;

            //Con el bucle while controlamos la ejecución del programa
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

                //OPCION 1 DAR DE ALTA UN TESLA
                if (respuesta == "1")
                {
                    //creo una lista para ir guardando los datos del tesla que voy a dar de alta
                    List<string> newTesla = new List<string>() { };

                    Console.WriteLine("Va a dar de alta un tesla");

                    // ID a string
                    string stringID = id.ToString();
                    newTesla.Add(stringID);

                    //voy asignando variables que ingresa el usuario, con .Add(variable), a la lista newTesla creada anteriormente
                    Console.WriteLine("paso 1 de 6, ingrese el modelo: ");
                    string modelo = Console.ReadLine();
                    newTesla.Add(modelo.ToUpper());

                    Console.WriteLine("paso 2 de 6, ingrese el año: ");
                    string year = Console.ReadLine();
                    newTesla.Add(year);

                    Console.WriteLine("paso 3 de 6, ingrese el kilometraje actual del vehiculo: ");

                    string kmActual = Console.ReadLine();
                    newTesla.Add(kmActual);

                    Console.WriteLine("paso 4 de 6,  el kilometraje para realizar el proximo service: ");
                    //Se busca el siguiente multiplo de 10000, utilizando int.Parse(), dividimos por 10mil, le sumamos 1 y lo multiplicamos por 10000
                    int kmService = (int.Parse(kmActual) / 10000 + 1) * 10000;
                    newTesla.Add(Convert.ToString(kmService));
                    Console.WriteLine($"PROXIMO SERVICE A LOS: {kmService}");

                    Console.WriteLine("paso 5 de 6, ingrese el color: ");
                    string color = Console.ReadLine();
                    newTesla.Add(color.ToUpper());

                    Console.WriteLine("paso 6 de 6, ingrese el nombre y apellido del dueño: ");
                    string owner = Console.ReadLine();
                    newTesla.Add(owner.ToUpper());


                    //agrego la lista newTesla a la lista de teslas general(listOfTeslas)
                    listOfTeslas.Add(newTesla);

                    Console.WriteLine("Agrego un tesla correctamente");

                    //incrementamos el id cada vez que almacenamos un tesla
                    id += 1;
                }
                //FIN OPCION 1

                //OPCION 2 ELIMINAR UN TESLA
                else if
                    (respuesta == "2")
                {
                    // Mostrar id's disponibles
                    Console.WriteLine("ID's de Tesla disponibles");
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {
                        Console.Write(listOfTeslas[i][0] + " | ");
                    }

                    //voy a eliminar por indice de la lista listOfTeslas con RemoveAt(), utilizando el ID de tesla
                    Console.Write("\nIngrese el ID del tesla que desea eliminar: ");
                    string var = Console.ReadLine();

                    bool idEncontrado = false;

                    //voy a recorrer la lista de teslas y buscar el ID ingresado que coincida con ID de tesla
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {
                        if (listOfTeslas[i][0] == var)
                        {
                            //voy a eliminar la lista cuyo ID coincida con la posicion en listOfTeslas
                            listOfTeslas.RemoveAt(i);
                            Console.WriteLine($"Elimino el tesla con ID: {var}");
                            idEncontrado = true;
                            break;
                        }
                    }

                    if (!idEncontrado)
                    {
                        Console.WriteLine("Debe ingresar un numero id que coincida con un tesla");
                    }
                }
                //FIN OCPION 2

                //OPCION 3 MOSTRAR EL LISTADO ORDENADO POR AÑO
                else if (respuesta == "3")
                {
                    Console.WriteLine("listado de tesla ordenados por año");

                    List<int> listanio = new List<int>();

                    int anio;
                    //con el indice de los años,creo una lista 
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {

                        anio = Convert.ToInt32(listOfTeslas[i][2]);
                        listanio.Add(anio);
                    }

                    //Ordeno la lista
                    listanio.Sort();


                    List<List<string>> listastring = listOfTeslas;
                    List<List<string>> nuevalista = new List<List<string>>();
                    string valorstr;

                    //se rearma la lista original, por orden de año
                    for (int j = 0; j < listOfTeslas.Count; j++)
                    {
                        valorstr = Convert.ToString(listanio[j]);

                        for (int i = 0; i < listOfTeslas.Count; i++)
                        {

                            if (listOfTeslas[i].Contains(valorstr))
                            {
                                //si el valor no existe se agrega a la lista(evita repetidos)
                                if (nuevalista.Contains(listOfTeslas[i]) == false)
                                {
                                    nuevalista.Add(listOfTeslas[i]);
                                }
                            }
                        }
                    }

                    //imprimo la lista en orden
                    foreach (var list in nuevalista)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("=======================================================================");

                }
                //FIN OPCION 3

                //OPCION 4 MOSTRAR EL LISTADO ORDENADO POR KILOMETRAJE
                else if (respuesta == "4")
                {
                    Console.WriteLine("listado de tesla ordenados por kilometraje");
                    List<int> listakm = new List<int>();
                    int km;
                    //con el indice de los km,creo una lista 
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
                                //si el valor no existe se agrega a la lista(evita repetidos)
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
                //FIN OPCION 4

                //OPCION 5 MOSTRAR EL TESLA CON MAS KM
                else if (respuesta == "5")
                {
                    Console.WriteLine("tesla con mas kilometros");
                    List<int> listakm = new List<int>();
                    int km;
                    //con el indice de los km,creo una lista 
                    for (int i = 0; i < listOfTeslas.Count; i++)
                    {

                        km = Convert.ToInt32(listOfTeslas[i][3]);
                        listakm.Add(km);
                    }

                    listakm.Sort();

                    string ultimo = Convert.ToString(listakm[listakm.Count - 1]);

                    List<string> ult = listOfTeslas.Find(x => x.Contains(ultimo));

                    Console.WriteLine($" Modelo: {ult[1]}, Kms: {ult[3]}, Año: {ult[2]}, Dueño: {ult[6]}");

                }
                //FIN OPCION 5

                //OPCION 6 VER LISTADO DE TESLAS
                else if (respuesta == "6")
                {
                    foreach (var list in listOfTeslas)
                    {
                        Console.WriteLine(String.Join(", ", list));
                    }
                }
                //FIN OPCION 6

                //OPCION 7 CERRAR EL PROGRAMA
                else if (respuesta == "7")
                {
                    Console.WriteLine("Hasta luego");
                    break;
                }
                //FIN OPCION 7

                //OPCION AUXILIAR O NO VALIDA
                else
                {
                    Console.WriteLine("La opción ingresada no es valida");
                }
                //FIN OPCION AUX.

            }

        }

    }

}