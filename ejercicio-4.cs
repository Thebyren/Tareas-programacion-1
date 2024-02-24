
using System;

class ejercicio{
public static void Main(){
  int sum=0, n=1;
do{
Console.WriteLine(n);
sum = n;
n++;
}while(n%11==0 && n%7==0);
  Console.WriteLine("resultado es: "+sum);
 }
}