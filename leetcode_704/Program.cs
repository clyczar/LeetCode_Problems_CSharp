public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 0 || nums is null)
        {
            return -1;
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;
        int resutle = new Solution().Search(nums, target);
        Console.WriteLine(resutle);
    }
}