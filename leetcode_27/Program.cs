namespace leetcode_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int result = new Program().RemoveElement(nums, val);
            Console.WriteLine(result);
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int left = 0;

            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != val)
                {
                    nums[left] = nums[fast];
                    left++;
                }
            }
            return left;
        }
    }
}