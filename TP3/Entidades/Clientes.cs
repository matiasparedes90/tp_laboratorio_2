using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        #region Atributos
        private int legajoCliente;
        private string nombreCliente;
        #endregion

        #region Propiedades
        public int NroLegajo
        {
            get
            {
                return this.legajoCliente;
            }
        }
        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
        }
        #endregion

        #region Constructor
        public Clientes(string nombreCliente, int legajo)
        {
            this.legajoCliente = legajo;
            this.nombreCliente = nombreCliente;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retorna todos los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre Cliente: " + this.nombreCliente);
            sb.AppendLine("Legajo: " + this.legajoCliente);
            return sb.ToString();
        }
        #endregion

    }
}
