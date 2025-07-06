// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        IPaymentProcessor paypalProcessor = new PayPalAdapter();
        IPaymentProcessor stripeProcessor = new StripeAdapter();

        Console.WriteLine("Using PayPal:");
        paypalProcessor.ProcessPayment(500.00m);

        Console.WriteLine("\nUsing Stripe:");
        stripeProcessor.ProcessPayment(250.75m);
    }
}

