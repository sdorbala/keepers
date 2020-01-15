using System;
using System.Diagnostics;

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

            int k = 10;
            Console.WriteLine("kth row in Pascal's Triangle when k = {0} is {1}.", k, "[" + string.Join(",", DCP.KthPascalTriangleRow.GetKthRow(k)) + "]");

            int[] subsequence = { 8, 5, -1, 10, 6, 0, 12, 7, 15, 8 };
            Console.WriteLine("Longest increasing subsequence in {0} is {1}", "[" + string.Join(",", subsequence) + "]", LeetCode.LongestIncreasingSubsequence.LengthOfLIS(subsequence));
        }
    }
}
