// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        INotifier notifier = new EmailNotifier();
        notifier = new SMSNotifierDecorator(notifier);
        notifier = new SlackNotifierDecorator(notifier);

        notifier.Send("Your bill is due tomorrow.");
    }
}

