namespace Task2
{
    public static class SortString
    {
        /// <summary>
        /// Сортировка массива строк
        /// </summary>
        /// <param name="array"></param>
        /// <param name="typeSort"></param>
        public static void Sort(string[] array, TypeSort typeSort)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    switch (typeSort)
                    {
                        case TypeSort.Down:
                            if (isMax(array[j], array[j + 1]))
                                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                            break;
                        case TypeSort.Up:
                            if (isMin(array[j], array[j + 1]))
                                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Сравнение строк если a > b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool isMax(string a, string b)
        {
            var count = 0;
            if (a.Length > b.Length) count = b.Length;
            else count = a.Length;

            for (int i = 0; i < count; i++)
            {
                if (a[i] > b[i]) return true;
                else if (a[i] < b[i]) return false;
            }
            return true;
        }

        /// <summary>
        /// Сравнение строк если a < b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool isMin(string a, string b)
        {
            var count = 0;
            if (a.Length > b.Length) count = b.Length;
            else count = a.Length;

            for (int i = 0; i < count; i++)
            {
                if (a[i] < b[i]) return true;
                else if (a[i] > b[i]) return false;
            }
            return true;
        }

        /// <summary>
        /// Тип сортировки
        /// </summary>
        public enum TypeSort
        {
            Up,
            Down
        }
    }
}
