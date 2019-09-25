using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace FavoriteColor
{
    public static class Logic
    {
        public static List<Person> GetPeopleFromFile(string fileLocation)
        {
            return TextToPeople(TextFile.ReadFile(fileLocation));
        }

        public static bool SetPeopleToFile(List<Person> people, string fileLocation)
        {
            List<string> set = new List<string>();
            foreach (Person i in people)
            {
                set.Add($"{i.FirstName} {i.LastName},{i.FavoriteColor.ToString()}");
            }
            return TextFile.WriteFile(set, fileLocation);
        }

        public static List<Person> TextToPeople(List<string> lines)
        {
            List<Person> ret = new List<Person>();

            if (lines == null)
                return null;

            foreach (string i in lines)
            {
                if(i.Contains(","))
                {
                    string firstname = i.TrimEnd(' ');
                    string lastname = i.TrimStart(' ');
                    lastname = lastname.TrimEnd(',');
                    Color favoriteColor = Color.Unknown;
                    Enum.TryParse(i.TrimStart(','), true, out favoriteColor);
                    ret.Add(new Person(firstname, lastname, favoriteColor));
                }

            }

            return ret;
        }
    }
}
