using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    public class ShoppingCart
    {
        public List<Food> Items { get; set; }

        public List<int> Amount { get; set; }

        public double Sum { get; set; }



        public ShoppingCart()
        {
            Items = new List<Food>();
            Amount = new List<int>();
            Sum = 0;
        }

        public void Add(Food item, int amount)
        {
            Items.Add(item);
            Amount.Add(amount);

        }

        public bool Remove(Food item, int amount)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] == item && Amount[i] >= amount)
                {
                    Items.RemoveAt(i);
                    Amount.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public double CalculateSum()
        {
            double ret = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                ret += (Items[i].Price * Amount[i]);
            }

            return ret;
        }

    }
}
