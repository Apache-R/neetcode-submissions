public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frecuency = new();
        foreach(int num in nums){
            if(!frecuency.ContainsKey(num)) frecuency[num] = 0;
            frecuency[num] += 1;
        }

        return frecuency.OrderByDescending(pair => pair.Value).Take(k).Select(pair => pair.Key).ToArray();
    }
}
