namespace UsandoAlgunosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quita los espacios
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart(); //Quita espacio desde el inicio.
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd(); //Quita espacio del final.
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim(); //Quita espacio de los 2 lados.
            Console.WriteLine($"[{trimmedGreeting}]");

            //---

            //Reemplaza Strings
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings"); //Reemplaza "Hello" por "Greetings"
            Console.WriteLine(sayHello);

            //---

            //Usando minúsculas y mayúsculas.
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Para esperar y salir
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
