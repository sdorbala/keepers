using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weights = { 100, 200, 150, 80, 25, 75, 25, 90 };
            int limit = 200;
            Console.WriteLine("Number of boats needed = " + DCP.RescueBoats.NumberOfBoats(weights, limit));

            string palString1 = "babad";
            Console.WriteLine("Longest Palindrome in \"{0}\" is \"{1}\"", palString1, LeetCode.LongestPalindromeSubstring.LongestPalindrome(palString1));
            palString1 = "forgeeksskeegfor";
            Console.WriteLine("Longest Palindrome in \"{0}\" is \"{1}\"", palString1, LeetCode.LongestPalindromeSubstring.LongestPalindrome(palString1));
        }
    }
}
