public class Solution {
    public int MaxProfit(int[] prices) {

        int maxProfit = 0 ;
        int buyPrice = prices[0];
        int i = 1;

        while (i < prices.Length)
        {
            if(prices[i] <= buyPrice)
            {
                buyPrice = prices[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
            }
            i++;
        }
        
        return maxProfit;
    }
}
