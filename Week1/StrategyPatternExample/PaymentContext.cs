public class PaymentContext
{
    private IPaymentStrategy _strategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void PayAmount(decimal amount)
    {
        if (_strategy == null)
        {
            Console.WriteLine("No payment method selected.");
            return;
        }
        _strategy.Pay(amount);
    }
}
