using System.Data;

namespace DataGridFiller
{
    /// <summary>
    /// Класс для связывания DataGrid с массивом данных
    /// </summary>
    public static class VisualArray
    {
        /// <summary>
        /// Заполнение для одномерного массива
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this T[] arr, bool isX)
        {
            var res = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                if(isX) res.Columns.Add("x", typeof(T));
                else res.Columns.Add("y" + (i + 1), typeof(T));
            }
            for (int i = 0; i < arr.Length; i++)
            {
                var row = res.NewRow();
                row[i] = arr[i];
                res.Rows.Add(row);
            }
            return res;
        }
    }
}