namespace DistinctSet
{
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

            var ms = students.Select(student => student.Id).Distinct().ToList();

            var qs = (from student in students select student.Name).Distinct().ToList();
              
            var iequatable = students.Distinct().ToList();

            Console.WriteLine();

            //List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 3, 5, 5, 5 };
            //var ms = numbers.Distinct().ToList();
            //var qs = (from num in numbers select num ).Distinct().ToList();
            //Console.WriteLine();
        }
    }
}
