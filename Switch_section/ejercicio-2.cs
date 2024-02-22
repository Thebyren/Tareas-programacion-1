using System;
class ejercicio
{
  public static void Main()
  {
    try
    {
      string[] dayList = { "lunes","martes","miercoles","jueves","viernes","sabado","domingo" };
      Console.WriteLine("Escriba un numero del 1-7");
      int num = int.Parse(Console.ReadLine());
      const string msg = "el dia correspondiente es: ";
      switch (num)
      {
        case 1:
          Console.WriteLine(msg+dayList[0]);
          break;
        case 2:
          Console.WriteLine(msg+dayList[1]);
          break;
        case 3:
          Console.WriteLine(msg+dayList[2]);
          break;
        case 4:
          Console.WriteLine(msg+dayList[3]);
          break;
        case 5:
          Console.WriteLine(msg+dayList[4]);
          break;
        case 6:
          Console.WriteLine(msg+dayList[5]);
          break;
        case 7:
          Console.WriteLine(msg+dayList[6]);
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
