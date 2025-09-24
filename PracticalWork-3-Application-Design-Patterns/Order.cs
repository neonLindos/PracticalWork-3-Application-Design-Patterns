using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork_3_Application_Design_Patterns.interfaces;

namespace PracticalWork_3_Application_Design_Patterns
{
    public class Order
    {
        private static int _counter = 1;
        public int Id { get; }
        private List<(string Name, int Quantity, double Price)> _items = new List<(string, int, double)>();

        public IPayment PaymentMethod { get; set; }
        public IDelivery DeliveryMethod { get; set; }
        public INotification Notification { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; } = new NoDiscount();

        public Order()
        {
            Id = _counter++;
        }

        public void AddItem(string name, int quantity, double price)
        {
            _items.Add((name, quantity, price));
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in _items)
                total += item.Quantity * item.Price;

            return DiscountStrategy.ApplyDiscount(total);
        }

        public void ProcessOrder()
        {
            double total = CalculateTotal();
            PaymentMethod.ProcessPayment(total);
            DeliveryMethod.DeliverOrder(this);
            Notification.SendNotification($"Ваш заказ {Id} на сумму {total} обработан.");
        }
    }
}
