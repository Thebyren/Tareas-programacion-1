using System;

class ejercicio
{
  public static void Main()
  {
    int sum = 0, n = 1;

    do
    {
      n++;
    } while (!(n % 11 == 0 && n % 7 == 0));
    sum = n;
    Console.WriteLine("El primer número divisible entre 7 y 11 es: " + sum);
  }
}
