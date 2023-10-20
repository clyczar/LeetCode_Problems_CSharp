public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        if (nums.Length == 0 || nums is null)
        {
            return 0;
        }

        Array.Sort(nums);

        return Math.Max(nums[0] * nums[1] * nums[^1], nums[^1] * nums[^2] * nums[^3]);
    }

    public static void Main(string[] args)
    {
        int[] testCase = { 1, 2, 3, 4 };
        Console.WriteLine(new Solution().MaximumProduct(testCase));
    }
}