using System;
using ExampleAttributes.Enums;
using ExampleAttributes.Extensions;

namespace ExampleAttributes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Show Fruits Name:");
            Console.WriteLine(Fruit.BloodOrange.GetDisplayName());
            Console.WriteLine(Fruit.Watermelon.GetDisplayName());
            Console.WriteLine(Fruit.Lemon.GetDisplayName());
            Console.WriteLine();
        }
    }
}
