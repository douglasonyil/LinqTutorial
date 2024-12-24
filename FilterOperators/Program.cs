using System;
using System.Linq;
using System.Collections;
using System.ComponentModel.Design;

namespace FilterOperators
{
    internal class Program
    {
        private static readonly char M;

        static void Main(string[] args)
        {

            var dataSource = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Douglas", Email = "douglaso@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() {Technology = "C#"},
                    new Techs() {Technology = "JAVA"},
                    new Techs() {Technology = ".NET"},
                    new Techs() {Technology = "SQL"},
                    new Techs() {Technology = "ASP.NET"}
                }
                },
                new Employee(){Id = 2, Name = "Onyil", Email = "onyil@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() {Technology = "C#"},
                    new Techs() {Technology = "LINQ"},
                    new Techs() {Technology = "SQL"}
                }
                },
                new Employee(){Id = 3, Name = "Mercy", Email = "mercy@gmail.com", Programming =
                new List<Techs>
                {
                    new Techs() {Technology = "R"},
                    new Techs() {Technology = "PYTHON"},
                }
                },
                new Employee(){Id = 4, Name = "Ogutu", Email = "ogutu@gmail.com", Programming = new List<Techs> ()},
                new Employee(){Id = 5, Name = "Anne", Email = "anne@gmail.com", Programming = new List<Techs> () }
            };

            var methodSyntax = dataSource.Where(emp => emp.Programming.Count == 2 && emp.Id == 3).ToList();

            var querySyntax = (from employee in dataSource
                               where employee.Programming.Count == 3 || employee.Name == "Anne"
                               select employee).ToList();

            //foreach (var item in methodSyntax)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();

                    
        }
    }
}
//var dataSource = new List <int> () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var methodSyntax = dataSource.Where(number => number < 6 || number >= 10).ToList();

//var querySyntax = (from num in dataSource where num > 6 select num).ToList();

//var dataSource = new List<string>() { "Onyil", "Mercy", "Douglas" };

//var methodSyntax = dataSource.Where(str => str.Length == 5 && str.Contains('n')).ToList();