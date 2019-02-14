using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
//            var largestPrimeFactor = new LargestPrimeFactor(600851475143);
//            var largestPalindromeProduct = new LargestPalindromeProduct();
            var prime = TenThousandFirstPrime.FindPrime(10_001);
            Console.WriteLine(prime);
        }
    }
}
