using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalWork_3_Application_Design_Patterns.interfaces;

namespace PracticalWork_3_Application_Design_Patterns
{
    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total) => total;
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly double _percent;
        public PercentageDiscount(double percent) => _percent = percent;

        public double ApplyDiscount(double total) => total * (1 - _percent);
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly double _amount;
        public FixedAmountDiscount(double amount) => _amount = amount;

        public double ApplyDiscount(double total) => Math.Max(total - _amount, 0);
    }

}
