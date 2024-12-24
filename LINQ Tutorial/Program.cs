namespace LINQ_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Onyil", Email = "onyil@gmail.com"},
                new Employee() {Id = 2, Name = "Douglas", Email = "douglas@gmail.com"},
                new Employee() {Id = 3, Name = "Mercy", Email = "mercy@gmail.com"},
                new Employee() {Id = 4, Name = "Ogutu", Email = "ogutu@gmail.com"}
            };

           

            var selectQuery = (from emp in employees
                              select new
                              {
                                  CustomerId = emp.Id,
                                  CustomerName = emp.Name,
                                  //StudentEmail = emp.Email
                              }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Customer Id = {item.CustomerId}, Customer Name = {item.CustomerName}");
            }
            Console.WriteLine();

            var selectMethod = employees.Select(emp => new Student()
            {
                StudentId = emp.Id,
                StudentName = emp.Name,
                StudentEmail = emp.Email
            }).ToList();
            

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Studen Id = {item.StudentId}, Student Name = {item.StudentName}");
            }

            Console.WriteLine();

            var basicQuery = (from emp in employees
                             select emp).ToList();

            var basicMethod = employees.ToList();

            var basicProQuery = (from emp in employees
                                select emp.Id + 1).ToList();

           

            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
            }

            Console.WriteLine();

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}, Email = {item.Email}");
            }

            Console.WriteLine();

            for (int i = 0; i < basicProQuery.Count; i++)
            {
                int item = basicProQuery[i];
                Console.WriteLine($"Id = {item}");
            }
        }
    }
}
