using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * CalcularFactorial(num - 1);
        }

        public int vocales(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                return 0;
            }

            char c = char.ToLower(cadena[0]);
            int esVocal = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') ? 1 : 0;
            return esVocal + vocales(cadena.Substring(1));
        }

        public int SumaDigitos(int num)
        {
            if (num < 10)
            {
                return num;
            }

            return (num % 10) + SumaDigitos(num / 10);
        }

        public int SumarNumeros(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return SumarNumeros(n - 1) + n;
        }
    }
}
