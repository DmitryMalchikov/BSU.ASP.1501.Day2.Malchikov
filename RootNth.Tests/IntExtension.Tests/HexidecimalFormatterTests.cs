using intExtension;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExtension.Tests
{
    public class HexidecimalFormatterTests
    {
        [TestCase(16,"10")]
        [TestCase(-16,"-10")]
        [TestCase(0,"0")]
        [TestCase(int.MinValue,"-80000000")]
        [TestCase(int.MaxValue,"7FFFFFFF")]
        public void FormatterTest(int number, string result)
        {
            string res = String.Format(new HexidecimalFormatter(), "{0:H}",number);
            Assert.IsTrue(res.CompareTo(result) == 0);
        }
    }
}
