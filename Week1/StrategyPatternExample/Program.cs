// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        Console.WriteLine("User selects Credit Card:");
        context.SetPaymentStrategy(new CreditCardPayment());
        context.PayAmount(1200);

        Console.WriteLine("\nUser selects PayPal:");
        context.SetPaymentStrategy(new PayPalPayment());
        context.PayAmount(950);
    }
}

