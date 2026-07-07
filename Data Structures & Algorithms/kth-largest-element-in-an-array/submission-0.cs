public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        for(int i = 0 ; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i],nums[i]);
            if(queue.Count > k)
            {   
                queue.Dequeue();
            }
        }//n log k 
        return queue.Peek();
        //space - O(k)
    }
}
