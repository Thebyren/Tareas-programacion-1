using System;

class ejercicio
{
    static void Main()
    {

        Console.WriteLine("Ingrese el número para generar la tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
