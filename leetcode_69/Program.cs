using System;

namespace leetcode_69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().MySqrtSolution1(2147395599));
        }


        public int MySqrtSolution1(int x)
        {

            long a = x;
            Console.WriteLine(a);
            while (a * a > x)
            {
                a = (a + x / a) / 2;
            }

            return (int)a;
        }
        public int MySqrtSolution2(int x)
        {

            if (x < 2)
            {
                return x;
            }

            int left = 2;
            int mid = 2;
            long temp = 2;
            int right = x / 2;

            while (left <= right)
            {
                mid = left + (right - left) / 2;
                temp = (long)mid * mid;
                if (temp > x)
                {
                    right = mid - 1;
                }
                else if (temp < x)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }

            }
            return right;
        }



    }
}
