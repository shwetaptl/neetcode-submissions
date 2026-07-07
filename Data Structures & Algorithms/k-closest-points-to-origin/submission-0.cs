public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int rows = points.Length;
        int[][] result = new int[k][];
        PriorityQueue<int,double> minQueue = new PriorityQueue<int,double>();
        for(int i = 0 ; i < rows ; i++)
        {
            int x = points[i][0];
            int y = points[i][1];
            double dis = Math.Sqrt((x) * (x) + (y) * (y));
            
            minQueue.Enqueue(i, -dis);
            if(minQueue.Count > k)
            {
                minQueue.Dequeue();
            }
        }// n log k
        for(int i=0 ; i  < k ; i++)
        {
            int j = minQueue.Dequeue();
            result[i] = new int[]{ points[j][0],  points[j][1] };
        }// k
        return result;
        //O(k)
    }
}
