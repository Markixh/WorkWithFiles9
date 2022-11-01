namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]? array = null;

            Exception exceptionfam = new Exception("Фамилии не введены"); //Исключение, возникает при не вводе фамилий
            Exception exceptiontype = new Exception("Тип сортировки выбран не правильно"); //Исключение, возникает при не правильном выборе сортироки

            Console.WriteLine("Введите фамилии через пробел");

            var isInput = true;
            while (isInput)
            {
                try
                {
                    array = Console.ReadLine().Split(" ");
                    if (array.Length <= 1) throw exceptionfam;
                    else isInput = false;
                }
                catch (Exception ex) when (ex.Message == "Фамилии не введены")
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    array ??= new string[0];
                }
            }

            Console.WriteLine("Выберите способ сортировки 1 - А-Я, 2 - Я-А");

            InputCommand inputCommand = new InputCommand();
            inputCommand.Notify += NotifyCommand;

            isInput = true;
            while (isInput)
            {
                try
                {                    
                    var Command = Console.ReadLine();
                    if (Command != "1" && Command != "2")
                        throw exceptiontype;
                    else isInput = false;
                    inputCommand.Read(array, Command);
                }
                catch (Exception ex) when (ex.Message == "Тип сортировки выбран не правильно")
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Результат:");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

       /// <summary>
       /// Метод для обработки событий
       /// </summary>
       /// <param name="array"></param>
       /// <param name="message"></param>
        static public void NotifyCommand(string[] array, string message)
        {
            switch (message)
            {
                case "Сортировка А-Я":
                    SortString.Sort(array, SortString.TypeSort.Down);
                    break;
                case "Сортировка Я-А":
                    SortString.Sort(array, SortString.TypeSort.Up);
                    break;
            }
        }
    }
}