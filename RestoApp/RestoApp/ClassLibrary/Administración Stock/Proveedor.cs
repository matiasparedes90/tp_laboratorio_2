using System;

namespace ClassLibrary
{
    abstract public class Proveedor
    {

        #region Atributos
        private string producto;
        private string medioPago;
        private string nombre;
        private string cuit;
        private string direccion;
        private string diaEntrega;
        #endregion

        #region Constructor
        public Proveedor(string producto, string medioPago, string nombre, string cuit, string direccion, string diaEntrega)
        {
            this.producto = producto;
            this.medioPago = medioPago;
            this.nombre = nombre;
            this.cuit = cuit;
            this.direccion = direccion;
            this.diaEntrega = diaEntrega;
        }
        #endregion

        #region propiedad
        public string NombreProducto
        {
            get
            {
                return this.producto;
            }
        }
        #endregion
    }
}
