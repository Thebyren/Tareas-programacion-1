using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("Ingrese su edad:");
      int userAge= int.Parse(Console.ReadLine());
      Console.WriteLine("Ingrese el monto de su prestamo solicitado:");
      int userMoney= int.Parse(Console.ReadLine());
   
      if((userAge>60)||(userMoney<5000)){
        Console.WriteLine("su prestamo fue aceptado");
      }else{
        Console.WriteLine("su prestamo fue rechazado");
      }
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado un algo diferente a un numero entero positivo");
    }
  }
}
