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
    Usuario persona = new Usuario();
    Console.WriteLine("ingrese su nombre");
    persona.Nombre= Console.ReadLine();
    Console.WriteLine(persona.Nombre);
  }
  static bool TomarPrestado(Usuario usuario, Libro libro){
    if(libro.genero =="ficcion"){
      return true;
    }else{
      return false;
    }
  }
}