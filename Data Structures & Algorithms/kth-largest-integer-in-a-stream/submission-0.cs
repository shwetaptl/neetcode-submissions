public class KthLargest {

    int k;
    int[] nums;
    PriorityQueue<int,int> queue = new PriorityQueue<int,int>();

    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.nums = nums;

        for(int i = 0 ; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i],nums[i]);
            if(queue.Count > k)
            {   
                queue.Dequeue();
            }
        }
    }//nlogn
    
    public int Add(int val) {
        queue.Enqueue(val,val);
        if(queue.Count > k)
        {   
            queue.Dequeue();
        }
        return queue.Peek();
    }//logn
}
