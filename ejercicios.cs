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
static void ejercicio_2(){
    int[] elementos = new int[]{50,20,80,90,60};
    Console.WriteLine($"original array");
    infor(elementos);
    Array.Sort(elementos);
    Console.WriteLine($"resort array");
   infor(elementos);
   
    Array.Reverse(elementos);
    Console.WriteLine($"reverse array");
   infor(elementos);
}
static void ejercicio_3(){
    int[] edades ={25,30,18,45,30};
    infor(edades);
    Console.WriteLine("buscando la edad 20 en edades");
    Console.WriteLine($"la edad 30 esta en la posicion {Array.IndexOf(edades,30)} del array de edades");
}
static void ejercicio_4(){
    int[] calificaciones={85,92,77,68,94};
    infor(calificaciones);
    Console.WriteLine("verificando si alguien aprovo el curso");
    Console.WriteLine($"{Array.Exists(calificaciones, calif=> calif>= 60)}");
}
static void infor(int[] array){
 foreach(int num in array){
    Console.WriteLine(num);
    }   
}

static void Main(){
    Console.WriteLine("\n\n\nejercicio 1\n\n");
    ejercicio_1();
    Console.WriteLine("\n\n\nejercicio 2\n\n");
    ejercicio_2();
    Console.WriteLine("\n\n\nejercicio 3\n\n");
    ejercicio_3();
    Console.WriteLine("\n\n\nejercicio 4\n\n");
    ejercicio_4();
}
}
