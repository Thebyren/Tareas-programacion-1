using System;

class ejercicio{
static void ejercicio_1(){
    int[] calificaciones;
    calificaciones = new int[]{85,92,77,68,94};
    float promedio=0;
    Console.WriteLine("usando un foreach para calcular un promedio");
    foreach(int calificacion in calificaciones){
        promedio+= calificacion;
    }
    Console.WriteLine($" el promedio es de: {promedio/calificaciones.Length}");
    
    Console.WriteLine("usando un for normal para imprimir las calificaciones");
    for(int i =0; i< calificaciones.Length; i++){
        Console.WriteLine($" calificacion {i+1}: {calificaciones[i]}");
    }
    Console.WriteLine("usando un for normal para obtener un promedio de los indices pares");
    promedio =0;
    for(int i =0; i< calificaciones.Length; i++){
        if(i%2 ==0 || i==0)
        promedio +=calificaciones[i];
    }
    Console.WriteLine($" el promedio es de: {promedio/calificaciones.Length}");
    
}
static void Main(){
    ejercicio_1();
}
}
