namespace Task1
{
    public class MyException : Exception
    {
        public MyException()
        {
            HelpLink = "www.ya.ru";
        }

        public MyException(string message)
            : base(message)
        {
            HelpLink = "www.ya.ru";
        }
    }
}
