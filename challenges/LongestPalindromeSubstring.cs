using System;
/*
    Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

    Example 1:

    Input: "babad"
    Output: "bab"
    Note: "aba" is also a valid answer.

    Example 2:

    Input: "cbbd"
    Output: "bb"
*/
namespace challenges.LeetCode {
    public static class LongestPalindromeSubstring {
        public static string LongestPalindrome(string s) {
            if (string.IsNullOrEmpty(s))
                return "";
            if (s.Length == 1)
                return s;
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++) {
                int len1 = expandFromMiddle(s, i, i);
                int len2 = expandFromMiddle(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start) {
                    start = i - ((len - 1)/2);
                    end = i + (len/2);
                }
            }
            
            return s.Substring(start, end - start + 1);
        }
        private static int expandFromMiddle(string s, int left, int right) {
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                left--; right++;
            }
            return right - left - 1;
        }
    }
}
