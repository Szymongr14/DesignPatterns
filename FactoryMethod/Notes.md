## 1. When to use Factory Method design pattern ?

- If we need to create instance of a new object/product, but we don't know exact type during runtime. 
---
## 2. There are two ways of using factory method design pattern:
- using a lot of if/else statements to determine type to create
- using reflection to detect type from assemblies
### When to choose which ?
- Use **if/else** when:
  - application is small/simple
  - we write performance-critical system
- Use **Reflection** when:
  - we fetch types from external configuration
  - system is highly extensible
  - having a lot of possible types to create

Usually we use class called ``FactoryProvider`` to get concrete factory of product:

```C#
public class PaymentFactoryProvider
{
    private readonly Dictionary<PaymentType, PaymentFactory> _factories;

    public PaymentFactoryProvider()
    {
        // if/else approach
        _factories = new Dictionary<PaymentType, PaymentFactory>
        {
            { PaymentType.Blik, new BlikPaymentFactory() },
            { PaymentType.CreditCard, new CreditCardPaymentFactory() },
            { PaymentType.PayPall, new PayPalPaymentFactory() }
        };
        
        // reflection approach
        _factories = new Dictionary<PaymentType, PaymentFactory>();

        foreach (var paymentType in Enum.GetValues<PaymentType>())
        {
            var factory = Assembly.GetExecutingAssembly().CreateInstance($"FactoryMethod.Factories.{paymentType}PaymentFactory") as PaymentFactory;
            _factories.Add(paymentType, factory!);
        }
    }

    public PaymentFactory GetPaymentFactory(PaymentType paymentType)
    {
        return _factories[paymentType];
    }
}
```

Example Video with FactoryProvider and reflection: https://www.youtube.com/watch?v=j_0ENoBi6W4&t=609s

---
## 3. Difference between Simple Factory and Factory Method
- Simple Factory contains only **ONE FACTORY** in which we specify which type we need to create
```C#
// ONE Factory for creating specific Payment
public class PaymentFactory{
    public Payment CreatePayment(Payments paymentType, decimal amount, Currencies currency){
        switch(paymentType){
            case PayPal:
                return new PayPalPayment;
            case CreditCard:
                return new CreditCardPayment;
            default:
                throw new NotImplementedException();
        }
    }
}

// client code
PaymentFactory factory = new PaymentFactory();
Payment payment = factory.CreatePayment(Payments.PayPal, 100, Currencies.USD);
```

- In Factory Method **each product has its own factory**
``` C#
// contract for factories
public abstract class PaymentFactory{
    public abstract Payment CreatePayment(decimal amount, Currencies currency);
}

// concrete factory
public class PayPalPaymentFactory : PaymentFactory{
    public override Payment CreatePayment(decimal amount, Currencies currency){
        return new PayPalPayment(amount, currency);
    }
}

// concrete factory
public class CreditCardPaymentFactory : PaymentFactory{
    public override Payment CreatePayment(decimal amount, Currencies currency){
        return new CreditCardPayment(amount, currency);
    }
}

// factory provider
// we could use if/else statements or reflection
public class PaymentFactoryProvider{
    public PaymentFactory GetFactory(Payments paymentType){
        switch(paymentType){
            case PayPal:
                return new PayPalPaymentFactory();
            case CreditCard:
                return new CreditCardPaymentFactory();
            default:
                throw new NotImplementedException();
        }
    }
}

// client code
PaymentFactoryProvider factoryProvider = new PaymentFactoryProvider();
PaymentFactory factory = factoryProvider.GetFactory(Payments.PayPal);
```