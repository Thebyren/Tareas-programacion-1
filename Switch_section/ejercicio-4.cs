using System;
class ejercicio
{
  public static void Main()
  {
    try
    {
      string[] langList = { "español", "inglés", "francés" };
      string[] grettingList = {"Bienvenido al programa","Welcome to the program","Bienvenue au programme"};
      Console.WriteLine("Escriba el número correspondiente al idioma de su preferencia:");
      for (int i = 0; i < langList.Length; i++)
      {
        Console.WriteLine("[  "+(i + 1) + " --- " + langList[i]+"  ]");
      }
      int num = int.Parse(Console.ReadLine());
      switch (num)
      {
        case 1:
          Console.WriteLine(grettingList[0]);
          break;
        case 2:
          Console.WriteLine(grettingList[1]);
          break;
        case 3:
          Console.WriteLine(grettingList[2]);
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
