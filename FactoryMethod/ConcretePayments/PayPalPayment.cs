using FactoryMethod.Contracts;

namespace FactoryMethod.ConcretePayments;

public class PayPalPayment : Payment
{
    public PayPalPayment(decimal amount, Currency currency) : base(amount, currency)
    {
    }

    public override void ProcessPayment()
    {
        Console.WriteLine($"Payment {PaymentId} for {Amount} {Currency} has been successfully processed by PayPal");
    }
}