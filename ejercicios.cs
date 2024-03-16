using System;

class ejercicio{
static void ejercicio_1(){
    int[] calificaciones;
    calificaciones = new int[] {85,92,77,68,94};
    foreach(int index in calificaciones){
        Console.WriteLine(index);
    }
}
static void Main(){
    ejercicio_1();
}
