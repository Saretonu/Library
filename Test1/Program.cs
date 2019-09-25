using System;
using System.Linq;

namespace Test1
{
    class Program
    {
        public static School TTHK = new School("TTHK");

        static void Main(string[] args)
        {
            TTHK.ListOfStudents.Add(new Student("Tonu", "Sare", StudentStatus.Unknown));
            TTHK.ListOfStudents.Add(new Student("Karin", "Sarp", StudentStatus.Unknown));
            TTHK.ListOfStudents.Add(new Student("Robi", "Sast", StudentStatus.Unknown));

            TTHK.ListOfGroups.Add(new Group("TARge18"));
            TTHK.ListOfGroups[0].AddStudent(TTHK.ListOfStudents[0]);
            TTHK.ListOfGroups[0].AddStudent(TTHK.ListOfStudents[1]);
            TTHK.ListOfGroups[0].AddStudent(TTHK.ListOfStudents[2]);

            Console.WriteLine("Hello! What would you like to do?");
            while (StartAction()) ;
        }

        static bool StartAction()
        {
            string name = "";
            string firstname = "";
            string lastname = "";
            Student s = null;

            switch (Actions.StartAction())
            {
                case 1:
                    Console.Write("Write group name:");
                    name = Console.ReadLine();
                    foreach(Group g in TTHK.ListOfGroups)
                    {
                        if(g.Name.ToLower() == name.ToLower())
                        {
                            Console.WriteLine("Group allready exists!");
                            return true;
                        }
                    }
                    TTHK.ListOfGroups.Add(new Group(name));
                    Console.WriteLine("Group added to school!");
                    break;

                case 2:
                    Console.Write("Write group name:");
                    name = Console.ReadLine();

                    Group group =TTHK.ListOfGroups.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

                    if(group == null)
                    {
                        Console.WriteLine("Group doesn´t exist!");
                        return true;
                    }
                    TTHK.ListOfGroups.Add(new Group(name));
                    Console.WriteLine("Group removed from school!");
                    break;


                case 3:
                    Console.Write("Write student firstname:");
                    firstname = Console.ReadLine();
                    Console.Write("Write student lastname:");
                    lastname = Console.ReadLine();

                    s = new Student(firstname, lastname, StudentStatus.Unknown);
                    if(TTHK.AddStudent(s))
                    {
                        Console.WriteLine("Student added to school!");
                    }
                    else
                    {
                        Console.WriteLine("Student allready exists in school!");
                    }
                    break;

                case 4:
                    Console.Write("Write student firstname:");
                    firstname = Console.ReadLine();
                    Console.Write("Write student lastname:");
                    lastname = Console.ReadLine();

                    s = TTHK.ListOfStudents.FirstOrDefault(x => x.FirstName.ToLower() == firstname.ToLower() && x.LastName.ToLower() == lastname.ToLower());
                    if (s != null && TTHK.RemoveStudent(s))
                    {
                        Console.WriteLine("Student removed from school!");
                    }
                    else
                    {
                        Console.WriteLine("Student doesn´t exist in school!");
                    }
                    break;

                case 5:
                    Console.Write("Write student firstname:");
                    firstname = Console.ReadLine();
                    Console.Write("Write student lastname:");
                    lastname = Console.ReadLine();

                    s = TTHK.ListOfStudents.FirstOrDefault(x => x.FirstName.ToLower() == firstname.ToLower() && x.LastName.ToLower() == lastname.ToLower());
                    if (s != null)
                    {
                        int nr = ChooseGroup();
                        if (TTHK.AddStudentToGroup(TTHK.ListOfGroups[nr], s))
                            Console.WriteLine("Student added to group!");
                        else
                            Console.WriteLine("Student allready exists in group!");
                    }
                    else
                    {
                        Console.WriteLine("Student doesn´t exist in school!");
                    }
                    break;

                case 6:
                    Console.Write("Write student firstname:");
                    firstname = Console.ReadLine();
                    Console.Write("Write student lastname:");
                    lastname = Console.ReadLine();

                    s = TTHK.ListOfStudents.FirstOrDefault(x => x.FirstName.ToLower() == firstname.ToLower() && x.LastName.ToLower() == lastname.ToLower());
                    if (s != null)
                    {
                        int nr = ChooseGroup();
                        if (TTHK.RemoveStudentFromGroup(TTHK.ListOfGroups[nr], s))
                            Console.WriteLine("Student removed from group!");
                        else
                            Console.WriteLine("Student doesn´t exist in group!");
                    }
                    else
                    {
                        Console.WriteLine("Student doesn´t exist in school!");
                    }
                    break;
                case 7:
                    TTHK.PrintStudents();
                    break;
                case 8:
                    return false;
                                       
            }
            Console.ReadKey();
            Console.Clear();
            return true;
        }

        public static int ChooseGroup()
        {
            for (int i = 0; i < TTHK.ListOfGroups.Count; i++)
            {
                Console.WriteLine($"{i+1}. {TTHK.ListOfGroups[i].Name}");
            }
            while (true)
            {
                Console.Write("CHOOSE: ");
                if (int.TryParse(Console.ReadLine(), out int ret) && ret <= TTHK.ListOfGroups.Count && ret > 0)
                {
                    Console.Clear();
                    return ret;
                }
                Console.WriteLine($"Insert a number between 1 and {TTHK.ListOfGroups.Count}!");
            }
        }
    }
}
