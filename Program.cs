public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0) return 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
       
            if (nums[i] > target)
            {
                return i;
            }

            if (i == nums.Length - 1 && nums[i] < target)
            {
                return i + 1;
            }
        }
        return -1;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("2 -> " + s.SearchInsert([1, 3, 5, 6], 5));
        Console.WriteLine("1 -> " + s.SearchInsert([1, 3, 5, 6], 2));
        Console.WriteLine("4 -> " + s.SearchInsert([1, 3, 5, 6], 7));

    }

}
