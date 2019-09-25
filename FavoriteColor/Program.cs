using System;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteColor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people = Logic.GetPeopleFromFile(@"C:\Users\opilane\Desktop\Datafile.Txt");
            while (true)
            {
                Console.Write("Hi! Please enter your last name: ");
                string lastName = Console.ReadLine();

                Person someone = people.FirstOrDefault(x => x.LastName == lastName);
                if(someone == null)
                {
                    Console.Write("Hi! Please enter your first name: ");
                    string firstName = Console.ReadLine();
                    someone = new Person(firstName, lastName, Color.Unknown);
                    people.Add(someone);
                }
                Console.WriteLine($"Hi, {someone.FirstName}! What's your favourite color?");
                var answer = Console.ReadLine();

                Enum.TryParse(answer, true, out someone.FavoriteColor);

                Console.WriteLine("Continue? Y/N");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Logic.SetPeopleToFile(people, @"C:\Users\opilane\Desktop\Datafile.Txt");


        }
    }
}
