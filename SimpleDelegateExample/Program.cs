namespace SimpleDelegateExample
{


    public delegate void Handler(string message);
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Log Message: " + message);

        }

        public void LogToFile(string message)
        {
            Console.WriteLine("Log File: " + message);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Logger logger = new Logger();
            Handler logHandler = logger.LogToConsole;
            logHandler("Logging To Console");

            logHandler=logger.LogToFile;
            logHandler("Logging To File");

        }


    }




}
