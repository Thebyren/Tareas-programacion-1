using System;
class ejercicio
{
  public static void Main()
  {
    try
    {
      string[] serviceList = { "lavado de auto", "cambio de aceite", "revision mecanica" };
      Console.WriteLine("Escriba el número correspondiente al servicio:");
      for (int i = 0; i < serviceList.Length; i++)
      {
        Console.WriteLine("[  "+(i + 1) + " --- " + serviceList[i]+"  ]");
      }
      int num = int.Parse(Console.ReadLine());
      string msg1 = "ha seleccionado ";
      string msg2 = ". su importe a pagar es de: ";
      switch (num)
      {
        case 1:
          Console.WriteLine(msg1 + serviceList[0] + msg2 + "50");
          break;
        case 2:
          Console.WriteLine(msg1 + serviceList[1] + msg2 + "200");
          break;
        case 3:
          Console.WriteLine(msg1 + serviceList[2] + msg2 + "300");
          break;


        default:
          Console.WriteLine("Se ha escrito un numero fuera del rango");
          break;
      }
    }
    catch (System.Exception)
    {
      Console.WriteLine("Se ingresó algo diferente de un numero entero positivo");
    }
  }
}
