using FactoryMethod.Contracts;
using FactoryMethod.ConcretePayments;

namespace FactoryMethod.Factories;

public class CreditCardPaymentFactory : PaymentFactory
{
    public override Payment CreatePayment(decimal amount, Currency currency)
    {
        return new CreditCardPayment(amount, currency);
    }
}