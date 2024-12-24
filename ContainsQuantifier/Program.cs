namespace ContainsQuantifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id = 1, Name = "Kim"},
                new Student(){Id = 2, Name = "John"},
            };

            var isExist = students.Contains(new Student() { Id = 1, Name = "Kim" });

            var std = new Student() { Id = 1, Name = "Kim" };
            students.Add(std);

            var isExist1 = students.Contains(std);

            //var comparer = new StudentComparer();

            var ms = students.Contains(new Student() { Id = 1, Name = "Kim"}, new StudentComparer());

            var qs = (from student in students select student).Contains(new Student() { Id = 1, Name = "Kim" }, new StudentComparer());

            Console.WriteLine();
        }
    }
}
//List<string> students = new List<string>() { "Kim", "Jacob", "Simon", "John" };
//var isExist = students.AsEnumerable().Contains("Kim");

//var isExistQuery = (from student in students select student).Contains("Simo");