using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Registros_Consumos
{
    public abstract class ConsumoMesa
    {
        #region Atributos
        private int nroIdentificador;
        private double consumo;
        private string metodoPago;
        private bool estado;
        #endregion

        #region Constructor
        public ConsumoMesa(int identificador, double consumo, string metodo, bool estado)
        {
            this.nroIdentificador = identificador;
            this.consumo = consumo;
            this.metodoPago = metodo;
            this.estado = estado;
        }
        #endregion

        #region Propiedades
        public double Consumo
        {
            get
            {
                return this.consumo;
            }
            set
            {
                this.consumo = value;
            }
        }

        public string MetedoPago
        {
            get
            {
                return this.metodoPago;
            }
            set
            {
                this.metodoPago = value;
            }
        }

        public bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        protected int getIdentificador
        {
            get
            {
                return this.nroIdentificador;
            }
        }
        #endregion
    }
}
