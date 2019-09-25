using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    public class Food
    {
        public string Name;
        public double Price;
        public double Amount;
        public Food(string name, double price, double amount = 1)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}
