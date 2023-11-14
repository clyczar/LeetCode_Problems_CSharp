namespace leet_code_209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            int target = 7;
            int result = new Program().MinSubArrayLen(target, nums);
            Console.WriteLine(result);
        }

        public int MinSubArrayLen(int target, int[] nums)
        {
            int sum = 0, i = 0, subL = 0, result = nums.Length + 1;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += nums[j];
                while (sum >= target)
                {
                    sum -= nums[i];
                    subL = j - i + 1;
                    result = result < subL ? result : subL;
                    i++;
                }
            }
            return result == nums.Length + 1 ? 0 : result;
        }
    }
}