using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class School
    {
        public string Name;
        public List<Group> ListOfGroups;
        public List<Student> ListOfStudents;

        public School(string name)
        {
            Name = name;
            ListOfGroups = new List<Group>();
            ListOfStudents = new List<Student>();
        }

        public bool AddStudent(Student s)
        {
            if (ListOfStudents.Contains(s))
                return false;
            ListOfStudents.Add(s);
            return true;
        }

        public bool RemoveStudent(Student s)
        {
            if (!ListOfStudents.Contains(s))
                return false;
            foreach(Group g in ListOfGroups)
                g.Students.Remove(s);
            ListOfStudents.Remove(s);
            return true;
        }

        public bool AddStudentToGroup(Group g, Student s)
        {
            if (g.Students.Contains(s))
                return false;
            g.AddStudent(s);
            return true;
        }

        public bool RemoveStudentFromGroup(Group g, Student s)
        {
            if (!g.Students.Contains(s))
                return false;
            g.RemoveStudent(s);
            return true;
        }

        public void PrintStudents()
        {
            foreach(Group g in ListOfGroups)
            {
                Console.WriteLine(g.Name + ":");
                foreach (Student i in g.Students)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            

            Console.WriteLine("Students in school: ");
            foreach (Student i in ListOfStudents)
            {
                bool exists = false;
                foreach(Group g in ListOfGroups)
                {
                    if (g.Students.Contains(i))
                        exists = true;
                }
                if(!exists)
                    Console.WriteLine(i.ToString());
            }
        }



    }
}
