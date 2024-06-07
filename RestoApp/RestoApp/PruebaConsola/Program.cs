using System;
using ClassLibrary;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto papas1 = new Producto("papas", "Efectivo", "qwe1", "1112", "Av.Galleton 123", "10/5", 25, 800);
            Producto papas2 = new Producto("papas", "Efectivo", "qwe1", "1112", "Av.Galleton 123", "10/5", 25, 800);
            Producto Manzana = new Producto("Manzana", "Efectivo", "XxX23", "1112", "Av.Galleton 123", "10/5", 25, 800);

            if (papas1 == papas2)
            {
                Console.WriteLine("Stock: " + papas1.GetStock);
                papas1 = papas1 - 1;
                Console.WriteLine("Stock: " + papas1.GetStock);
                papas1 = papas1 + 5;
                Console.WriteLine("Stock: " + papas1.GetStock);
            }
        }
    }
}
