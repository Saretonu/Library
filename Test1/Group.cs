using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Group
    {
        private string _name;
        private List<Student> _students;

        public string Name
        {
            get { return _name; }
        }

        public List<Student> Students
        {
            get { return _students; }
        }

        public Group(string name)
        {
            _name = name;
            _students = new List<Student>();

        }

        public bool AddStudent(Student student)
        {
            if (_students.Contains(student))
                return false;
            student.Status = StudentStatus.Studying;
            _students.Add(student);
            return true;
        }

        public bool RemoveStudent(Student student)
        {
            StudentStatus s;
            if (!_students.Contains(student))
                return false;
            Console.WriteLine("What is the reason?");
            Console.WriteLine("1. Graduated");
            Console.WriteLine("2. Exmatriculated");
            while(!Enum.TryParse(Console.ReadLine(), true, out s))
            {
                Console.WriteLine("Write Graduated or Exmatriculated");
            }
            student.Status = s;
            _students.Remove(student);
            return true;
        }
    }
}
