using System.Reflection;
using FactoryMethod.Contracts;
using FactoryMethod.Factories;

namespace FactoryMethod;

public class PaymentFactoryProvider
{
    private readonly Dictionary<PaymentType, PaymentFactory> _factories;

    public static PaymentFactoryProvider InitializeFactories() => new PaymentFactoryProvider();

    private PaymentFactoryProvider()
    {
        // if/else approach
        _factories = new Dictionary<PaymentType, PaymentFactory>
        {
            { PaymentType.Blik, new BlikPaymentFactory() },
            { PaymentType.CreditCard, new CreditCardPaymentFactory() },
            { PaymentType.PayPall, new PayPalPaymentFactory() }
        };
        
        // // reflection approach
        // _factories = new Dictionary<PaymentType, PaymentFactory>();
        //
        // foreach (var paymentType in Enum.GetValues<PaymentType>())
        // {
        //     var factory = Assembly.GetExecutingAssembly().CreateInstance($"FactoryMethod.Factories.{paymentType}PaymentFactory") as PaymentFactory;
        //     _factories.Add(paymentType, factory!);
        // }
    }

    private PaymentFactory GetPaymentFactory(PaymentType paymentType)
    {
        return _factories[paymentType];
    }
    
    public void ProcessPayment(PaymentType paymentType, decimal amount, Currency currency)
    {
        var paymentFactory = GetPaymentFactory(paymentType);
        var payment = paymentFactory.CreatePayment(amount, currency);
        payment.ProcessPayment();
    }
}