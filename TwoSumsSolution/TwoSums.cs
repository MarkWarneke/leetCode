using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSumsSolution
{
    public class Solution
    {

        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// Example:
        /// ```
        /// Given nums = [2, 7, 11, 15], target = 9,
        /// Because nums[0] + nums[1] = 2 + 7 = 9,
        /// return [0, 1].
        /// ```
        /// </summary>
        /// <param name="nums">[2, 7, 11, 15]</param>
        /// <param name="target">9</param>
        /// <returns>[0, 1]</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int y = i + 1; y < nums.Length; y++)
                {
                    var sum = nums[i] + nums[y];
                    if (sum == target)
                    {
                        return new int[] { i, y };
                    }
                }
            }

            throw new Exception("No two sum solution");
        }


        /// <summary>
        /// Brute Force
        /// The brute force approach is simple. 
        /// Loop through each element xx and find if there is another value that equals to target - xtarget−x.
        /// Time complexity O(n)^2
        /// Space complexity O(1)
        /// </summary>
        public static int[] TwoSum_BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }

        /// <summary>
        /// Hashmap
        /// mapping of each element in the array to its index
        /// Loop through each element xx and find whether a complementary is stored
        /// Time complexity O(n)
        /// Space complexity O(n)
        /// </summary>
        public static int[] TwoSum_HashTable_2(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // Store the position of element in map to look up by value
                // use = as assignment
                // Add wil throw ArgumentException if value already been assigned
                map[nums[i]] = i;
                // Optimization: adding value to the map only after the tryGetValue
                // so we only need to iterate through nums 1 time
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // Calculated which complement would be needed
                int complement = target - nums[i];

                // Use TryGetValue instead of using [] directly, 
                // otherwise a KeyNotFoundException could be thrown
                int a;
                if (map.TryGetValue(complement, out a))
                {
                    return new int[] { i, a };
                }
            }

            throw new Exception("No two sum solution");
        }
    }
}
