using PracticalWork_3_Application_Design_Patterns;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Order order = new Order();

order.AddItem("Ноутбук", 1, 1000);
order.AddItem("Мышка", 2, 25);

order.PaymentMethod = new CreditCardPayment();
order.DeliveryMethod = new CourierDelivery();
order.Notification = new EmailNotification();
order.DiscountStrategy = new PercentageDiscount(0.1); // 10%

order.ProcessOrder();