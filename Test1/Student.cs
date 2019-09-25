using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private int _personalCode;
        private bool _isStudying;
        private StudentStatus _status; 

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public int PersonalCode
        {
            get
            {
                return _personalCode;
            }
        }
        public bool IsStudying
        {
            get
            {
                return _isStudying;
            }
        }
        public StudentStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                if (value == StudentStatus.Studying)
                    _isStudying = true;
                else
                    _isStudying = false;
            }
        }
        public Student(string firstName, string lastName, StudentStatus status)
        {
            _firstName = firstName;
            _lastName = lastName;
            Status = status;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}, Status {_status.ToString()}";
        }

    }

    public enum StudentStatus
    {
        Unknown,
        Studying,
        Graduated,
        Exmatriculated,
        OnAcademicLeave
    }
}
