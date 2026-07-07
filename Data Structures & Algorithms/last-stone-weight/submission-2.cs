public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> maxQueue = new PriorityQueue<int,int>();
        for(int i = 0 ; i < stones.Length; i++)
        {
            maxQueue.Enqueue(stones[i], -stones[i]);
        }// n log n
        while(maxQueue.Count > 1)
        {
            int x = maxQueue.Dequeue();//largest
            int y = maxQueue.Dequeue();

            if(x != y)
            {
                maxQueue.Enqueue(x-y, -(x-y));
            }
        }// n log n
        return maxQueue.Count == 0 ? 0 : maxQueue.Peek();
        //space O(n)
    }
}
