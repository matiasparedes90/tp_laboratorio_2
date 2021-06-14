using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes("Matias Paredes", 1001);
            Videoclub v1 = new Videoclub(cliente);
            Pelicula p1 = new Pelicula("Robocop", "180", "Accion");
            Pelicula p2 = new Pelicula("Terminator", "180", "Accion");
            Juego j1 = new Juego("God of War", "PS4", "Accion/Aventura");
            // Carga de datos
            Console.WriteLine("Carga de Alquileres: ");
            Console.WriteLine("-------------------");
            try
            {
                v1 += p1;
                Console.WriteLine(p1.NombreProducto + "Carga Exitosa");
                v1 += p2;
                Console.WriteLine(p2.NombreProducto + "Carga Exitosa");
                v1 += j1;
                Console.WriteLine(j1.NombreProducto + "Carga Exitosa");
                v1 += p1;
                Console.WriteLine(p1.NombreProducto + "Carga Exitosa");
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Error de carga: " + p1.NombreProducto + e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Datos del Alquiler: ");
            Console.WriteLine("-------------------");
            Console.WriteLine(v1.MostrarTodasLasVentas());
            Console.ReadKey();
            
        }
    }
}
