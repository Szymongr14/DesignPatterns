using FactoryMethod.Contracts;
using FactoryMethod.ConcretePayments;

namespace FactoryMethod.Factories;

public class PayPalPaymentFactory : PaymentFactory
{
    public override Payment CreatePayment(decimal amount, Currency currency)
    {
        return new PayPalPayment(amount, currency);
    }
}