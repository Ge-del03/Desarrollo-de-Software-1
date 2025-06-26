using System;
using System.Xml;
namespace proyecto7
{
    public class Estudiante : Personas
    {
        public double Nota { get; set; }

        public Estudiante(string nombre, string apellido, int edad, double nota)
            :base(nombre, edad)
        {
            Nota = nota;
        }

        public void Evaluar()
        {
            Mostrar();
            Console.WriteLine($"Nota: {Nota}");
            Console.WriteLine(Nota >= 70 ? "Estado: Aprobado" : "Estado: Reprobado");
        }
    }
}
