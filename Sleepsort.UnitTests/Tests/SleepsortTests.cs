using NUnit.Framework;

namespace Sleepsort.UnitTests.Tests
{
    [TestFixture]
    class SleepsortTests
    {
        private static Sleepsort MakeSorter()
        {
            return new Sleepsort();
        }

        [TestCase(new[] { 1, 7, 6, 3, 5, 2, 4, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new[] { 11, 71, 61, 31, 51, 21, 41, 81 }, new[] { 11, 21, 31, 41, 51, 61, 71, 81 })]
        [TestCase(new[] { 23, 16, 31, 51, 55, 14, 33, 19 }, new[] { 14, 16, 19, 23, 31, 33, 51, 55 })]
        public void TplSort_RandomArrayPassed_ReturnsSameArraySorted(int[] testData, int[] expectedResult)
        {
            var sorter = MakeSorter();

            var result = sorter.TplSort(testData);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(new[] { 1, 7, 6, 3, 5, 2, 4, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new[] { 11, 71, 61, 31, 51, 21, 41, 81 }, new[] { 11, 21, 31, 41, 51, 61, 71, 81 })]
        [TestCase(new[] { 23, 16, 31, 51, 55, 14, 33, 19 }, new[] { 14, 16, 19, 23, 31, 33, 51, 55 })]
        public void PlinqSort_RandomArrayPassed_ReturnsSameArraySorted(int[] testData, int[] expectedResult)
        {
            var sorter = MakeSorter();

            var result = sorter.PlinqSort(testData);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(new[] { 1, 7, 6, 3, 5, 2, 4, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new[] { 11, 71, 61, 31, 51, 21, 41, 81 }, new[] { 11, 21, 31, 41, 51, 61, 71, 81 })]
        [TestCase(new[] { 23, 16, 31, 51, 55, 14, 33, 19 }, new[] { 14, 16, 19, 23, 31, 33, 51, 55 })]
        public void TaskSort_RandomArrayPassed_ReturnsSameArraySorted(int[] testData, int[] expectedResult)
        {
            var sorter = MakeSorter();

            var result = sorter.TaskSort(testData);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
