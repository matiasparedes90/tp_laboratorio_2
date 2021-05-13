using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Entidades: Realiza una operación en base a 2 numeros y un operando
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            
            switch (ValidarOperador(char.Parse(operador)))
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                default:
                    return num1 / num2;
            }
        }

        /// <summary>
        /// Valida que el operador sea el correcto.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si no cumple la condición, devuelve +, caso contrario retorna el operador cargado</returns>
        private static string ValidarOperador(char operador)
        {
            switch (operador)
            {
                case '+':
                    return operador.ToString();
                case '-':
                    return operador.ToString();
                case '*':
                    return operador.ToString();
                case '/':
                    return operador.ToString();
                default:
                    return "+";
            }
        }
    }
}
