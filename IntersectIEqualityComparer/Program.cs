using System.Diagnostics.CodeAnalysis;

namespace IntersectIEqualityComparer
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
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name.GetHashCode();

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
                new Student(){Id = 3, Name = "John"},
                new Student(){Id = 4, Name = "Mark"},
            };
            List<Student> class8 = new List<Student>()
            {
                new Student(){Id = 1, Name = "John" },
                new Student(){Id = 2, Name = "Kim"},
                new Student(){Id = 5, Name = "John"},
                new Student(){Id = 6, Name = "Mark"},
            };

            var ms = students.Intersect(class8, new StudentComparer()).ToList();

            Console.WriteLine();

        }
    }
}
