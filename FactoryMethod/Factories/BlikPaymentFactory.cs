using FactoryMethod.ConcretePayments;
using FactoryMethod.Contracts;

namespace FactoryMethod.Factories;

public class BlikPaymentFactory : PaymentFactory
{
    public override Payment CreatePayment(decimal amount, Currency currency)
    {
        return new BlikPayment(amount, currency);
    }
}