using System;
using System.Linq;

namespace P03_Mankind.Models
{
    internal class Student : Human
    {
        private string _facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => _facultyNumber;
            set
            {
                if (value.Length < 5 || 10 < value.Length || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                _facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\r\nFaculty number: {FacultyNumber}";
        }
    }
}