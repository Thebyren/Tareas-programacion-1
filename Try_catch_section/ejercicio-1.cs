using System.Text.RegularExpressions;
using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("Ingrese un numero:");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("vuelva a ingresar un numero:");
      int n2 = int.Parse(Console.ReadLine());
      Console.WriteLine("vuelva a ingresar otro numero:");
      int n3 = int.Parse(Console.ReadLine());
      Console.WriteLine("el numero mayor es: " + Math.Max(n1, Math.Max(n2, n3)));
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado algo diferente a un numero");
    }
  }
}
