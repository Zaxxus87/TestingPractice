using System;
using Xunit;

namespace Testing_Practice.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[]{1, 2, 3, 4}, 6)]
        [InlineData(new int[] {}, 0)]
        [InlineData(new int[] {1, 3, 5, 7}, 0)]
        [InlineData(new int[] {2, 4, 6, 8 }, 20)]
        [InlineData(new int[] {-2, 2, 3, 5 }, 0)]
        [InlineData(new int[] {-1, 1, 2, 4 }, 6)]

        public void Test1(int[] nums, int expected)
        {
            //arrange
            var tester = new ArrayFun(nums);
            //act
            var actual = tester.SumEvens();
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 10)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 16)]
        [InlineData(new int[] { 2, 4, 6, 8 }, 20)]
        [InlineData(new int[] { -2, 2, 3, 5 }, 10)]
        [InlineData(new int[] { -1, 1, 2, 4 }, 7)]
        [InlineData(new int[] { -1, -1, -2, -4 }, 0)]

        public void SumPositive(int[] nums, int expected)
        {
            var tester = new ArrayFun(nums);

            var actual = tester.SumPositive();

            Assert.Equal(expected, actual);
        }

    }
}
