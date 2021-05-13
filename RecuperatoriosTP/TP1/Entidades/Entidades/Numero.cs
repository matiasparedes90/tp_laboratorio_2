using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto, asigna su valor inicial a 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Asigna un numero como valor inicial
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
            : this()
        {
            this.numero = numero;
        }
        /// <summary>
        /// Asigna el string como numero inicial
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            double.TryParse(strNumero, out this.numero);
        }
        #endregion

        #region Propiedades
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double numero = 0;
            if (double.TryParse(strNumero, out numero))
                return numero;
            else
                return 0;
        }
        /// <summary>
        /// validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool validar = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (!(binario[i] == '0') && !(binario[i] == '1'))
                {
                    validar = false;
                }
            }
            return validar;
        }
        /// <summary>
        /// validará que se trate de un binario y luego convertirá ese número binario a decimal, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            if (!(EsBinario(binario)))
            {
                return "Valor inválido";
            }

            char[] array = binario.ToCharArray();
            Array.Reverse(array);

            int numero = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == '1')
                {
                    numero += (int)Math.Pow(2, i);
                }

            }
            return numero.ToString();
        }
        /// <summary>
        /// convertirán un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            String binario = "";
            double resultado = 0;
            int    bin = 0;
            resultado = numero;
            do
            {
                bin = (int)(resultado % 2);
                binario = bin + binario;
                resultado = resultado / 2;
            } while ((int)resultado > 0);
            return binario;

        }
        /// <summary>
        /// convertirán un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double num);
            return DecimalBinario(num);
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero > 0)
                return n1.numero / n2.numero;
            else
                return double.MinValue;
        }
        #endregion
    }
}
