public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        int n = nums.Length;
        int i = 1;
        int j= n -1;

        for (int k = 0; k < nums.Length - 2; k++)
        {
            if (k > 0 && nums[k] == nums[k - 1])
            {
                continue;
            }
            i = k+1;
            j = n-1;

            while (i<j)
            {
                int sum = nums[k]+nums[i]+nums[j];
                if(sum == 0)
                {
                    List<int> triplets = new List<int>(){nums[k],nums[i],nums[j]};
                    result.Add(triplets);
                    i++;
                    j--;
                    while(i<j && nums[i] == nums[i-1])
                    {
                        i++;
                    }
                    while(i<j && nums[j] == nums[j+1])
                    {
                        j--;
                    }
                }
                else if(sum > 0)
                {
                    j--;
                    while(i<j && nums[j] == nums[j+1])
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                    while(i<j && nums[i] == nums[i-1])
                    {
                        i++;
                    }
                }
            }
        }
        return result;
    }
}
