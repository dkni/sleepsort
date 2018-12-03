using NUnit.Framework;

namespace Sleepsort.UnitTests.Tests
{
    [TestFixture]
    class SleepsortTests
    {
        [Test]
        public void SleepSort_Sort_ReturnsSortedArray()
        {
            var testData =       new[] { 1, 7, 6, 3, 5, 9, 0, 2, 4, 8 };
            var expectedResult = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = new Sleepsort().Sort(testData);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
