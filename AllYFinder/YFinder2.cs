using System;

namespace AllYFinder
{/// <summary>
 /// Класс для метода поиска y =3*tg (x)
 /// </summary>
    public static class YFinder2
    {
        public static double[] YFind(int[] xMas)
        {
            double[] yMas = new double[xMas.Length];
            for (int i = 0; i < xMas.Length; i++)
            {
                yMas[i] = 3 * Math.Tan(xMas[i]);
            }
            return yMas;
        }
    }
}
