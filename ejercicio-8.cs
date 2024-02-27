using System.Collections.Generic;
using System;
class Usuario{
  public string Nombre{get; set;}
  public int Edad{get; set;}
  public bool Premiun{get; set;}
  public List<Libro> LibrosPrestados{get; set;}
  public Usuario(string nombre, int edad, bool premiun){
    Nombre = nombre;
    Edad = edad;
    Premiun = premiun;
    LibrosPrestados = new List<Libro>();
  }
}
class Libro{
  public string Titulo{get; set;}
  public bool Disponible{get; set;}
  public string Genero{get; set;}
  public string Tipo{get; set;}
  public Libro(string titulo, string genero, string tipo, bool disponible){
    Titulo = titulo;
    Genero = genero;
    Tipo = tipo;
    Disponible = disponible;
  }
}
class ejercicio
{
  public static void Main(){
    Libro libro_1 = new Libro("harry potter y el principe mestizo", "fantasia","no referencial", true);
    Libro libro_2 = new Libro("cronicas de narnia. el leon, la bruja y el ropero ", "ficcion","no referencial", false);
    Libro libro_3 = new Libro("el hobbit", "fantasia","referencial", false);
    Libro libro_4 = new Libro("48 leyes del poder", "historia","referencial", true);
    Console.WriteLine("ingrese su nombre");
    List<Libro> listaLibros =new List<Libro>();
    listaLibros.Add(libro_1);
    listaLibros.Add(libro_2);
    listaLibros.Add(libro_3);
    listaLibros.Add(libro_4);
    string nombre = Console.ReadLine();
    Console.WriteLine("ingrese su edad");
    int edad = int.Parse(Console.ReadLine());
    Console.WriteLine("es un usuario premiun? y/n:");
    bool premiun = Console.ReadLine().ToLower()=="y";
    Usuario persona = new Usuario(nombre,edad, premiun );

    Console.WriteLine("pidiendo prestados los libros...");
    foreach (var libro in listaLibros)
    {
      Console.WriteLine($"pidiendo libro {libro.Titulo} para {persona.Nombre}");
      if(TomarPrestado(persona, libro)){
        persona.LibrosPrestados.Add(libro);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"se presto el libro {libro.Titulo}");
        Console.ResetColor();
        
      }else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"no se pudo prestar el libro {libro.Titulo}");
        Console.ResetColor();
      }
    }

  }
  static bool TomarPrestado(Usuario usuario, Libro libro){
    if(libro.Genero =="ficcion"){
      return true;
    }else{
      return false;
    }
  }
}