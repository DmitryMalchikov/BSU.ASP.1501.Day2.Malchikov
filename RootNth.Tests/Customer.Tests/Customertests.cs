using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer;

namespace Customer.Tests
{
    public class CustomerTests
    {

        static Castomer c = new Castomer() { Name = "John", ContactPhone = "+375 33 465 774 34", Revenue = 10000 };


       
        [TestCase(c,"ncr",null, "Customer record: John, " )]
        public void ToStringTest(Castomer cast, string format, IFormatProvider formatProvider, string result)
        {

        }
    }
}
