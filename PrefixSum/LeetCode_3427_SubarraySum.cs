using System;

namespace LeetCodeSolutions
{
    /*
     * LeetCode 3427 – Sum of Variable Length Subarrays
     * 
     * You are given an integer array nums of size n. 
     * For each index i where 0 <= i < n, define a subarray nums[start ... i] 
     * where start = max(0, i - nums[i]).
     * 
     * Return the total sum of all elements from the subarray defined for each index in the array.
     * 
     * Example 1:
     * Input: nums = [2, 3, 1]
     * Output: 11
     * Explanation:
     * i = 0 → [2]       → sum = 2
     * i = 1 → [2, 3]    → sum = 5
     * i = 2 → [3, 1]    → sum = 4
     * Total = 2 + 5 + 4 = 11
     * 
     * Example 2:
     * Input: nums = [3, 1, 1, 2]
     * Output: 13
     * Explanation:
     * i = 0 → [3]           → sum = 3
     * i = 1 → [3, 1]        → sum = 4
     * i = 2 → [1, 1]        → sum = 2
     * i = 3 → [1, 1, 2]     → sum = 4
     * Total = 3 + 4 + 2 + 4 = 13
     * 
     * Constraints:
     * - 1 <= n == nums.length <= 100
     * - 1 <= nums[i] <= 1000
     */

    class Solution
    {
        public int SubarraySum(int[] nums)
        {
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int start = Math.Max(0, i - nums[i]);
                int subarraySum = 0;

                for (int j = start; j <= i; j++)
                {
                    subarraySum += nums[j];
                }

                total += subarraySum;
            }

            return total;
        }

        // Main method to test the solution
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            int[] nums1 = { 2, 3, 1 };
            Console.WriteLine("Input: [2, 3, 1] → Output: " + sol.SubarraySum(nums1)); // Expected: 11

            int[] nums2 = { 3, 1, 1, 2 };
            Console.WriteLine("Input: [3, 1, 1, 2] → Output: " + sol.SubarraySum(nums2)); // Expected: 13
        }
    }
}
