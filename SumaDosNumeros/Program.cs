

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");
        //Hola Mundo! usando una función.
        HolaMundo();
        void HolaMundo();
        {
            Console.Write("¡Hola Mundo!");
        }
        */

        /*
         * Ejercicio 1: Realizar un programa que nos sume dos números y nos dé el resultado en pantalla.
         */
        //Declaramos las variables a usar
        int num1, num2, resultado;

        //Bienvenida
        Console.WriteLine("Bienvenida/o, deberá ingresar 2 números para poder sumarlos!");
        //Pedimos que ingrese los datos de las variables
        Console.Write("Ingrese primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ahora ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //Sumamos los datos ingresados
        resultado = num1 + num2;


        //Mostramos el resultado
        Console.WriteLine("\nEl resultado es: " + resultado);
        //Te pide que ingreses un caracterer para salir
        Console.Write("\n\nPor favor, para salir presione \"ENTER\" (o cualquier tecla): ");

        //Para esperar y cerrar
        Console.ReadKey();
    }
}