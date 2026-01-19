namespace _5_NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //¡Hola Mundo!
            Console.WriteLine("Hello... perdón... ¡Hola Mundo!");

            //---
            /*
             * Ejercicio 5: Crear un programa que permita leer 2 números diferentes y nos diga cuál es el mayor de los 2.
             */
            int num1, num2;

            Console.WriteLine("Bienvenida/o, este programa consta de pedirá que ingrese 2 números, y se verificará cuál es el mayor.");
            Console.Write("Ingrese 1er número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese 2do número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*
            while (num1 == num2)
            {
                //limpiamos la consola.
                Console.Clear();
                //pedimos de nuevo los datos
                Console.Write("Ingrese 1er número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese 2do número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }*/

            if (num1 < num2)
            {
                Console.WriteLine("El \"num1\" es menor a \"num2\".");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El \"num1\" es mayor a \"num2\".");
            }
            else
            {
                Console.WriteLine("El \"num1\" es igual a \"num2\".");
            }

            //Para esperar y cerrar
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
