using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return (int) a;
        }
        public int MySqrtSolution2(int x)
        {

            long a = x;
            Console.WriteLine(a);
            while (a * a > x)
            {
                a = (a + x / a) / 2;
            }

            return (int)a;
        }



    }
}
