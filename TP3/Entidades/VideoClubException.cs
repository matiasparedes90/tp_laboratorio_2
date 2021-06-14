using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VideoClubException : Exception
    {
        #region Atributos
        public string nombreClase;
        #endregion

        #region Propiedades
        public string Excepcion
        {
            get
            {
                return base.Message;
            }
        }
        #endregion

        #region Constructor
        public VideoClubException(string nombreClase, string descripcion)
            : base(descripcion)
        {
            this.nombreClase = nombreClase;
        }
        #endregion
    }
}
