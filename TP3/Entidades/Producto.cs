using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Enumerado
        public enum TipoProducto
        {
            Juego,
            Pelicula,
        }
        #endregion

        #region Atributos
        private string nombreProducto;
        private TipoProducto tipoProducto;
        private double precio;
        #endregion

        #region Propiedades
        public double PrecioProducto
        {
            get
            {
                return this.CalcularPrecio(this.tipoProducto);
            }
        }
        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
        }
        #endregion

        #region Constructor
        public Producto(string nombreProducto, TipoProducto tipoProducto)
        {
            this.tipoProducto = tipoProducto;
            this.nombreProducto = nombreProducto;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra los datos del producto
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre del producto: " + this.nombreProducto);
            sb.AppendLine("Precio: " + this.PrecioProducto);
            return sb.ToString();
        }
        /// <summary>
        /// Depende del tipo de producto retorna el costo del alquiler
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private double CalcularPrecio(TipoProducto tipo)
        {

            switch (tipo)
            {
                case TipoProducto.Juego:
                    return 200d;
                case TipoProducto.Pelicula:
                    return 140d;
            }
            return 0;
        }
        /// <summary>
        /// Solo es igual si ambos productos tienen el mismo nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Producto p1, Producto p2)
        {
            if (p1.nombreProducto == p2.nombreProducto)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
