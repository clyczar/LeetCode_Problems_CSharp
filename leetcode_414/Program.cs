using System;

public class Solution
{
    public int ThirdMax(int[] nums)
    {
        if (nums.Length == 0 || nums is null)
        {
            return 0;
        }

        int result = 0;
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        Array.Reverse(nums);
        return (nums.Length >= 3) ? nums[2] : nums[0];
    }

    public static void Main(string[] args)
    {
        int[] testCase = { 2, 2, 3, 1 };
        Console.WriteLine(new Solution().ThirdMax(testCase));
    }
}