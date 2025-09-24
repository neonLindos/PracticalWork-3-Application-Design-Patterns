using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork_3_Application_Design_Patterns.interfaces;

namespace PracticalWork_3_Application_Design_Patterns
{
    
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount} через кредитную карту.");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount} через PayPal.");
        }
    }

    public class BankTransferPayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата {amount} через банковский перевод.");
        }
    }
}

