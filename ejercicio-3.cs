using System;

class ejercicio{
  public static void Main(){
  int sum = 0;
  int input = 0;
  do{
  Console.WriteLine("ingrese un numero:");
  input = int.Parse(Console.ReadLine());
  sum += input;
  }while(input>=0);
  Console.WriteLine("resultado es:"+sum);
  }
}