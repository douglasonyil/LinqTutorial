using System.Diagnostics.CodeAnalysis;

namespace ExceptSetOperator
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
                new Student(){Id = 3, Name = "John"},
                new Student(){Id = 4, Name = "Mark"},
                //new Student(){Id = 4, Name = "Mark1"},
            };
            List<Student> students1 = new List<Student>()
            {
                new Student(){Id = 1, Name = "John"},
                new Student(){Id = 2, Name = "Kim"},
                new Student(){Id = 5, Name = "John"},
                new Student(){Id = 6, Name = "Mark"},
            };

            var ms = students.Except(students1).ToList();

            var ms1 = students.Select(std => std.Name).Except(students1.Select(std => std.Name)).ToList();

            var ms2 = students.Select(std => new {std.Id,  std.Name}).Except(students1.Select(std => new {std.Id, std.Name})).ToList();

            var ms3 = students.Except(students1, new StudentComparer()).ToList();

            var qs = (from std in students select std).Except(students1, new StudentComparer()).ToList();

            Console.WriteLine();
        }
    }
}
//List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
//List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

//var ms = datasource1.Except(datasource2).ToList();

//Console.WriteLine();