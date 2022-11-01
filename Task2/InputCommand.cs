namespace Task2
{
    /// <summary>
    /// Класс обработки введенных команд
    /// </summary>
    public class InputCommand
    {
        public delegate void Input(string[] array, string input);
        public event Input? Notify;
        private string[]? Array;

        public void Read(string[] array, string str)
        {
            Array = array;
            switch (str)
            {
                case "1": Notify?.Invoke(Array, "Сортировка А-Я"); break;
                case "2": Notify?.Invoke(Array, "Сортировка Я-А"); break;
            }
        }
    }
}
