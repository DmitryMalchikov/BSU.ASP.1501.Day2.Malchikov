using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDSearching
{
    public class GSDSearcher
    {
        public static int FindGCD(int first, int second)
        {
            if (first == 0 && second == 0) throw new ArgumentException();

            if (first == 0) return second;
            if (second == 0) return first;

            first = Math.Abs(first);
            second = Math.Abs(second);

            if (first == second) return first;
            while (first != 0 && second != 0)
            {
                if (first > second)
                    first %= second;
                else 
                    second %= first;
            }

            return first + second;

        }

        public static int FindGCD(int first, int second, int third)
        {
            int result = FindGCD(first, second);
            result = FindGCD(result, third);

            return result;
        }

        public static int FindGCD(params int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = FindGCD(result, numbers[i]);
            }

            return result;
        }

    }
}
