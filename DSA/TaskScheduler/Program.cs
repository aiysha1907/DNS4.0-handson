// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Scheduler scheduler = new Scheduler();

        scheduler.AddTask("Email Response", 3);
        scheduler.AddTask("Database Backup", 1);
        scheduler.AddTask("Update Dashboard", 2);
        scheduler.AddTask("Slack Message", 1);

        scheduler.ShowAllTasks();

        Console.WriteLine("\nRunning tasks:");
        scheduler.RunNext();
        scheduler.RunNext();
        scheduler.RunNext();
        scheduler.RunNext();
        scheduler.RunNext(); // No tasks left
    }
}

