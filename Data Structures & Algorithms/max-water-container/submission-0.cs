public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0; 
        int i = 0;
        int j = heights.Length -1;

        while (i < j)
        {
            if (heights[i] < heights[j])
            {
                maxWater = Math.Max(maxWater,(heights[i] * (j-i)));
                i++;
            }
            else if (heights[i] > heights[j])
            {
                maxWater = Math.Max(maxWater,(heights[j] * (j-i)));
                j--;
            }
            else
            {
                maxWater = Math.Max(maxWater, (heights[i] * (j-i)));
                i++;
                j--;
            }
        }
        return maxWater;
    }
}
