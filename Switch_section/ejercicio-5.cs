using System;
class ejercicio
{
  public static void Main()
  {
    try
    {
      string[] noteList = { "Pasó con estilo" , "Chévere" , "Se la rifó", "No pasó de panzazo" };
      Console.WriteLine("Escriba la nota del examen:");
      int num = int.Parse(Console.ReadLine());
      switch (num)
      {
        case int n when (n >= 90 && n <= 100):
          Console.WriteLine(noteList[0]);
          break;
        case int n when (n >= 80 && n < 89):
          Console.WriteLine(noteList[1]);
          break;
        case int n when (n >= 70 && n < 79):
          Console.WriteLine(noteList[2]);
          break;
        case int n when (n < 70):
          Console.WriteLine(noteList[3]);
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
