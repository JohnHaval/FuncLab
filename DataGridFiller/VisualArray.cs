using System.Data;

namespace DataGridFiller
{
    /// <summary>
    /// Класс для связывания DataGrid с массивом данных
    /// </summary>
    public static class VisualArray
    {
        static int j;
        static DataTable _res = new DataTable();
        /// <summary>
        /// Заполнение для одномерного массива
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xMas">Массив</param>
        /// <param name="isX">Используется для удобной пометки столбца значений</param>
        /// <returns>_res, таблицу с обновленными значениями</returns>
        public static DataTable YToDataTable<T>(this T[] yMas, int exercise)
        {            
            _res.Columns.Add("y" + (j + 1), typeof(string));
            if (exercise == 1)
            {
                DataRow row;
                for (int i = 0; i < yMas.Length; i++)
                {
                    row = _res.NewRow();
                    row[i] = yMas[i];
                    _res.Rows.Add(row);
                }                
            }
            if (exercise == 2)
            {
                DataRow row;
                for (int i = 0; i < yMas.Length; i++)
                {
                    row  = _res.NewRow();
                    row[i] = yMas[i];
                    _res.Rows.Add(row);
                }               
            }
            return _res;
        }
        public static DataTable XToDataTable<T>(this T[] xMas)
        {
            _res.Columns.Add("x", typeof(string));            
            DataRow row;
            for (int i = 0; i < xMas.Length; i++)
            {
                row = _res.NewRow();
                row[0] = xMas[i];                
                _res.Rows.Add(row);
            }
            return _res;
        }/// <summary>
         /// Производит очистку таблицы от значений и возвращает ее для отображения на DataGrid
         /// </summary>
         /// <returns></returns>
        public static DataTable ClearDataTable()
        {
            j = default;
            return _res = new DataTable();
        }
    }
}