using System;

class ejercicio
{
  public static void Main()
  {
    string opt;
    int num, result = 1;
    do
    {
      Console.WriteLine("--------MENU--------");
      Console.WriteLine("Calcular un factorial de un numero:       1");
      Console.WriteLine("Calcular la raiz cuadrada de un numero:   2");
      Console.WriteLine("salir:                                    3");
      opt = Console.ReadLine();
      if (opt.Contains("1"))
      {
        Console.WriteLine("Escriba el numero que desea operar");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"el resultado es: {Factorial(num)}");
      }
      else if (opt.Contains("2"))
      {
        Console.WriteLine($"escirba el numero del cual va a calcular la raiz cuadrada");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"la raiz cuadrada de {num} es {Math.Sqrt(num)}");
      }
    } while (opt.Contains("1") || opt.Contains("2"));
  }
  static int Factorial(int n)
  {
    if (n == 0)
      return 1;
    return n * Factorial(n - 1);
  }
}