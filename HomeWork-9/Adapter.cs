using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Обработка платежа через PayPal: {amount}");
        }
    }
    public class StripePaymentService
    {
        public void MakeTransaction(double totalAmount)
        {
            Console.WriteLine($"Обработка платежа через Stripe: {totalAmount}");
        }
    }
    public class StripePaymentAdapter : IPaymentProcessor
    {
        private StripePaymentService _stripePaymentService;

        public StripePaymentAdapter(StripePaymentService stripePaymentService)
        {
            _stripePaymentService = stripePaymentService;
        }

        public void ProcessPayment(double amount)
        {
            _stripePaymentService.MakeTransaction(amount);
        }
    }
    public class CryptoPaymentService
    {
        public void MakeTransaction(double totalAmount)
        {
            Console.WriteLine($"Обработка платежа через Крипту: {totalAmount}");
        }
    }
    public class CryptoPaymentAdapter : IPaymentProcessor
    {
        private CryptoPaymentService _cryptoPaymentService;

        public CryptoPaymentAdapter(CryptoPaymentService cryptoPaymentService)
        {
            _cryptoPaymentService = cryptoPaymentService;
        }

        public void ProcessPayment(double amount)
        {
            _cryptoPaymentService.MakeTransaction(amount);
        }
    }
    class Adapter
    {
    }
}
