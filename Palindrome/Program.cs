using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input cannot be null");
            }

            if (input.Length < 2)
            {
                return true;
            }

            return IsPalindromeRecursive(input, 0, input.Length - 1);
        }

    }
}