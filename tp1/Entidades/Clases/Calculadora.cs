using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clases
{
    public class Calculadora
    {
        public double Operar(Operando num1,Operando num2,char operador)
        {
            double resultado = 0;

            operador = ValidarOperador(operador);
            try
            {
                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        resultado = num1 / num2;
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                return 0;
            }

            return resultado;
        }
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                return operador;
            else
                return '+';
        }
    }
}
