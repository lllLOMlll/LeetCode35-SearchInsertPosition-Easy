public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        
        // Version 20
        return 0;
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("2 -> " + s.SearchInsert([1, 3, 5, 6], 5));
        Console.WriteLine("1 -> " + s.SearchInsert([1, 3, 5, 6], 2));
        Console.WriteLine("7 -> " + s.SearchInsert([1, 3, 5, 6], 7));

    }

}
