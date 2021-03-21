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
            Console.WriteLine("=================================");
            Console.WriteLine(find.MaximumFloatNumber(10.5f, 20.5f, 30.5f));
        }
    }
}
