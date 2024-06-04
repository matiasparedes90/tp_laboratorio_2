using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Administración_Contable
{
    public class Adm_Contable
    {
        #region Atributos
        private Administración_Stock.Adm_Stock admStock;
        private List<string> listAcreedores;
        private double fondos;
        #endregion

        #region Constructor
        public Adm_Contable()
        {
            this.listAcreedores = new List<string>();
        }

        public Adm_Contable(Administración_Stock.Adm_Stock amdStock, double fondos)
        {
            this.admStock = amdStock;
            this.fondos = fondos;
        }
        #endregion

        #region Métodos
        public void Recaudación(double fondo)
        {

        }

        public void PagoMensual()
        {

        }
        #endregion
    }
}
