namespace leetcode_977
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -4, -1, 0, 3, 10 };
            int[] answer = new int[nums.Length];
            answer = new Program().SortedSquares(nums);
            Console.WriteLine(String.Join(" ", answer));
        }

        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];

            int i = 0;
            int j = nums.Length - 1;
            int k = nums.Length - 1;

            while (i <= j)
            {
                if (nums[i] * nums[i] >= nums[j] * nums[j])
                {
                    result[k] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    result[k] = nums[j] * nums[j];
                    j--;
                }
                k--;
            }

            return result;
        }
    }
}