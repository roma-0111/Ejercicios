namespace ParONoPar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 3: Verificar si el número ingresado es par o no.
             */
            //Iniciamos la variable a verificar
            int numIngresa, resultado;

            Console.WriteLine("Bienvenida/o, el programa consiste en que usted deberá ingresar 1 número y se omostrará si es para o no.");
            Console.Write("Ingrese el número: ");
            numIngresa = Convert.ToInt32(Console.ReadLine());

            //Operación
            resultado = numIngresa % 2;

            if (resultado == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }

            //Para esperar y cerrar
            Console.WriteLine("Presione cualquier tecla si consideró salir.");
            Console.ReadKey();
        }
    }
}
