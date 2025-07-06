using System;

public class PayPalGateway
{
    public void MakePayment(double value)
    {
        Console.WriteLine($"Processing payment of ${value} through PayPal...");
    }
}
