namespace _06.CheckIfAWordIsPalindrome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CheckIfAWordIsPalindrome
    {
        public static void Main()
        {
            Console.WriteLine(IsPalindrome("ROTTOR"));
        }

        private static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
            {
                return true;
            }

            if (str[0] == str[str.Length - 1])
            {
                return IsPalindrome(str.Substring(1, str.Length - 2));
            }

            return false;
        }
    }
}

// Palindrome is a word that can be read the same forward and backward