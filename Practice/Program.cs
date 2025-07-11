using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 7;

            Console.WriteLine($"a is {a}, b is {b}");
            Console.WriteLine($"a+b is {a + b}");
            Console.WriteLine($"a-b is {a - b}");
            Console.WriteLine($"a*b is {a * b}");
            Console.WriteLine($"a/b is {a / b}");
            Console.WriteLine($"a%b is {a % b}"); // Modulus operator gives the remainder of the division
        }
    }
}
