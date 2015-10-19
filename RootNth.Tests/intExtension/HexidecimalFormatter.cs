using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace intExtension
{
    public class HexidecimalFormatter : ICustomFormatter, IFormatProvider
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format.ToUpper() != "H" || !(arg is int))
                try
                {
                    return HandleOtherFormats(format, arg);
                }
                catch (FormatException e)
                {
                    throw new FormatException(String.Format("The format of '{0}' is invalid.", format), e);
                }

            int bufTarget = (int)arg;
            long target = bufTarget;

            string result = string.Empty;

            if (bufTarget < 0)
            {
                target = -target;
            }

            while (target >= 16)
            {
                result += GethexidecimalNumber((int)target%16);
                target = target / 16;
            }
            result += target;

            if (bufTarget < 0)
            {
                result += '-';
            }

            return String.Concat(result.Reverse());
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        private string HandleOtherFormats(string format, object arg)
        {
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, CultureInfo.CurrentCulture);
            else if (arg != null)
                return arg.ToString();
            else
                return String.Empty;
        }
        char GethexidecimalNumber(int number)
        {
            char res;
            switch (number)
            {
                case 10:
                    res = 'A';
                    break;
                case 11:
                    res = 'B';
                    break;
                case 12:
                    res = 'C';
                    break;
                case 13:
                    res = 'D';
                    break;
                case 14:
                    res = 'E';
                    break;
                case 15:
                    res = 'F';
                    break;
                default:
                    res = char.Parse(number.ToString());
                    break;
            }
            return res;
        }

    }
}
