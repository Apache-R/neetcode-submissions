public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int i = 0;
        int j = 1;

        int minp = prices[i];
        int maxp = 0;

        while (j < prices.Length){
            if(prices [j] < prices[i]){
                i = j;
                j++;
                continue;
            }

            if(prices[j] - prices[i] > profit)
            profit = prices[j] - prices[i];
            
            j++;
        }

        return profit;
    }
}
