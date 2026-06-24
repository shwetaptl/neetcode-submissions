public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        int n = nums.Length;
        int k = 0;
        int i = 1;
        int j= n -1;

        while (k < n-2)
        {
            while (k != 0 && k < n-2 && nums[k-1] == nums[k])
            {
                k++;
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
                    while(i<j && nums[i] == nums[i-1])
                    {
                        i++;
                        continue;
                    }
                    j--;
                    while(i<j && nums[j] == nums[j+1])
                    {
                        j--;
                        continue;
                    }
                }
                else if(sum > 0)
                {
                    j--;
                    while(i<j && nums[j] == nums[j+1])
                    {
                        j--;
                        continue;
                    }
                }
                else
                {
                    i++;
                    while(i<j && nums[i] == nums[i-1])
                    {
                        i++;
                        continue;
                    }
                }
            }
            k++;
        }
        return result;
    }
}
