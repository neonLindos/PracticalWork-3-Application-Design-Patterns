using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_3_Application_Design_Patterns.interfaces
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double total);
    }
}
