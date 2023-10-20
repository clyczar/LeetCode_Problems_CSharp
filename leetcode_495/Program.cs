using System;

public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (timeSeries.Length == 0)
        {
            return 0;
        }

        int result = 0;
        for (int i = 0; i < (timeSeries.Length - 1); i++)
        {
            if (timeSeries[i + 1] - timeSeries[i] >= duration)
            {
                result += duration;
            }
            else
            {
                result += timeSeries[i + 1] - timeSeries[i];
            }
        }

        result += duration;

        return result;
    }

    public static void Main(string[] args)
    {
        int[] timeSeries = {1,4 };
        int duration = 2;  
        Console.WriteLine(new Solution().FindPoisonedDuration(timeSeries, duration));
    }

}