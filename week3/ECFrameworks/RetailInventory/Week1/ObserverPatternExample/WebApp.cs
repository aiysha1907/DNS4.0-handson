using System;

public class WebApp : IObserver
{
    public void Update(string stockName, double price)
    {
        Console.WriteLine($"[Web App] {stockName} updated to ₹{price}");
    }
}
