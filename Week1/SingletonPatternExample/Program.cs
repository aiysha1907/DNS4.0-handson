// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger instances are the same.");
        }
        else
        {
            Console.WriteLine("Different logger instances exist.");
        }
    }
}
