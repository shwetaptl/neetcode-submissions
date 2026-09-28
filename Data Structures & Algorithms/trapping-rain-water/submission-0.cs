public class Solution {
    public int Trap(int[] height) {
        
        int maxLeft = 0;
        int maxRight = 0;
        int left = 0 ;
        int right = height.Length - 1;
        int water= 0 ;

        while(left < right)
        {
            maxLeft = Math.Max(maxLeft, height[left]);
            maxRight = Math.Max(maxRight, height[right]);

            if(maxLeft < maxRight)
            {
                water += maxLeft - height[left];
                left++;
            }
            else
            {
                water += maxRight - height[right];
                right--;
            }
        }
        return water;
        
    }
}
