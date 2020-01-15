using System;

namespace challenges.LeetCode {
    public static class LongestIncreasingSubsequence {
        public static int LengthOfLIS(int[] nums) {
            if (nums.Length == 0)
                return 0;
            int longest = 1;
            int[] result = new int[nums.Length];
            result[0] = 1;
            for (int i = 1; i < nums.Length; i++) {
                int result_at_i = 0;
                for (int j = 0; j < i; j++) {
                    if (nums[i] > nums[j]) {
                        result_at_i = Math.Max(result_at_i, result[j]);
                    }
                }
                result[i] = result_at_i + 1;
                longest = Math.Max(longest, result[i]);
            }
            return longest;
        }
    }
}
