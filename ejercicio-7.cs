using System.Linq;
using System;

class ejercicio
{
  static string Check(bool valor){
    return valor ? "✓":"✗";
  }
  static void Main()
  {
   bool malComportado = false;
   int[] notas= {70,70,70,70,70,70};
   Console.WriteLine("todos los cursos aprovados-["+Check(notas.All(num =>num>=70))+"]");
   Console.WriteLine("promedio mayor a 70--------["+Check(notas.Average() >=70)+"]");
   Console.WriteLine("buen comportamiento--------["+Check(!malComportado)+"]");
   if(!(notas.All(num =>num>=70) && (notas.Average() >=70) && !malComportado)){
      Console.WriteLine("el estudiante no puede graduarse");
   }else{
    Console.WriteLine("el estudiante cumple con todos los requisitos");
   }

  }
}
