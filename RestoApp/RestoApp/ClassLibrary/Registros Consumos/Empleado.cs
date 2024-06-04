using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Registros_Consumos
{
    public class Empleado
    {
        #region Atributos
        private string nombre;
        private string tipo;
        private double consumo;
        #endregion

        #region Constructor
        public Empleado(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
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

        public double Consumo
        {
            get
            {
                return this.consumo;
            }
            set
            {
                this.consumo += value;
            }
        }

        public string Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        #endregion


    }
}
