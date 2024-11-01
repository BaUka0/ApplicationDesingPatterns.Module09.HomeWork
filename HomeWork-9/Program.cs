using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator
            Beverage beverage1 = new Espresso();
            beverage1 = new MilkDecorator(beverage1);
            beverage1 = new SugarDecorator(beverage1);
            Console.WriteLine($"Описание: {beverage1.GetDescription()}");
            Console.WriteLine($"Стоимость: {beverage1.Cost()}");

            Beverage beverage2 = new Latte();
            beverage2 = new WhippedCreamDecorator(beverage2);
            beverage2 = new Caramel(beverage2);
            Console.WriteLine($"Описание: {beverage2.GetDescription()}");
            Console.WriteLine($"Стоимость: {beverage2.Cost()}");

            Beverage beverage4 = new Tea();
            beverage4 = new SugarDecorator(beverage4);
            beverage4 = new WhippedCreamDecorator(beverage4);
            Console.WriteLine($"Описание: {beverage4.GetDescription()}");
            Console.WriteLine($"Стоимость: {beverage4.Cost()}");

            //Adapter
            IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
            paypalProcessor.ProcessPayment(25000);

            StripePaymentService stripeService = new StripePaymentService();
            IPaymentProcessor stripeAdapter = new StripePaymentAdapter(stripeService);
            stripeAdapter.ProcessPayment(200000);

            CryptoPaymentService cryptoService = new CryptoPaymentService();
            IPaymentProcessor cryptoAdapter = new CryptoPaymentAdapter(cryptoService);
            cryptoAdapter.ProcessPayment(500000);
        }
    }
}
