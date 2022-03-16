using System;

namespace AllYFinder
{/// <summary>
/// Класс для метода поиска y=a/x^4
/// </summary>
    public class YFinder11_1
    {
        public static string[] YFind(int[] xMas, int a)
        {
            string[] yMas = new string[xMas.Length];
            for (int i = 0; i < xMas.Length; i++)
            {
                double proveValue = Math.Pow(xMas[i], 4);
                if (proveValue != 0) yMas[i] = (a / proveValue).ToString();
                else yMas[i] = "-";
            }
            return yMas;
        }
    }
}
