using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Producto : Proveedor
    {

        #region Atributos
        private int cantidad;
        private double precio;
        #endregion

        #region Constructor
        public Producto(string producto, string medioPago, string nombre, string cuit, string direccion, string diaEntrega, int cantidad, double precio)
            : base(producto, medioPago, nombre, cuit, direccion, diaEntrega)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        #endregion

        #region Propiedades
        public int GetStock
        {
            get
            {
                return this.cantidad;
            }
        }
        #endregion

        #region Métodos
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.NombreProducto == p2.NombreProducto;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static Producto operator -(Producto p1, int cantidad) {
            p1.cantidad -= cantidad;
            return p1;
        }

        public static Producto operator +(Producto p1, int cantidad)
        {
            p1.cantidad += cantidad;
            return p1;
        }
        #endregion
    }
}
