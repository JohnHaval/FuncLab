using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllXFiller
{
    public class XFiller
    {
        /// <summary>
        /// Выполняет сборку массива с X значениями для строки таблицы
        /// </summary>
        /// <param name="firstX">Первое значение диапазона X</param>
        /// <param name="secondX">Второе значение диапазона X</param>
        /// <returns>Возвращает null, если диапазон указан неверно или mas, если массив подготовлен успешно</returns>
        public static int[] XFill(int firstX, int secondX)
        {
            if (firstX > secondX) return null;
            int length = secondX - firstX + 1;
            int[] mas = new int[length];
            for (int i = 0; i < length; i++)
            {
                mas[i] = firstX++;
            }
            return mas;
        }
    }
}
