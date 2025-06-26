using System;
namespace proyecto7
{
    public class Personas
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Personas(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Personas(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
            
        }
    }