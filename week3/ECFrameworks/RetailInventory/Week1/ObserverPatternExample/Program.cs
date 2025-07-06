// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main(string[] args)
    {
        StockMarket tcs = new StockMarket("TCS", 3500.00);

        IObserver mobile = new MobileApp();
        IObserver web = new WebApp();

        tcs.RegisterObserver(mobile);
        tcs.RegisterObserver(web);

        Console.WriteLine("Updating TCS stock price to 3550...");
        tcs.SetPrice(3550);

        Console.WriteLine("\nRemoving Web App and updating again...");
        tcs.RemoveObserver(web);
        tcs.SetPrice(3600);
    }
}
