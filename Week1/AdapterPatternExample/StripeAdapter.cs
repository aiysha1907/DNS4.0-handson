public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway _stripe = new StripeGateway();

    public void ProcessPayment(decimal amount)
    {
        _stripe.SendPayment((float)amount);
    }
}
