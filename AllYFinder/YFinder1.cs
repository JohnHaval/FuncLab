using System;

namespace AllYFinder
{/// <summary>
/// Класс для метода поиска y=a/x^4
/// </summary>
    public class YFinder1
    {
        public static double[] YFind(int[] xMas, int a)
        {
            double[] yMas = new double[xMas.Length];
            for (int i = 0; i < xMas.Length; i++)
            {
                yMas[i] = a / Math.Pow(xMas[i], 4);
            }
            return yMas;
        }
    }
}
