public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalGateway _paypal = new PayPalGateway();

    public void ProcessPayment(decimal amount)
    {
        _paypal.MakePayment((double)amount);
    }
}
