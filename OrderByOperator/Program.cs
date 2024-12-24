using System;
using System.Collections;
using System.Linq;

namespace OrderByOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 100 };
            var querySyntax = (from num in dataSourceInt orderby num select num).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
