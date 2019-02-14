using System;
using System.Net;
using static System.Math;

namespace ProjectEuler
{
    public static class TenThousandFirstPrime
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?

        public static double FindPrime(long n)
        {
            return Math.Round(n / (Math.Log(n) - 1));
        }

        private static bool IsPrimeNumber(long n)
        {
            throw new NotImplementedException();
        }
    }
}