namespace SortOrderbyoperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dataSource = new List<Employee>()
            {
                new Employee() {Id = 3, Name = "Smith", Email = "smith@gmail.com"},
                new Employee() {Id = 2, Name = "Alan", Email = "alan@gmail.com"},
                new Employee() {Id = 5, Name = "Thomas", Email = "thomas@gmail.com"},
                new Employee() {Id = 4, Name = "Anderson", Email = "anderson@gmail.com"}
            };

            var ms = dataSource.Where(emp => emp.Id > 3).OrderByDescending(emp => emp.Id).ToList();

            var qs = (from emp in dataSource
                      where emp.Name.Length > 6
                      orderby emp descending
                      select emp).ToList();

            foreach (var item in qs)
            {
                Console.WriteLine($"{item.Id}, Name = {item.Name}, Email = {item.Email}");
            }

            var querySyntax = (from emp in dataSource
                               where emp.Id > 2
                              orderby emp.Name
                              select emp).ToList();

            var methodSyntax = dataSource.Where(emp => emp.Name.Length > 5).OrderBy(emp => emp.Id).ToList();

            

            var dataSourceString = new List<string>() { "Smith", "Anderson", "Wright", "Mitchell", "Thomas", "Alien", "Evans", "Collins" };

            var qSyntax = (from name in dataSourceString
                               where name.Length > 5
                               orderby name descending
                               select name).ToList();

            var mSyntax = dataSourceString.Where(name => name.Length > 6).OrderByDescending(name => name).ToList();


            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };

            var queryS = (from num in dataSourceInt
                               where num > 10
                               orderby num descending
                               select num).ToList();

            Console.WriteLine();

            //var methodSyntax = dataSourceInt.Where(num => num > 10).OrderBy(num => num).ToList();

            //var dataSourceString = new List<string>() { "Smith", "Anderson", "Wright", "Mitchell", "Thomas", "Alien", "Evans", "Collins" };

            //var querySyntax = (from name in dataSourceString
            //                   where name.Length > 5
            //                   orderby name
            //                   select name).ToList();

            //var methodSyntax = dataSourceString.Where(name => name.Length > 6).OrderBy(name => name).ToList();


            //var dataSourceInt = new List<int>() {5, 12, 13, 1, 7, 53, 100 };

            //var querySyntax = (from num in dataSourceInt
            //                   where num > 10
            //                  orderby num
            //                  select num).ToList();

            //var methodSyntax = dataSourceInt.Where(num => num > 10).OrderBy(num => num).ToList();

            //Console.WriteLine();
        }
    }
}
