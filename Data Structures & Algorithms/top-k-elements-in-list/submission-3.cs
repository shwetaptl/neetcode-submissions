public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int[] result = new int[k];
        for(int i=0; i<nums.Length; i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]=0;
            }
            dic[nums[i]]++;
        }
        
        List<int>[] bucket = new List<int>[nums.Length+1];
        foreach(var item in dic)
        {
            var num = item.Key;
            var count = item.Value;
            if(bucket[count]==null)
            {
                bucket[count] = new List<int>();
            }
            bucket[count].Add(num);
        }
        int idx=0;
        for(int i = nums.Length; i>=1 && idx<k; i--)
        {
            if(bucket[i] == null) continue;
            foreach(var item in bucket[i])
            {
                result[idx++] = item;
                if(idx >= k)
                {
                    break;
                }
            }
        }
        return result;
    }
}
//Complexity - Time O(n log n) space O(n)