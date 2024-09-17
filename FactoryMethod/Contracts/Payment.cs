namespace FactoryMethod.Contracts;

public abstract class Payment
{
    protected decimal Amount { get; set; }
    public Currency Currency { get; set; }
    protected Guid PaymentId { get; set; }

    protected Payment(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
        PaymentId = Guid.NewGuid();
    }

    public abstract void ProcessPayment();
}