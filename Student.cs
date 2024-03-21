using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_interfaceAndIEnumerable
{
    public class Student
    {
        public string FirstName { get; }

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"Student Name: {FirstName}";
        }
    }
}
