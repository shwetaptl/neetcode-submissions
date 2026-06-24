public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int left = 1 ;
        int right = 1;

        int[] result = new int[nums.Length];
        result[0] = left;

        for(int i = 1 ; i < nums.Length; i++)
        {
            result[i]= nums[i-1] * left;
            left = result[i];
        }
        for(int i = nums.Length-1 ; i >= 0 ; i--)
        {
            result[i] = result[i] * right;
            right = right * nums[i];
        }

        return result;
    }
}
