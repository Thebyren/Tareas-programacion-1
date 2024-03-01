using System;

class ejercicio
{
  static void Main()
  {
    string opt;
    int num1, num2;
    do
    {
      Console.WriteLine("--------MENU--------");
      Console.WriteLine("Calcular operación matemática--1");
      Console.WriteLine("Salir--------------------------2");
      Console.Write("Seleccione una opción: ");
      opt = Console.ReadLine();

      if (opt == "1")
      {
        Console.WriteLine("Ingrese el primer número:");
        num1 = int.Parse(Console.ReadLine());
        

        Console.WriteLine("Ingrese el segundo número:");
        num2 = int.TryParse(Console.ReadLine());

        Console.WriteLine("Ingrese el operador matemático (+, -, *, /):");
        string operador = Console.ReadLine();

        switch (operador)
        {
          case "+":
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
            break;
          case "-":
            Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
            break;
          case "*":
            Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
            break;
          case "/":
            if (num2 != 0)
            {
              Console.WriteLine($"El resultado de la división es: {(double)num1 / num2}");
            }
            else
            {
              Console.WriteLine("No se puede dividir por cero.");
            }
            break;
          default:
            Console.WriteLine("Operador no válido.");
            break;
        }
      }
      else if (opt != "2")
      {
        Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
      }
    } while (opt != "2");
  }
}
