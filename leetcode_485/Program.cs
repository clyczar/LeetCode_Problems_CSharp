using System;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int result = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                max += 1;
            }
            else
            {
                max = 0;
            }
            result = max > result ? max : result;

        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[] testcase = { 1, 1, 0, 1, 1, 1 };
        Console.WriteLine(new Solution().FindMaxConsecutiveOnes(testcase));
    }

}