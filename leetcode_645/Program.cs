using System;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        if (nums.Length == 0 || nums is null)
        {
            return new int[] { };
        }
        int dup = 0;
        int missing = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == i)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                dup = i;
            }
            if (count == 0)
            {
                missing = i;
            }
        }
        return new int[] { dup, missing };
    }

    public static void Main(string[] args)
    {
        int[] testCase = { 1, 2, 2, 4 };
        int[] nums = new Solution().FindErrorNums(testCase);
        foreach(int num in  nums)
        {
            Console.WriteLine(num);
        }
    }
}
