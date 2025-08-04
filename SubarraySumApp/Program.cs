using System;

namespace LeetCodeSolutions
{
    /*
     * LeetCode 303 – Range Sum Query - Immutable
     * 
     * Given an integer array nums, handle multiple queries of the following type:
     * - Calculate the sum of the elements of nums between indices left and right inclusive.
     * 
     * Implement the NumArray class:
     * - NumArray(int[] nums) → Initializes the object with the integer array nums.
     * - int SumRange(int left, int right) → Returns the sum from index left to right inclusive.
     * 
     * Example:
     * Input:
     * ["NumArray", "sumRange", "sumRange", "sumRange"]
     * [[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
     * 
     * Output:
     * [null, 1, -1, -3]
     * 
     * Explanation:
     * NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
     * numArray.SumRange(0, 2); // returns 1
     * numArray.SumRange(2, 5); // returns -1
     * numArray.SumRange(0, 5); // returns -3
     * 
     * Constraints:
     * - 1 <= nums.Length <= 10^4
     * - -10^5 <= nums[i] <= 10^5
     * - 0 <= left <= right < nums.Length
     * - At most 10^4 calls will be made to SumRange.
     */

    public class NumArray
    {
        private int[] prefixSums;

        // Constructor: builds prefix sum array
        public NumArray(int[] nums)
        {
            prefixSums = new int[nums.Length];

            if (nums.Length == 0)
                return;

            prefixSums[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                prefixSums[i] = prefixSums[i - 1] + nums[i];
            }
        }

        // Returns sum from index left to right
        public int SumRange(int left, int right)
        {
            if (left == 0)
                return prefixSums[right];
            else
                return prefixSums[right] - prefixSums[left - 1];
        }
    }

    // Test Program
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            NumArray numArray = new NumArray(nums);

            Console.WriteLine("SumRange(0, 2): " + numArray.SumRange(0, 2)); // Output: 1
            Console.WriteLine("SumRange(2, 5): " + numArray.SumRange(2, 5)); // Output: -1
            Console.WriteLine("SumRange(0, 5): " + numArray.SumRange(0, 5)); // Output: -3
        }
    }
}
