using System;

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying ₹{amount} using PayPal.");
    }
}
