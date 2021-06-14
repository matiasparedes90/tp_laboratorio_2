using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juego : Producto
    {
        #region Atributos
        private string plataforma;
        private string genero;
        #endregion

        #region Propiedades

        public string Categoria
        {
            get
            {
                
                return string.Format("Plataforma: {0} / Genero: {1}",this.plataforma,this.genero); 
            }
        }
        #endregion

        #region Constructor
        
        public Juego(string nombreJuego, string plataforma, string genero)
            : base(nombreJuego , TipoProducto.Juego)
        {
            this.plataforma = plataforma;
            this.genero = genero;
        }
        #endregion

        #region Método
        /// <summary>
        /// Retorna los datos del producto
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Categoria: " + this.Categoria);
            return sb.ToString();
        }
        /// <summary>
        /// Retorna todos los datos del producto Juego
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// Verifica si el tipo de parametro recibido se un juego
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool Equals<T>(T valor) 
        {
            return valor is Juego;
        }

        #endregion
    }
}
