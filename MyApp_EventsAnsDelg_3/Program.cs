//Section 11
//Multicast Delegate

namespace MyApp_EventsAnsDelg_3;

class Program
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

    internal class Programm
    {
        static void Main(string[] args)
        {
            // Creating a multicast delegate
            Logger logger = new Logger();
            Handler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;

            //invoking the multicast delegate
            logHandler("Log this Info! ");


            //Removing a method from the multicast delegate

            logHandler -= logger.LogToFile;

            logHandler("After removing logToFile ");

        }
    }
}