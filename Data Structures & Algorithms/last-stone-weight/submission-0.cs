public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxQueue = new PriorityQueue<int,int>();
        for(int i = 0 ; i < stones.Length; i++)
        {
            maxQueue.Enqueue(stones[i], -stones[i]);
        }// n log n
        while(maxQueue.Count > 1)
        {
            int x = maxQueue.Dequeue();
            int y = maxQueue.Dequeue();

            if(x != y)
            {
                int result = Math.Abs(x-y);
                maxQueue.Enqueue(result, -result);
            }
        }// n log n
        if(maxQueue.Count == 0) return 0;
        else  return  maxQueue.Peek();
        //space O(n)
    }
}
