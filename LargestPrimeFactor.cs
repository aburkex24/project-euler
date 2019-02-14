namespace ProjectEuler
{
    // problem 3
    public class LargestPrimeFactor
    {
        private long _factor;

        public LargestPrimeFactor(long input) 
            => _factor = input;
            
        public long FindLargestPrimeFactor()
        {
            for (long i = 2; i <= _factor; i++)
            {
                if (!IsFactor(_factor, i)) continue;
                if (_factor == i)
                    return _factor;

                _factor = _factor / i;
                i = 1;
            }

            return 0;
        }

        public bool IsFactor(long n, long i) 
            => n % i == 0;
    }
}