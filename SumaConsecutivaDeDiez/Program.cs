namespace SumaConsecutivaDeDiez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hola mundo!
            Console.WriteLine("¡Hola mundo!");
            /*
             * Ejercicio 4: Mostrar la suma de los 50 primeros números.
             */
            Console.WriteLine("Bienvenida/o, este programa consta de que mostrará la suma de los primeros 50.");
            int acumulador = 0;
            for (int contador = 0; contador < 51; contador++)
            {
                //Se acumula los números
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los primeros 50 son {acumulador}");
            Console.ReadKey();





        }
    }
}
