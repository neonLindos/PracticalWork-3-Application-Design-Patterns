using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork_3_Application_Design_Patterns.interfaces;

namespace PracticalWork_3_Application_Design_Patterns
{
    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email уведомление: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS уведомление: {message}");
        }
    }

}
