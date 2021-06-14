using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Videoclub : IVideoClub
    {
        #region Atributos
        public Clientes cliente;
        private List<Producto> productos;
        #endregion

        #region Propiedades
        public Producto this [int i]
        {
            get
            {
                return this.productos[i];
            }
        }
        public List<Producto> ListadoProductos
        {
            get
            {
                return this.productos;
            }
        }

        #endregion

        #region Constructor
        private Videoclub()
        {
            this.productos = new List<Producto>();
        }
        public Videoclub(Clientes cliente)
            : this()
        {
            this.cliente = cliente;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Verifica si el producto ya esta cargado en el videoclub
        /// </summary>
        /// <param name="ventas"></param>
        /// <param name="videoclub"></param>
        /// <returns></returns>
        public static bool operator ==(Videoclub videoClub, Producto producto)
        {
                if (!(videoClub.ListadoProductos is null))
                {
                    for (int i = 0; i < videoClub.ListadoProductos.Count; i++)
                    {
                        if (videoClub[i] == producto)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    throw new VideoClubException("VideoClub", "No se puede comparar una lista vacia.");
                }


            return false;
        }

        public static bool operator !=(Videoclub videoClub, Producto producto)
        {
            return !(videoClub == producto);
        }
        /// <summary>
        /// Agrega un producto a la lista.
        /// </summary>
        /// <param name="ventas"></param>
        /// <param name="videoclub"></param>
        /// <returns></returns>
        public static Videoclub operator +(Videoclub videoClub, Producto producto)
        {

            if (videoClub != producto)
            {
                videoClub.productos.Add(producto);
            }
            else
            {
                throw new VideoClubException("Ventas", "El producto ya esta en alquiler");
            }

            return videoClub;
        }
        /// <summary>
        /// Quita un producto de la lista
        /// </summary>
        /// <param name="ventas"></param>
        /// <param name="videoclub"></param>
        /// <returns></returns>
        public static Videoclub operator -(Videoclub videoClub, Producto producto)
        {

            if (videoClub == producto)
            {
                videoClub.productos.Remove(producto);
            }
            else
            {
                throw new VideoClubException("Ventas", "El producto que desea quitar no esta en la lista");
            }

            return videoClub;
        }
        /// <summary>
        /// Retorna toda las ventas.
        /// </summary>
        /// <returns></returns>
        public string MostrarTodasLasVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.cliente.ToString());
            foreach (Producto p in this.productos)
            {
                if (Juego.Equals<Producto>(p))
                {
                    sb.AppendLine(((Juego)p).ToString());
                }
                else
                {
                    sb.AppendLine(((Pelicula)p).ToString());
                }
            }
            sb.AppendLine("-------------------------------");
            return sb.ToString();
        }

        #endregion

    }
}
