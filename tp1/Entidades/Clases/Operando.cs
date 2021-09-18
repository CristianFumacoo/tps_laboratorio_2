using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clases
{
    public class Operando
    {
        private double _numero;
        public string Numero { set { _numero = ValidarOperando(value); } }

        public string BinarioDecimal(string binario)
        {
            double cont = 0;
            double potencia = 0;
            if(EsBinario(binario))
            {

                for(int i = binario.Length - 1; i >= 0;i--)
                {
                    if (binario[i] == '1')
                    {
                        cont += Math.Pow(2, potencia);
                    }
                    potencia++;
                }
                binario = Convert.ToString(cont);
            }
            else
            {
                binario = "Valor inválido.";
            }

            return binario;
        }
        public string DecimalBinario(double numero)
        {
            double[] a = new double[10];
            int i;
            string binario = "";
            for (i = 0; numero > 0; i++)
            {
                a[i] = numero % 2;
                numero = Convert.ToInt32(numero / 2);
                if(numero == 1)
                {
                    a[i + 1] = numero;
                    break;
                }
            }
            for(i = 9; i >= 0;i--)
            {
                binario += a[i].ToString();
            }
            return binario;
        }
        public string DecimalBinario(string numero)
        {
            return DecimalBinario(Convert.ToDouble(numero));
        }
        private bool EsBinario(string binario)
        {
            bool ret = false;
            int cont = 0;

            for(int i = 0;i < binario.Length;i++)
            {
                if(binario[i] == '0' || binario[i] == '1')
                {
                    cont++;
                }
            }
            if (cont == binario.Length)
            {
                ret = true;
            }
            return ret;
        }
        public Operando()
        {
            this._numero = 0;
        }
        public Operando(double numero)
        {

        }
        public Operando(string strNumero)
        {

        }
        public double ValidarOperando(string strNumero)
        {
            double num = 0;

            double.TryParse(strNumero, out num);

            return num;

        }
        public static double operator +(Operando Num1, Operando Num2)
        {
            return Num1._numero + Num2._numero;
        }
        public static double operator -(Operando Num1, Operando Num2)
        {
            return Num1._numero - Num2._numero;
        }
        public static double operator /(Operando Num1, Operando Num2)
        {
            if (Num2._numero == 0)
                return double.MinValue;
            else
                return Num1._numero / Num2._numero;
        }
        public static double operator *(Operando Num1, Operando Num2)
        {
            return Num1._numero + Num2._numero;
        }





    }
}
