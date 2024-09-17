using FactoryMethod;

PaymentFactoryProvider.InitializeFactories().ProcessPayment(PaymentType.PayPall,1000,Currency.EUR);
PaymentFactoryProvider.InitializeFactories().ProcessPayment(PaymentType.CreditCard,90,Currency.USD);
PaymentFactoryProvider.InitializeFactories().ProcessPayment(PaymentType.Blik,560,Currency.EUR);