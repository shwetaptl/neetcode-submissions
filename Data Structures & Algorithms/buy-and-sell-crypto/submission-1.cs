public class Solution {
    public int MaxProfit(int[] prices) {

        int minPrice = int.MaxValue;
        int best = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
                minPrice = price;                       // new cheapest buy day
            else
                best = Math.Max(best, price - minPrice); // sell today?
        }
        return best;
    }
}
