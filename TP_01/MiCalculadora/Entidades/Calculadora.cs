using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    operador = "+";
                    break;
            }
            return operador;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = Calculadora.ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                default:
                    if (double.IsInfinity(num1 / num2))
                        return double.MinValue;
                    else
                        return num1 / num2;

            }

        }
    }
}
