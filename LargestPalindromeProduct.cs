using System;
using System.Linq;

namespace ProjectEuler 
{
    // problem 4 solution
    public class LargestPalindromeProduct
    {
        private short _left;
        private short _right;
        private readonly byte _finalThreeDigit;
        private int _palindrome;

        public LargestPalindromeProduct()
        {   
            _left = 999;
            _right = 999;
            _finalThreeDigit = 99;
            _palindrome = 0;
        }

        public int FindPalindrome()
        {
            // two running for loops?
            while (_right > _finalThreeDigit)
            {
                // do something
                while (_left > _finalThreeDigit)
                {
                    var product = _left * _right;

                    if (IsPalindrome(product))
                    {
                        if (_palindrome < product)
                            _palindrome = product;
                    }

                    _left--;
                }

                if (_left == _finalThreeDigit)
                    _left = 999;

                _right--;
            }
            
            return _palindrome; // the number combinations did not return a palindrome  
        }

        private bool IsPalindrome(int input)
        {
            // split a number into a char array and reverse it and back to a char array from and IEnumerator 
            var inputCharArray = input.ToString().ToCharArray().Reverse().ToArray();
            var inputStringReversed = new string(inputCharArray);
            var inputReversed = int.Parse(inputStringReversed);

            if (inputReversed == input)
                return true;
            
            return false;
        }
    }
}