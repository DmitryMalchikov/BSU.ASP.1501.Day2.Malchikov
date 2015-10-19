using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDSearching
{
    public class GCDSearcher
    {
        public static int FindGCD(int first, int second, out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            if (first == 0 && second == 0) throw new ArgumentException();

            if (first == 0) return second;
            if (second == 0) return first;

            if (first == second) return first;

            first = Math.Abs(first);
            second = Math.Abs(second);



            while (first != 0 && second != 0)
            {
                if (first > second)
                    first %= second;
                else
                    second %= first;
            }

            sw.Stop();

            time = sw.ElapsedTicks;

            return first + second;

        }

        public static int FindGCD(int first, int second, int third, out long time)
        {
            time = 0;
            long bufTime;
            int result = FindGCD(first, second, out bufTime);

            time += bufTime;

            result = FindGCD(result, third, out bufTime);

            time += bufTime;

            return result;
        }

        public static int FindGCD(out long time, params int[] numbers)
        {
            time = 0;
            long bufTime;
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = FindGCD(result, numbers[i], out bufTime);
                time += bufTime;
            }

            return result;
        }

        public static int SteinAlgorithm(int first, int second, out long time)
        {
            time = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            if (first == 0 && second == 0) throw new ArgumentException();

            if (first == 0) return second;
            if (second == 0) return first;

            if (first == second) return first;

            first = Math.Abs(first);
            second = Math.Abs(second);

            if (first == 1 || second == 1)
            {
                sw.Stop();
                time = sw.ElapsedTicks;

                return 1;
            }

            if (first % 2 == 0 && second % 2 == 0)
                return 2 * SteinAlgorithm(first / 2, second / 2, out time);

            if (first % 2 == 0)
                return SteinAlgorithm(first / 2, second, out time);

            if (second % 2 == 0)
                return SteinAlgorithm(first, second / 2, out time);

            if (first > second)
                return SteinAlgorithm((first - second) / 2, second, out time);
            if (second > first)
                return SteinAlgorithm(first, (second - first) / 2, out time);
            return 0;
        }

        public static int SteinAlgorithm(int first, int second, int third, out long time)
        {
            time = 0;
            long bufTime;
            int result = SteinAlgorithm(first, second, out bufTime);

            time += bufTime;

            result = SteinAlgorithm(result, third, out bufTime);

            time += bufTime;

            return result;
        }

        public static int SteinAlgorithm(out long time, params int[] numbers)
        {
            time = 0;
            long bufTime;
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = SteinAlgorithm(result, numbers[i], out bufTime);
                time += bufTime;
            }

            return result;
        }

    }
}
