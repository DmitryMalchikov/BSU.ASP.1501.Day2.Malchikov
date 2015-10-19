using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RootNth;
using NUnit;
using NUnit.Framework;

namespace RootNth.Tests
{
    public class RootFinderTests
    {
        [TestCase(8,3,0.01, 2)]
        [TestCase(8,1,0.01,8)]
        [TestCase(0,3,0.01,0)]
        [TestCase(8,-3,0.01,0, ExpectedException = typeof(ArgumentException))]
        [TestCase(-8,3,0.01,0,ExpectedException = typeof(ArgumentException))]
        [TestCase(8,0,0.01,0,ExpectedException = typeof(ArgumentException))]
        public void FindRootTest(double number, int pow, double accuracy, double result)
        {
            var res = RootFinder.FindRoot(number, pow, accuracy);
               
            Assert.IsTrue(res >= result - accuracy && res <= result + accuracy);
        }

    }
}
