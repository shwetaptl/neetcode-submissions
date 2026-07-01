public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length -1;
        int mid;

        while (left <= right)
        {
            mid = left + (right - left) /2;

            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[left] <= nums[mid])//left part sorted
            {
                if(nums[left] <= target && nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else // right part sorted
            {
                if(nums[right] >= target && nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}
