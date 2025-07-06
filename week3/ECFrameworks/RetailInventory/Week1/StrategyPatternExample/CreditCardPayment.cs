using System;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying ₹{amount} using Credit Card.");
    }
}
