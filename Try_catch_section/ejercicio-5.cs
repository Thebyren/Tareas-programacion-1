using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("Ingrese un numero:");
      int num= int.Parse(Console.ReadLine());
      if(num %2 == 0){
        Console.WriteLine("el numero es par");
      }
      else{
        Console.WriteLine("el numero es impar");
      }
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado un algo diferente a un numero entero positivo");
    }
  }
}
