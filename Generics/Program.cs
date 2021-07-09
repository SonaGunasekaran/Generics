using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Problems");
            int[] intArray = { 20, 15, 40, 60, 25 };
            float[] floatArray = { 2.0F, 1.5F, 4.0F, 6.0F, 2.5F };
            string[] stringArray = { "Apple", "Peach", "Banana" };
            MaxOfThree<int> maxInt = new MaxOfThree<int>(intArray);
            MaxOfThree<float> maxFloat = new MaxOfThree<float>(floatArray);
            MaxOfThree<string> maxString = new MaxOfThree<string>(stringArray);
            maxInt.PrintValue();
            maxFloat.PrintValue();
            maxString.PrintValue();
        }
    }
}
