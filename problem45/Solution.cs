public class Solution
{
    public int Jump(int[] nums)
    {
        if(nums.Length < 2)
            return 0;
        
        int jumps = 0;
        int currentEnd = 0;
        int furthest = 0;

        // walk through the array, keep tracking of the greater 

        for(int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(furthest, i + nums[i]);

            if(i >= currentEnd)
            {
                jumps++;
                currentEnd = furthest;
                if(currentEnd >= nums.Length -1) break;
            }

        }

        return jumps;
        
    }
}