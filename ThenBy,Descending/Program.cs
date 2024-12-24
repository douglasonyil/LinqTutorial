namespace ThenBy_Descending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 3, Email = "smith@gmail.com", LastName = "Smith", FirstName = "Foo"},
                new Employee(){Id = 2, Email = "thomas@gmail.com", LastName = "Thomas", FirstName = "Mark"},
                new Employee(){Id = 1, Email = "allen@gmail.com", LastName = "Allen", FirstName = "Mark"},
                new Employee(){Id = 4, Email = "anderson@gmail.com", LastName = "Anderson", FirstName= "Foo"}
            };

            var ms = dataSource.OrderBy(emp => emp.FirstName).ThenBy(emp => emp.LastName).ThenBy(emp => emp.Id).ToList();
            
            Console.WriteLine();
        }
    }
}
