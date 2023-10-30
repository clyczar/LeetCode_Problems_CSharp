namespace leetcode_367
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().IsPerfectSquare(808201));
        }

        public bool IsPerfectSquare(int num)
        {
            if (num < 2)
            {
                return true;
            }

            long left = 2;
            long right = num / 2;

            while (left <= right)
            {
                long mid = (left + right) / 2;
                long temp = mid * mid;

                if (temp > num)
                {
                    right = mid - 1;
                }
                else if (temp < num)
                {
                    left = mid + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}