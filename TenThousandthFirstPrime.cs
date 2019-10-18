using System;

namespace ProjectEuler
{
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    //What is the 10 001st prime number?
    public class TenThousandthFirstPrime
    {
        private bool _searching;

        public TenThousandthFirstPrime()
            => _searching = true;

        public long FindTenThousandthFirstPrime(int n)
        {
            var count = 0; 
            long currentPrime = 2;

            while (_searching)
            {
                if (IsPrime(currentPrime))
                    count++;

                if (count == n) // 10_001
                    break;

                currentPrime++;
            }

            return currentPrime;
        }

        public bool TestIsPrime(int n)
            => IsPrime(n);

        private bool IsPrime(long n)
        {
            var divisibleBy = 0;
            var i = 2;

            while (i <= n)
            {
                if (n % i == 0)
                    divisibleBy++;

                i++;
            }

            if (divisibleBy > 1)
                return false;

            return true;
        }
    }
}