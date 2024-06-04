using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Administración_Menú
{
    public class Adm_Menu
    {
        #region Atributos
        private List<Plato> listPlatos;
        #endregion

        #region Constructor
        public Adm_Menu()
        {
            this.listPlatos = new List<Plato>();
        }

        #endregion

        #region Métodos
        public void CrearMenu(Plato plato)
        {
            bool existe = false;
            for (int i = 0; i < this.listPlatos.Count; i++)
            {
                if (this.listPlatos[i] == plato)
                {
                    existe = true;
                    break;
                }
            }

            if (!(existe))
            {
                this.listPlatos.Add(plato);
            }
        }

        public void ModificarMenu(Plato plato)
        {
            for (int i = 0; i < this.listPlatos.Count; i++)
            {
                if (this.listPlatos[i] == plato)
                {
                    this.listPlatos[i].Productos = plato.Productos;
                    this.listPlatos[i].Ingrediente = plato.Ingrediente;
                    this.listPlatos[i].Tiempo = plato.Tiempo;
                    break;
                }
            }
        }

        public void EliminarMenu(Plato plato)
        {
            for (int i = 0; i < this.listPlatos.Count; i++)
            {
                if (this.listPlatos[i] == plato)
                {
                    this.listPlatos.RemoveAt(i);
                    break;
                }
            }
        }

        public void CargarPrecio(int index, double precio)
        {
            this.listPlatos[index].Precio = precio;
        }

        public string MostrarPlato()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.listPlatos.Count; i++)
            {
                sb.AppendLine("Plato: " + this.listPlatos[i].Nombre);
                sb.AppendLine("Ingredientes utilizados:");
                for (int j = 0; j < this.listPlatos[i].Productos.Count; j++)
                {
                    sb.AppendLine(this.listPlatos[i].Productos[j].NombreProducto);
                }
                sb.AppendLine(this.listPlatos[i].Ingrediente);
            }

            return sb.ToString();
        }

        public List<Plato> ListarPlatos()
        {
            List<Plato> lista = new List<Plato>();

            for(int i = 0; i < this.listPlatos.Count; i++)
            {

                for(int j = 0; j < this.listPlatos[i].Productos.Count; j++)
                {
                    if (this.listPlatos[i].Productos[j].GetStock < 10) // VERIFICAR COMO USAR ADM_STOCK
                    {
                        lista.Add(this.listPlatos[i]);
                        break;
                    }
                }
                
            }

            return lista;
        }

        #endregion
    }
}
