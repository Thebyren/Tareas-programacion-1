using System;
class ejercicio
{
    static void Main()
    {
        Random random = new Random();
        int numRandom = random.Next(1, 101);
        
        int trys = 0;
        int trysUser;

        Console.WriteLine("ingresa un numero entre 1 y 100");

        do
        {
            Console.Write("ingresa el numero:");
            trysUser = int.Parse(Console.ReadLine());
            trys++;
            if (trysUser < numRandom)
            {
                Console.WriteLine("El numero es mayor.");
            }
            else if (trysUser > numRandom)
            {
                Console.WriteLine("El numero es menor.");
            }
            else
            {
                Console.WriteLine("has acertado el numero en  " + trys + " intentos.");
            }
        } while (trysUser != numRandom);
    }
}
