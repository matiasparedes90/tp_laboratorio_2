using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region ATRIBUTOS

        private double numero;

        #endregion

        #region CONSTRUCTOR

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            double.TryParse(strNumero, out this.numero);
        }

        #endregion

        #region SET

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #endregion

        #region METODOS
        // Validar Numero
        private double ValidarNumero(string strNumero)
        {
            bool validar = double.TryParse(strNumero, out double nro);
            // Si la conversión a double es verdadera entonces es valida.
            if (validar)
                return nro;
            else
                return 0;
        }
        // Conversión Binario a Decimal 
        public string BinarioDecimal(string binario)
        {
            double cont = 0, nro = 0;
            int potencia = 0;
            bool validar = double.TryParse(binario, out double d);

            if (validar)
            {
                // Leo a partir de la ultima posición del string hasta el principio
                for (int i = binario.Length; i > 0; i--)
                {
                    // Si contiene un 1 en su posición elevo el 2 la potencia 0 como inicial
                    if (binario[i - 1].Equals('1'))
                    {
                        cont = Math.Pow(2, potencia);
                    }
                    // Si el nro tiene un valor distinto a 1  y 0 retorno VALOR INVALIDO.
                    if (!(binario[i - 1].Equals('1') || binario[i - 1].Equals('0')))
                    { 
                        return "Valor Invalido";
                    } 
                    /* Sumo el resultado del contador  a nro, luego la inicializo a 0 para volver hacer la cuenta para el siguiente caso.
                       Sumo la potencia para el siguiente caso */
                    nro = nro + cont;
                    potencia = potencia + 1;
                    cont = 0;
                }

                
            }

            return nro.ToString();



        }
        // Decimal a Binario
        public string DecimalBinario(double numero)
        {
            /* Realizo la conversión de decimal a binario mientras el nro sea mayor a 0
             * Verifico el resto de la division del nro por 2 y solo guardo el entero para concatenarlo con Binario.
             * Luego actualizo nro con la división solo guardando su entero.
             */

            string binario = "";

            do
            {
                binario = (int)(numero % 2) + binario; 
                numero = (int)numero / 2;
            } while (numero > 0);
            return binario;
        }

        public string DecimalBinario(string numero)
        {
            /* Luego de validar la conversión de double, valido que el nro contenga numeros que no sean 1 y 0, en caso de ser asi hago la
             * conversión llamando al mentodo de arriba, caso contrario retorno Valor Invalido.
             */

            int validarDecimal = 0;
            bool validar = double.TryParse(numero, out double nro);
            
            if (validar)
            {
                for(int i = numero.Length; i > 0; i--)
                {
                    if (!(numero[i - 1].Equals('1') || numero[i - 1].Equals('0'))) 
                    {
                        validarDecimal = 1;
                    }
                }
                if(validarDecimal == 1)
                    return DecimalBinario(nro);
            }

            return "Valor Invalido"; 
            
        }


        // Operadores

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return (n1.numero / n2.numero);
        }

        public static double operator +(Numero n1, Numero n2)
        {

            return (n1.numero + n2.numero);

        }
        #endregion
    }
}
