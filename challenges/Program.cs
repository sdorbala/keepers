using System;
using System.Diagnostics;
using System.Collections.Generic;

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
            Console.WriteLine("Longest increasing subsequence in {0} is {1}", 
                    "[" + string.Join(",", subsequence) + "]", 
                    LeetCode.LongestIncreasingSubsequence.LengthOfLIS(subsequence));

            #region Shortest Distance
            var paths = new Dictionary<int, int>();
            var map = new Dictionary<int, Dictionary<int, int>>();
            paths.Add(1, 10);
            paths.Add(2, 8);
            paths.Add(3, 15);

            map.Add(0, paths);

            paths = new Dictionary<int, int>();
            paths.Add(3, 12);

            map.Add(1, paths);

            paths = new Dictionary<int, int>();
            paths.Add(4, 10);

            map.Add(2, paths);

            paths = new Dictionary<int, int>();
            paths.Add(4, 10);
            paths.Add(0, 17);

            map.Add(3, paths);

            paths = new Dictionary<int, int>();
            paths.Add(0, 10);

            map.Add(4, paths);

            var elevations = new Dictionary<int, int>();
            elevations.Add(0, 5);
            elevations.Add(1, 25);
            elevations.Add(2, 15);
            elevations.Add(3, 20);
            elevations.Add(4, 10);

            Console.WriteLine($"The shortest path is {string.Join(",", DCP.ShortestDistance.GetPath(elevations, map))}");
            #endregion
        }
    }
}
