public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for(int i = 1; i < prices.Length; i++) {
            if(prices[i-1] < prices[i])
                maxProfit+= prices[i]-prices[i-1];
        }
        return maxProfit;
    }
}