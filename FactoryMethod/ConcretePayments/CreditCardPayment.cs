using FactoryMethod.Contracts;

namespace FactoryMethod.ConcretePayments;

public class CreditCardPayment : Payment
{
    public CreditCardPayment(decimal amount, Currency currency) : base(amount, currency){}
    public override void ProcessPayment()
    {
        Console.WriteLine($"Payment {PaymentId} for {Amount} {Currency} has been successfully processed by Credit Card");
    }
}