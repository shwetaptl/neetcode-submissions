public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maxCount = 0 ; 
        for(int i=0; i<nums.Length; i++)
        {
            if(set.Contains(nums[i] - 1)) continue;
            else
            {
                int currNo = nums[i];
                int count = 0;
                while(set.Contains(currNo))
                {
                    count++;
                    currNo++;
                }
                maxCount = Math.Max(maxCount, count);
            }
        }
        return maxCount;
    }
}
