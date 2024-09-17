namespace FactoryMethod.Contracts;

public abstract class PaymentFactory
{
    public abstract Payment CreatePayment(decimal amount, Currency currency);
}