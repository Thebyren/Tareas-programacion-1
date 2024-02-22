using Internal;
using System;
public class ejercicio_1
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("Ingrese nombre de usario:");
      string nameUser= Console.ReadLine();
      Console.WriteLine("Ingrese la  del contraseña usuario:");
      string passUser= Console.ReadLine();
      
      if(( nameUser == "usuario" ) && ( passUser == "contraseña" )){
        Console.WriteLine("se ingresaron las redenciales correctas. login exitoso");
      }else{
        Console.WriteLine("el usuario o la contraseña son incorrectos. login fallido");
      }
    }
    catch (System.Exception ex)
    {
      Console.WriteLine("usted a ingresado algun dato que excede el espacio de memoria de los campos");
    }
  }
}
