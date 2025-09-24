using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork_3_Application_Design_Patterns.interfaces;

namespace PracticalWork_3_Application_Design_Patterns
{

    public class CourierDelivery : IDelivery
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Заказ {order.Id} доставлен курьером.");
        }
    }

    public class PostDelivery : IDelivery
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Заказ {order.Id} отправлен почтой.");
        }
    }

    public class PickUpPointDelivery : IDelivery
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Заказ {order.Id} доступен в пункте выдачи.");
        }
    }
}
