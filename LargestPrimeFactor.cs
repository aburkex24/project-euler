namespace ProjectEuler
{
    public class LargestPrimeFactor
    {
        private long _number;

        public LargestPrimeFactor(long input) 
            => _number = input;
            
        public long FindLargestPrimeFactor()
        {
            for (long i = 2; i <= _number; i++)
            {
                if (IsFactor(_number, i))
                {
                    if (_number == i)
                        return _number;

                    _number = _number / i;
                    i = 1;
                }
            }

            return 0;
        }

        public bool IsFactor(long n, long i) 
            => n % i == 0;
    }
}