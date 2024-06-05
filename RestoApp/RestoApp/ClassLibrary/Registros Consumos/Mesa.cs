using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Registros_Consumos
{
    public class Mesa : ConsumoMesa
    {
        #region Atributos
        private Empleado asignado;
        private int capacidad;
        #endregion

        #region Constructor
        public Mesa(int identificador, bool estado, Empleado asignado, int capacidad)
            : base(identificador, estado)
        {
            this.asignado = asignado;
            this.capacidad = capacidad;
        }
        #endregion

        #region Propiedades
        public int NroMesa
        {
            get
            {
                return base.getIdentificador;
            }
        }

        public string Mesero
        {
            get
            {
                return this.asignado.Nombre;
            }
        }
        #endregion
    }
}
