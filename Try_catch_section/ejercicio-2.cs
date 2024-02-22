using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("Ingrese tu edad para entrar al club:");
      int edad = int.Parse(Console.ReadLine());
      if (18 > edad)
      {
        Console.WriteLine("no puedes entrar");
      }
      else
      {
        Console.WriteLine("puedes entrar");
      }
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado algo diferente a un numero entero");
    }
  }
}
