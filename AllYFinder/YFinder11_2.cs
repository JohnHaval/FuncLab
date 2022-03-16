using System;

namespace AllYFinder
{/// <summary>
 /// Класс для метода поиска y =3*tg (x)
 /// </summary>
    public static class YFinder11_2
    {
        public static string[] YFind(int[] xMas)
        {
            string[] yMas = new string[xMas.Length];
            for (int i = 0; i < xMas.Length; i++)
            {
                yMas[i] = (3 * Math.Tan(xMas[i])).ToString();
            }
            return yMas;
        }
    }
}
