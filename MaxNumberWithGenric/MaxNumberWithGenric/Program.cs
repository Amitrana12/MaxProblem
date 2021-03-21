using System;

namespace MaxNumberWithGenric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Welcome to my Max Number problem console app===");
            FindMax find = new FindMax();
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));
        }
    }
}
