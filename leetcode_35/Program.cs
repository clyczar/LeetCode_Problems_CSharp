public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0 || nums is null)
        {
            return 0;
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 3, 5, 6 };
        int target = 2;
        int result = solution.SearchInsert(nums, target);
        Console.WriteLine(result);
    }
}