using System;

class ejercicio{
  public static void Main(){
    int respuesta, val1, val2 = 0;
    Console.WriteLine("ingrese el valor 1:");
    val1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el valor 2:");
    val2 = int.Parse(Console.ReadLine());

    respuesta = val1+val2;
    Console.WriteLine($"suma = {respuesta}");
    
  }
}