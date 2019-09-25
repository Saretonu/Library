using System;
using System.Collections.Generic;
using System.Linq;

namespace Grocery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> groceries = new List<Food>
            {
                new Food("banana", 1.2),
                new Food("potatoes", 1),
                new Food("icecream", 2.5)
            };
            Console.WriteLine("Please enter your first name!");
            string firstname = Console.ReadLine();

            Console.WriteLine($"Hi, {firstname}! Please enter your last name!");
            string lastname = Console.ReadLine();

            Person client = new Person(firstname, lastname);

            Console.WriteLine($"Welcome to our shop, {client}!");
            client.Cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine($"What do you want to buy?");

                ChooseFood(groceries, client);

                Console.WriteLine("Something else?");

                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
            double sum = client.Cart.CalculateSum();

            Console.WriteLine($"Your total is {sum}. Thank you for visiting!");

            Console.ReadKey();
        }

        public static void ChooseFood(List<Food> groceries, Person client)
        {

            string food = Console.ReadLine();
            Food chosenFood = groceries.FirstOrDefault(x => x.Name == food);

            if (chosenFood == null)
            {
                Console.WriteLine($"Excuse me, we don´t have {food} in our shop.");
            }
            else
            {
                Console.WriteLine($"How much would you like?");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        client.Cart.Add(chosenFood, amount);
                        break;
                    }
                    else
                        Console.WriteLine("Write a number!");
                }
            }
        }
    }
}
