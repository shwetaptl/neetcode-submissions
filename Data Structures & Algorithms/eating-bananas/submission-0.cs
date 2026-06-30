public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1 ;
        int right = piles.Max();
        int k = right; 

        while (left < right)
        {
            int mid = left + (right - left )/2;
            int hours = TimeToEatBananas(piles, mid);
            if(hours <= h)
            {
                k = Math.Min(k, mid);
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return k;

    }

    private int TimeToEatBananas(int[] piles, int k)
    {
        int hours=0;
        for(int i=0; i < piles.Length; i++)
        {
            hours = hours + piles[i]/k;
            if(piles[i]%k != 0) hours++;
        }
        return hours;
    }
}
