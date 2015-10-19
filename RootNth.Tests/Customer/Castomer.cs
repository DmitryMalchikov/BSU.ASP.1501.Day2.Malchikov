using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Castomer : IFormattable
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            string result = "Customer record: ";

            if (format.Contains("n"))
                result += Name.ToString(formatProvider);
            if (format.Contains("c"))
                result += ", " + ContactPhone.ToString(formatProvider);
            if (format.Contains("r"))
                result += ", " + Revenue.ToString(formatProvider);

            return result;
        }
    }
}
