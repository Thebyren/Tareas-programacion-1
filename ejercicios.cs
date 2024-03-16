using System;

class ejercicio{
static void ejercicio_1(){
    int[] calificaciones;
    calificaciones = new int[] {85,92,77,68,94};
    float promedio =0;
    foreach(int index in calificaciones){
        Console.WriteLine(index);
        promedio += (float)index;
    }
    Console.WriteLine($"El promedio es de: {promedio/calificaciones.Length}");
}
static void Main(){
    ejercicio_1();
}
