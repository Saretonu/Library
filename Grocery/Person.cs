using System;
using System.Collections.Generic;
using System.Text;

namespace Grocery
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public ShoppingCart Cart;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Cart = new ShoppingCart();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
