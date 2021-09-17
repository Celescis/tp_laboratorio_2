using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region ATRIBUTOS
        private double numero;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        public Operando() : this(0)
        { }
        public Operando(double numero) : this(numero.ToString())
        { }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion CONSTRUCTORES

        #region SOBRECARGA
        public static double operator + (Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator - (Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator / (Operando num1, Operando num2)
        {
            double result;

            if (num2.numero==0)
            {
                result = double.MinValue;
            }
            else
            {
                result = num1.numero / num2.numero;
            }

            return result;
        }
        public static double operator * (Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        #endregion SOBRECARGA

        #region METODOS
        private double ValidarOperando(string strNumero)
        {
            double num;

            if (!double.TryParse(strNumero, out num))
            {
                num = 0;
            }

            return num;
        }
        private static bool EsBinario(string binario)
        {
            bool result = true;

            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static string BinarioDecimal(string binario)
        {
            string result = "Valor inválido";

            if (Operando.EsBinario(binario))
            {
                result = Convert.ToInt32(binario, 2).ToString();
            }

            return result;
        }
        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        public static string DecimalBinario(string numero)
        {
            string result;

            result = Convert.ToString(int.Parse(numero),2);

            if (!Operando.EsBinario(result))
            {
                result = "Valor inválido";
            }
            return result;
        }
        #endregion METODOS

        #region PROPIEDAD
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion PROPIEDAD

    }
}
