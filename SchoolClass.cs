using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_interfaceAndIEnumerable
{
    internal class SchoolClass : IEnumerable<Student>
    {
        public string ClassName { get; }

        private List<Student> classRoster = new List<Student>();

        public SchoolClass(string className, List<string> studentNames)
        {
            ClassName = className;
            foreach (var name in studentNames)
            {
                classRoster.Add(new Student(name));
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in classRoster)
            {
                yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)classRoster).GetEnumerator();
        }
    }
}
