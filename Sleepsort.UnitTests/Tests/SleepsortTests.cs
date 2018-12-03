﻿using NUnit.Framework;

namespace Sleepsort.UnitTests.Tests
{
    [TestFixture]
    class SleepsortTests
    {
        private Sleepsort _sorter;

        private Sleepsort GetSorter()
        {
            if (this._sorter == null)
            {
                this._sorter = new Sleepsort();
            }
            return this._sorter;
        }

        [TestCase(new[] { 1, 7, 6, 3, 5, 9, 0, 2, 4, 8 }, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new[] { 11, 71, 61, 31, 51, 91, 0, 21, 41, 81 }, new[] { 0, 11, 21, 31, 41, 51, 61, 71, 81, 91 })]
        [TestCase(new[] { 23, 74, 16, 31, 51, 55, 14, 33, 42, 19 }, new[] { 14, 16, 19, 23, 31, 33, 42, 51, 55, 74 })]
        public void TplSort_VariousArrays_ReturnsSortedArray(int[] testData, int[] expectedResult)
        {
            var sorter = GetSorter();

            var result = sorter.TplSort(testData);

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(new[] { 1, 7, 6, 3, 5, 9, 0, 2, 4, 8 }, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new[] { 11, 71, 61, 31, 51, 91, 0, 21, 41, 81 }, new[] { 0, 11, 21, 31, 41, 51, 61, 71, 81, 91 })]
        [TestCase(new[] { 23, 74, 16, 31, 51, 55, 14, 33, 42, 19 }, new[] { 14, 16, 19, 23, 31, 33, 42, 51, 55, 74 })]
        public void PlinqSort_VariousArrays_ReturnsSortedArray(int[] testData, int[] expectedResult)
        {
            var sorter = GetSorter();

            var result = sorter.PlinqSort(testData);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
