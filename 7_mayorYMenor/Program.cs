//¡Hola mundo!
Console.WriteLine("Hello, World!");
//---

//Ejercicio: Crear un programa que pida 3 valores "A", "B" y "C"., de esos 3 valores, debe decidir cuál es el mayor y cual es el menor.
//1. Declaramos la 3 variables.
int A, B, C;


//2. Pedimos los valores para los 3 valores.
Console.WriteLine("Deberá ingresar 3 valores (A, B, C), para poder ver cuál es el mayor y cual es el menor.");
Console.Write("Valor de A: "); A = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor de B: "); B = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor de C: "); C = Convert.ToInt32(Console.ReadLine());

//3. Verificamos cuál es el mayor y el menor.
//Verificamos que no sean iguales todos
if (!(A == B && A == C && C == B))
{
    //Verificamos que A sea la mayor
    if (A > B && A > C) //A
    {
        Console.WriteLine("A es el mayor de todos");

        //Miramos si C es el menor o B.
        if (B > C) Console.WriteLine("C es el menor de todos.");
        else Console.WriteLine("B es el menor de todos");
    }
    //Verificamos que B sea la mayor
    if (B > A && B > C) //B
    {
        Console.WriteLine("B es el mayor de todos");

        //Miramos si A es el menor o C.
        if (C > A) Console.WriteLine("A es el menor de todos.");
        else Console.WriteLine("C es el menor de todos");
    }
    //Verificamos que C sea la mayor
    if (C > A && C > B) //C
    {
        Console.WriteLine("C es el mayor de todos");

        //Miramos si B es el menor o A.
        if (A > B) Console.WriteLine("B es el menor de todos.");
        else Console.WriteLine("A es el menor de todos");
    }
}
else Console.WriteLine("Todos son iguales.");
//Para esperar y salir
Console.WriteLine("Presione cualquier tecla para salir."); Console.ReadKey();