using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteColor
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public Color FavoriteColor;

        public Person(string firstName, string lastName, Color favoriteColor)
        {
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {FavoriteColor}";
        }
    }
    public enum Color
    {
        Unknown,
        White,
        Black,
        Yellow,
        Green,
        Blue,
        Purple,
        Gray,
        Violet,
        Orange,
        Red
    }
}
