using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    public static class Actions
    {
        private static List<string> _listOfActions = new List<string> { "1. Create group.", "2. Remove group.", "3. Add student.", "4. Remove student.", "5. Add student to group.", "6. Remove student from group." ,"7. Print students" , "8. EXIT." };

        public static List<string> ListOfActions
        {
            get
            {

                return _listOfActions;
            }
        }

        public static int StartAction()
        {


            Console.WriteLine("ACTIONS:");
            foreach(string i in _listOfActions)
                Console.WriteLine(i);
            while(true)
            {
                Console.Write("CHOOSE: ");
                if (int.TryParse(Console.ReadLine(), out int ret) && ret <= _listOfActions.Count && ret > 0)
                {
                    Console.Clear();
                    return ret;
                }
                Console.WriteLine($"Insert a number between 1 and {_listOfActions.Count}!");
            }
            
                
        }
    }
}
