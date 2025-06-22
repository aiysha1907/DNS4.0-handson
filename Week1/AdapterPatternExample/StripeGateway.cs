using System;

public class StripeGateway
{
    public void SendPayment(float amount)
    {
        Console.WriteLine($"Processing payment of ${amount} through Stripe...");
    }
}
