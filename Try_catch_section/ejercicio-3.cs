using Internal;
using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("ingrese el precio del producto:");
      double precioProducto= double.Parse(Console.ReadLine());
      if(precioProducto > 100){
        precioProducto = precioProducto * 0.9;
      }
      Console.WriteLine("su compra final es de:"+ precioProducto);
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado algo diferente a un numero");
    }
  }
}
