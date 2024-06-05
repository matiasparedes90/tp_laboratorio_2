using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Administración_Menú
{
    public class Plato
    {
        #region Atributos
        private List<Producto> listProducto;
        private string nombre;
        private string ingrediente;
        private string tiempo;
        private double precio;
        #endregion

        #region Constructor
        public Plato()
        {
            this.listProducto = new List<Producto>();
        }

        public Plato(List<Producto> productos, string nombre, string ingrediente, string tiempo)
            : this()
        {
            this.listProducto = productos;
            this.nombre = nombre;
            this.ingrediente = ingrediente;
            this.tiempo = tiempo;
        }
        #endregion

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Ingrediente
        {
            set
            {
                this.ingrediente = value;
            }
            get
            {
                return this.ingrediente;
            }
        }

        public string Tiempo
        {
            set
            {
                this.tiempo = value;
            }
            get
            {
                return this.tiempo;
            }
        }

        public List<Producto> Productos
        {
            set
            {
                this.listProducto = value;
            }
            get
            {
                return this.listProducto;
            }
        }

        public Producto this[int index]
        {
            get
            {
                return this.listProducto[index];
            }
            set
            {
                this.listProducto[index] = value;
            }
        }
        public double Precio
        {
            set
            {
                this.precio = value;
            }
            get
            {
                return this.precio;
            }
        }

        public bool Ofrecer
        {
            get
            {
                bool validar = true;
                for(int i = 0; i < this.listProducto.Count; i++)
                {
                    if (this.listProducto[i].GetStock < 10)
                    {
                        validar = false;
                        break;
                    }
                        
                }

                return validar;
            }
        }
        #endregion

        #region Métodos
        public string MostrarDetalle()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            for (int i = 0; i < this.listProducto.Count; i++)
            {
                sb.AppendLine(this.listProducto[i].NombreProducto);
            }
            sb.AppendLine(this.ingrediente);
            return sb.ToString();
        }

        public static bool operator ==(Plato p1, Plato p2)
        {
            return p1.Nombre == p2.Nombre;
        }

        public static bool operator !=(Plato p1, Plato p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
