using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Administración_Stock
{
    public class Adm_Stock
    {
        #region Atributos
        private List<Producto> listProductos;
        #endregion

        #region Constructor
        public Adm_Stock()
        {
            this.listProductos = new List<Producto>();
        }

        public Adm_Stock(Producto producto)
            : this()
        {
            this.listProductos.Add(producto);
        }
        #endregion

        #region Propiedad
        public Producto SetProducto
        {
            set
            {
                this.listProductos.Add(value);
            }
        }

        public Dictionary<string, int> GetStock
        {
            get
            {
                Dictionary<string, int> collect = new Dictionary<string, int>();

                for(int i = 0; i < this.listProductos.Count; i++)
                    collect.Add(this.listProductos[i].NombreProducto, this.listProductos[i].GetStock);
                
                return collect;
            }
        }


        public Dictionary<string, int> GetStockAgotarse
        {
            get
            {
                Dictionary<string, int> collect = new Dictionary<string, int>();

                for (int i = 0; i < this.listProductos.Count; i++)
                {
                    if( this.listProductos[i].GetStock < 10 ) // Solo si es menor a 10
                        collect.Add(this.listProductos[i].NombreProducto, this.listProductos[i].GetStock);
                }
                    

                return collect;
            }
        }


        #endregion

        #region Método
        public void Egreso(Producto p1, int cantidad)
        {

                for (int i = 0; i < this.listProductos.Count; i++)
                {
                    if (this.listProductos[i] == p1)
                        this.listProductos[i] -= cantidad; 
                }

        }
        #endregion
    }
}
