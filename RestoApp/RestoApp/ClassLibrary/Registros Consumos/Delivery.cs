using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Registros_Consumos
{
    public class Delivery : ConsumoMesa
    {
        #region Atributos
        private Empleado asignado;
        #endregion

        #region Constructor
        public Delivery(int identificador, bool estado, Empleado asignado)
            : base(identificador, estado)
        {
            this.asignado = asignado;
        }
        #endregion

        #region Propiedades
        public int NroDelivery
        {
            get
            {
                return base.getIdentificador;
            }
        }

        public string DeliveryAsig
        {
            get
            {
                return this.asignado.Nombre;
            }
        }
        #endregion
    }
}
