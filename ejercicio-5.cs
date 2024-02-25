using System;

class ejercicio
{
  public static void Main()
  {
    const string correctPass = "jutiapa";
    Console.WriteLine("ingrese la contrasenia del usuario: ");
    string pass = Console.ReadLine();

    if(pass != correctPass){
      Console.WriteLine("contrasenia incorrecta!!!");
    }else{
      Console.WriteLine("contrasenia correcta, puede ingresar");
    }
  }
}
