namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>
            {
                new Employee(){ID = 1, Name = "Onyil", Email = "onyil@gmail.com", Programming = new List<string>() {"C#", "PHP", "JAVA" } },
                new Employee(){ID = 2, Name = "Douglas", Email = "douglas@gmail.com", Programming = new List<string>() {"LINQ", "C#", "MVC"}},
                new Employee(){ID = 3, Name = "Mercy", Email = "mercy@gmail.com", Programming = new List<string>() {"SQL", "PYTHON", "JAVASCRIPT"}}
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"Programming Language : {item}");
            }

            //List<string> list = new List<string>() { "Onyil", "Douglas" };


            //var methodResult = list.SelectMany(x=> x).ToList();

            //foreach (var item in methodResult)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
