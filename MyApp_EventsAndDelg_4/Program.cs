namespace MyApp_EventsAndDelegate_4;

//Section 11
//Multicast Delegate Part 2

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

            foreach (Handler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event ocurred withe error handeling");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                   
                }
                
            }
            
            

            //Removing a method from the multicast delegate

            if (isMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;

               Console.WriteLine("LogToFile method removed");
                
            }
            else
            {
                Console.WriteLine("LogToFile method not found");
            }
            

        }



        static void InvokeSafely(Handler logHandler, string message)
        {
            Handler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool isMethodInDelegate(Handler handler, Handler methodHandler)
        {
            if (handler == null)
            {
                return false;
            }

            foreach (var myDelegate in handler.GetInvocationList())
            {
                if (myDelegate == (Delegate)methodHandler)
                {
                    return true;
                }
            }
            return false;
            
        }
        
        
    }
}