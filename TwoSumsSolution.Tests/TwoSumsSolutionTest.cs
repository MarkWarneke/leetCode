using System;
using Xunit;
using TwoSumsSolution;

namespace TwoSumsSolution.Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var result = Solution.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        public void TwoSum_BruteForce_Test(int[] nums, int target, int[] expected)
        {
            var result = Solution.TwoSum_BruteForce(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
        public void TwoSum_HashTable_2_Test(int[] nums, int target, int[] expected)
        {
            var result = Solution.TwoSum_HashTable_2(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
