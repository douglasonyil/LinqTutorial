using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace DistinctIEqualityComparer
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            return x.Id == y.Id && x.Name == y.Name;
        }
        public int GetHashCode([DisallowNull] Student obj)
        {
            if(object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id = 1, Name = "John"},
                new Student(){Id = 2, Name = "Kim"},
                new Student(){Id = 1, Name = "John"},
                new Student(){Id = 4, Name = "Mark"},
            };

            var comparer = new StudentComparer();

            var ms = students.Distinct(comparer).ToList();

            Console.WriteLine();
            
        }
    }
    

}
