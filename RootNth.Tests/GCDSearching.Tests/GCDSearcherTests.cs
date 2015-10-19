using NUnit.Framework;
using GCDSearching;
using System;

namespace GCDSearching.Tests
{
    public class GCDSearcherTests
    {
        static object[] Cases =
{
            new object[] { 5,15,10,20,5},
            new object[] { 7,13,17,19,1},
            new object[] { 5,-15,10,-20,5},
            new object[] { -5,-15,-10,-20,5},
            new object[] { -5,-15,0,0,5},
        };


        [TestCase(5, 15, 5)]
        [TestCase(7, 15, 1)]
        [TestCase(-5, 15, 5)]
        [TestCase(-5, -15, 5)]
        [TestCase(0, 15, 15)]
        [TestCase(0, 0, 5, ExpectedException = typeof(ArgumentException))]
        public void GCDSearch_ForTwoArguments(int first, int second, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.FindGCD(first, second,out t) == result);
        }

        [TestCase(5, 15, 20, 5)]
        [TestCase(7, 15,17, 1)]
        [TestCase(-5, 15,20, 5)]
        [TestCase(-5, -15,-20, 5)]
        [TestCase(0, 15,7, 1)]
        [TestCase(0, 5, 0, 5)]
        [TestCase(0, 0,0, 5, ExpectedException = typeof(ArgumentException))]
        public void GCDSearch_ForThreeArguments(int first, int second, int third, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.FindGCD(first, second, third, out t) == result);
        }



        [Test, TestCaseSource(nameof(Cases))]
        [TestCase(0,0,0,0,0,ExpectedException = typeof (ArgumentException))]
        public void GCDSearch_ForFourArguments(int a, int b, int c, int d, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.FindGCD(out t,a,b,c,d) == result);

        }

        [TestCase(5, 15, 5)]
        [TestCase(7, 15, 1)]
        [TestCase(-5, 15, 5)]
        [TestCase(-5, -15, 5)]
        [TestCase(0, 15, 15)]
        [TestCase(0, 0, 5, ExpectedException = typeof(ArgumentException))]
        public void SteinAlgorithm_ForTwoArguments(int first, int second, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.SteinAlgorithm(first, second, out t) == result);
        }

        [TestCase(5, 15, 20, 5)]
        [TestCase(7, 15, 17, 1)]
        [TestCase(-5, 15, 20, 5)]
        [TestCase(-5, -15, -20, 5)]
        [TestCase(0, 15, 7, 1)]
        [TestCase(0, 5, 0, 5)]
        [TestCase(0, 0, 0, 5, ExpectedException = typeof(ArgumentException))]
        public void SteinAlgorithm_ForThreeArguments(int first, int second, int third, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.SteinAlgorithm(first, second, third, out t) == result);
        }

        [Test, TestCaseSource(nameof(Cases))]
        [TestCase(0, 0, 0, 0, 0, ExpectedException = typeof(ArgumentException))]
        public void SteinAlgorithm_ForFourArguments(int a, int b, int c, int d, int result)
        {
            long t;
            Assert.IsTrue(GCDSearcher.SteinAlgorithm(out t, a, b, c, d) == result);

        }
    }
}
