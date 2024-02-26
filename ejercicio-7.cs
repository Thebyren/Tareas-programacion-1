using System.Linq;
using System;

class ejercicio
{
  static string Check(bool valor){
    return valor ? "X":"*";
  }
  static void Main()
  {
   bool malComportado = false;
   int[] notas= {70,70,70,70,70,60};
   Console.WriteLine(Check(notas.All(num =>num>=70)));
   Console.WriteLine(Check(notas.Average() >=70));
   Console.WriteLine(Check(!malComportado));
   if(!(notas.All(num =>num>=70) && (notas.Average() >=70) && !malComportado)){
      Console.WriteLine("el estudiante no puede graduarse");
   }else{
    Console.WriteLine("el estudiante cumple con todos los requisitos");
   }

  }
}
