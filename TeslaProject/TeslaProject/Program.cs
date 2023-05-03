using TeslaProject;

namespace TeslaProject
{
    
    internal class Program
    {
        public List<Tesla> teslas1 = new List<Tesla> { };
        static void Main(string[] args)

        {
            Tesla tesla1 = new Tesla("modelo1", 2023, "Ivan Gonzalo", "Azul");

            Console.WriteLine("BIENVENIDO AL PROGRAMA DE TESLA, INGRESE LA OPCION QUE DESDEA REALIZAR");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("1 - dar de alta un tesla");
            Console.WriteLine("2 - eliminar un tesla");
            Console.WriteLine("3 - mostrar listado tesla ordenado por año");
            Console.WriteLine("4 - mostrar listado tesla ordenado por kilometros");
            Console.WriteLine("5 - mostrar el tesla con mas km");
            Console.WriteLine("6 - mostrar la descripción de un tesla");
            Console.WriteLine("=======================================================================");
            string respuesta = Console.ReadLine();


            if (respuesta == "1")
            {
                Console.WriteLine("Va a dar de alta un tesla");
                //Tesla tesla1 = new Tesla("model1", 2023, "amarillo", "Juan Desages");
                //Console.WriteLine("Felicitaciones, diste de alta un tesla");
                Console.WriteLine("paso 1 de 6, ingrese el modelo:");
                string modelo = Console.ReadLine();

                Console.WriteLine("paso 2 de 6, ingrese el año: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("paso 3 de 6, ingrese el nombre y apellido del dueño: ");
                string owner = Console.ReadLine();

                Console.WriteLine("paso 4 de 6, ingrese el color: ");
                string color = Console.ReadLine();

                Console.WriteLine("paso 5 de 6, ingrese el kilometraje actual del vehiculo: ");
                int kmActual = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("paso 6 de 6, ingrese el kilometraje para realizar el proximo service: ");
                int kmService = Convert.ToInt32(Console.ReadLine());

                Tesla tesla2 = new Tesla(modelo, year, owner, color, kmActual, kmService);

            }
            else if
                (respuesta == "2")
            {
                Console.WriteLine("Ingrese el numero de tesla que desea eliminar");
                int valor = Convert.ToInt32(Console.ReadLine());

            } else if (respuesta == "3")
            {

                Console.WriteLine("listado de tesla ordenados por año");
            } else if (respuesta == "4")
            {
                Console.WriteLine("listado de tesla ordenados por kilometraje");
            } else if (respuesta == "5")
            {
                Console.WriteLine("tesla con mas kilometros");
            } else if(respuesta == "6")
            {
                tesla1.descripcion();
            }
            else
            {
                Console.WriteLine("La opción ingresada no es valida");
            }
            
            
        }

        public void agregarTesla(Tesla tesla1)
        {
            teslas1.Add(tesla1);
        }
        
    }
}

struct Tesla 
{
    private string model;
    private int year;
    private string color;
    private string owner;
    private int kmActual;
    private int kmService;  
    private int index = 0;

    //lista para agregar los teslas
    List<Tesla> teslas = new List<Tesla>();
    
    //el km actual y el km services, por defecto son 0 y 5000 respectivamente, ya que cuando instanciemos suponemos que es un tesla nuevo 0km
    public Tesla(string model, int year, string owner, string color, int kmActual = 0, int kmService = 5000)
    {
        this.index = index;
        index++;
        this.model = model;
        this.year = year;
        this.owner = owner;
        this.color = color;        
        this.kmActual = kmActual;
        this.kmService = kmService;

        teslas.Add(this);
        
        

    }

    public void descripcion()
    {
        Console.WriteLine("El tesla {0}, es año {1}, color: {2}, el dueño es: {3}, tiene {4}kms. y el proximo service es a los {5}", this.model, 
            this.year, this.color, this.owner, this.kmActual, this.kmService);
        
    }


    public void listadoTeslas()
    {
        teslas.ForEach((tesla) =>
        {
            Console.WriteLine(tesla.model);
            Console.WriteLine(tesla.year);
            Console.WriteLine(tesla.owner);
            Console.WriteLine(tesla.color);
        });
    }
    //eliminar un tesla por index.

    public void EliminarTesla(int indice)
    {
        teslas.RemoveAt(indice);
    }

    //mostrar un listado de los teslas

}