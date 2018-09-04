using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var largestPrimeFactor = new LargestPrimeFactor(600851475143);

            Console.WriteLine(largestPrimeFactor.FindLargestPrimeFactor());

            Console.WriteLine();

            Console.WriteLine("Hello World!");
        }
    }
}
