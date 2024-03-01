using System;

class ejercicio
{
  static void Main()
  {
    Random random = new Random();
    int secretNum = random.Next(1, 101);
    int trys = 0;
    int numUser;

    Console.WriteLine("Se ha generado un número secreto entre 1 y 100.");
    
    do
    {
      Console.Write("Ingresa tu intento: ");
      if (!int.TryParse(Console.ReadLine(), out numUser))
      {
        Console.WriteLine("Error: Debes ingresar un número entero válido.");
        continue;
      }

      trys++;

      if (numUser < secretNum)
      {
        Console.WriteLine("El número secreto es mayor.");
      }
      else if (numUser > secretNum)
      {
        Console.WriteLine("El número secreto es menor.");
      }
      else
      {
        Console.WriteLine($"Has adivinado el número secreto {secretNum} en {trys} intentos.");
      }
    } while (numUser != secretNum);
  }
}
