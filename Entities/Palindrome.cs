using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    class Palindrome
    {
        public string Word { get; set; }

        public Palindrome()
        {
        }

        public Palindrome(string word)
        {
            Word = word;
        }

        public static bool IsPalindrome(string word)
        {
            var length = word.Length;
            for(int i = 0; i <= length / 2; i++)
            {
                if(word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
