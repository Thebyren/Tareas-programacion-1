using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("escriba una de las siguientes figuras geometricas [ triangulo, cuadrado, circulo]:");
      string figure = Console.ReadLine();
      switch (figure)
      {
        case "triangulo":
          Console.WriteLine("ingrese la altura del triangulo");
          int altura = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese la base del triangulo");
          int _base = int.Parse(Console.ReadLine());

          Console.WriteLine("el area del triangulo es: "+(altura*_base));
          break;
        case "cuadrado":
        Console.WriteLine("ingrese la altura del cuadrado");
          altura = int.Parse(Console.ReadLine());
          Console.WriteLine("el area del cuadrado es: "+(altura*altura));
          break;
        case "circulo":
        Console.WriteLine("ingrese el radio del circulo");
          int radio= int.Parse(Console.ReadLine());
          Console.WriteLine("el area del circulo es: "+(Math.PI*radio*radio));
          break;
        default:
          Console.WriteLine("ha ingresado una figura geometrica incorrecta...");
          break;
      }
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado un algo diferente a un numero entero positivo");
    }
  }
}
