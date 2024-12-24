namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            var ms = rollNums.Reverse();

            var qs = (from num in rollNums
                      select num).Reverse();

            foreach (var item in ms)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<string> names = new List<string>() {"Mark", "John", "Adam", "Umar", "Bob" };
            //var methodSyntax = names.Reverse();

            var querySyntax = (from name in names
                              select name).Reverse();
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            var reversed = names.AsQueryable().Reverse();

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
