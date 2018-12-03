using NUnit.Framework;

namespace Sleepsort.UnitTests.Tests
{
    [TestFixture]
    class SleepsortTests
    {
        [Test]
        public void SleepSort_TplSort_ReturnsSortedArray()
        {
            var sorter = new Sleepsort();

            var testData =       new[] { 1, 7, 6, 3, 5, 9, 0, 2, 4, 8 };
            var expectedResult = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = sorter.TplSort(testData);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void SleepSort_TplSort_ReturnsSortedArray1()
        {
            var sorter = new Sleepsort();

            var testData1 = new[] { 11, 71, 61, 31, 51, 91, 0, 21, 41, 81 };
            var expectedResult1 = new[] { 0, 11, 21, 31, 41, 51, 61, 71, 81, 91 };
            var result1 = sorter.TplSort(testData1);
            Assert.AreEqual(result1, expectedResult1);
        }

        [Test]
        public void SleepSort_TplSort_ReturnsSortedArray2()
        {
            var sorter = new Sleepsort();

            var testData2 = new[] { 23, 74, 16, 31, 51, 55, 14, 33, 42, 19 };
            var expectedResult2 = new[] { 14, 16, 19, 23, 31, 33, 42, 51, 55, 74 };
            var result2 = sorter.TplSort(testData2);
            Assert.AreEqual(result2, expectedResult2);
        }

        [Test]
        public void SleepSort_PlinqSort_ReturnsSortedArray()
        {
            var sorter = new Sleepsort();

            var testData = new[] { 1, 7, 6, 3, 5, 9, 0, 2, 4, 8 };
            var expectedResult = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = sorter.PlinqSort(testData);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void SleepSort_PlinqSort_ReturnsSortedArray1()
        {
            var sorter = new Sleepsort();

            var testData1 = new[] { 11, 71, 61, 31, 51, 91, 0, 21, 41, 81 };
            var expectedResult1 = new[] { 0, 11, 21, 31, 41, 51, 61, 71, 81, 91 };
            var result1 = sorter.PlinqSort(testData1);
            Assert.AreEqual(result1, expectedResult1);
        }

        [Test]
        public void SleepSort_PlinqSort_ReturnsSortedArray2()
        {
            var sorter = new Sleepsort();

            var testData2 = new[] { 23, 74, 16, 31, 51, 55, 14, 33, 42, 19 };
            var expectedResult2 = new[] { 14, 16, 19, 23, 31, 33, 42, 51, 55, 74 };
            var result2 = sorter.PlinqSort(testData2);
            Assert.AreEqual(result2, expectedResult2);
        }
    }
}
