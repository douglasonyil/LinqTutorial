namespace IntersectSetOperator
{
    class Student: IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Student? other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;    
            }
            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

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

            var mss = students.Intersect(class8).ToList();

            //ANONYMOUS METHOD
            var ms = students.Select(std => new{std.Id, std.Name}).Intersect(class8.Select(cl => new { cl.Id, cl.Name })).ToList();

            Console.WriteLine();

        }
    }
}
//List<string> datasource1 = new List<string>() { "A", "B", "C", "D"};
//List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

//var ms = datasource1.Intersect(datasource2).ToList();

//var qs = (from c in datasource2 select c).Intersect(datasource1).ToList();

//Console.WriteLine();