namespace UsandoAlgunosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenida/o, se mostrará como es el funcionamiento de algunos métodos tratando con Strings.");
            string greeting = "      Hello World!       ";
            Console.WriteLine($"El texto a usar es \"{greeting}\"");

            //Quita espacio desde el inicio.
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Quita espacio del final.
            trimmedGreeting = greeting.TrimEnd(); 
            Console.WriteLine($"[{trimmedGreeting}]");

            //Quita espacio de los 2 lados.
            trimmedGreeting = greeting.Trim(); 
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
