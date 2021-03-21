using System;

namespace MaxNumberWithGenric
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("===Welcome to my Max Number problem console app===");
            FindMax find = new FindMax();
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));
            Console.WriteLine("=================================");
            Console.WriteLine(find.MaximumFloatNumber(10.5f, 20.5f, 30.5f));
            Console.WriteLine("=================================");
            Console.WriteLine(find.MaximumStringNumber("Apple", "Banana", "Carrot"));*/
            int[] intArray = { 112, 344, 432, 555, 678 };
            FindMax<int> first = new FindMax<int>(intArray);
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            FindMax<float> second = new FindMax<float>(floatArray);
            string[] stringArray = { "111", "222", "333", "55", "999" };
            FindMax<string> third = new FindMax<string>(stringArray);

            first.PrintMaxValue();
            Console.WriteLine("=================================");
            second.PrintMaxValue();
            Console.WriteLine("=================================");
            third.PrintMaxValue();
        }
    }
}
