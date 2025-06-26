using System;
namespace proyecto7
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string descripcion, double precio, int cantidad)
        {
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }
        //Calculado Producto
        public double CalcularTotal() => Precio * Cantidad;
        public void VerDetalles()
        {
            Console.WriteLine($"Producto: {Descripcion}");
            Console.WriteLine($"Precio unitario: {Precio}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Total a pagar: {CalcularTotal():C}");
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles del Producto:");
            Console.WriteLine($"Nombre: {Descripcion}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }
}
