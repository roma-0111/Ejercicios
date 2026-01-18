namespace AreaDeUnTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 2: Un programa que muestre el resultado del área de un triángulo en pantalla.
             */
            //Inicializamos las Variables
            int x, y, area;

            //Contexto
            Console.WriteLine("Hola, esto es un programa que realiza el area de un triángulo con los números de \"x\" y \"y\".");
            
            //Pedir datos
            Console.Write("Ingrese la x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la y: ");
            y = Convert.ToInt32(Console.ReadLine());

            //Operación
            area = (x * y) / 2;

            //Mostramos el resultado
            Console.WriteLine($"El area del triángulo es: {area}");

            //Para esperar y cerrar
            Console.ReadKey();
        }
    }
}
