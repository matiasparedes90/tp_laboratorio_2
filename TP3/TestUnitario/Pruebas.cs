using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        [ExpectedException(typeof(VideoClubException))]
        public void PruebaExcepcion()
        {
            Clientes cliente = new Clientes("Matias Paredes", 1001);
            Videoclub videoClub = new Videoclub(cliente);
            Pelicula p1 = new Pelicula("Robocop", "180", "Accion");
            Pelicula p2 = new Pelicula("Terminator", "180", "Accion");
            Juego j1 = new Juego("God of War","PS4","Accion/Aventura");
            // Se Agrega la pelicula como alquiler al videoclub
            videoClub += p1;
            videoClub += p2;
            videoClub += j1;
            // Generamos excepción agregando la misma pelicula
            videoClub += p1; // Comentar para probar funcionalidad
        }

        [TestMethod]
        public void CompararObjetos()
        {
            Clientes cliente = new Clientes("Matias Paredes", 1001);
            Videoclub videoClub = new Videoclub(cliente);
            Pelicula p1 = new Pelicula("Robocop", "180", "Accion");
            Pelicula p2 = new Pelicula("Terminator", "180", "Accion");
            bool respuesta = false;
            // Se Agrega la pelicula como alquiler al videoclub
            videoClub += p1; // Comentar para probar funcionalidad
            videoClub += p2;
            // Comparamos objetos
            for (int i = 0; i < videoClub.ListadoProductos.Count; i++)
            {
                if (videoClub[i] == p1)
                {
                    respuesta = true;
                }
                
            }
            Assert.IsTrue(respuesta);
        }
    }
}
