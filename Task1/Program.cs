namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = {
                new MyException("Отсутствует доступ к сайту"),
                new DriveNotFoundException(),
                new DirectoryNotFoundException(),
                new FormatException(),
                new UriFormatException()
            };

            try
            {
                throw exceptions[0];
            }

            catch (Exception ex)
            {
                if (exceptions.Contains(ex))
                    Console.WriteLine(ex.Message);
                else
                    Console.WriteLine("Неизвестное исключение");
            }
        }
    }
}