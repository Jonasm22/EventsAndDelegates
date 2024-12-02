﻿namespace IntroductionToDelegates
{
    internal class Program
    {
        //1. Declaration

        public delegate void Notify(string message);


        static void Main(string[] args)
        {

            //2. Instantiation

            Notify notifyDelegate = ShowMessage;



            //3. Invocation

            notifyDelegate("Hello,Delegate");

        }


        public static void ShowMessage(string message)
        {

            Console.WriteLine(message);

        }

    }
}
