public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]=0;
            }
            dic[nums[i]]++;
        }
        PriorityQueue<int,int> heap = new  PriorityQueue<int,int>();
        int[] result = new int[k];
        foreach(var item in dic )
        {
            heap.Enqueue(item.Key,item.Value);
            if(heap.Count > k)
            {
                heap.Dequeue();
            }
        }
        for(int i =0 ; i<k ; i++)
        {
            result[i] = heap.Dequeue();;
        }
        return result;

    }
}
//Complexity - Time O(n log n) space O(n)