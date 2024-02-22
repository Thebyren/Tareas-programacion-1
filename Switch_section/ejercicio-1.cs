using System;
class ejercicio
{
  public static void Main()
  {
    try
    {
      string[] numList = { "uno", "dos", "tres", "cuatro", "cinco" };
      Console.WriteLine("Escriba uno de los siguientes números: " + string.Join(", ", numList));
      string num = Console.ReadLine();
      switch (num)
      {
        case "uno":
          Console.WriteLine("Has escrito el 1");
          break;
        case "dos":
          Console.WriteLine("Has escrito el 2");
          break;
        case "tres":
          Console.WriteLine("Has escrito el 3");
          break;
        case "cuatro":
          Console.WriteLine("Has escrito el 4");
          break;
        case "cinco":
          Console.WriteLine("Has escrito el 5");
          break;
        default:
          Console.WriteLine("Se ha escrito un número incorrectamente");
          break;
      }
    }
    catch (System.Exception)
    {
      Console.WriteLine("Se ingresó algún dato erróneo");
    }
  }
}
