public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> dic = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            int j = -1;
            if (dic.TryGetValue(target - nums[i], out var index))
                j = index;

            if (j != -1) return [j, i];

            dic[nums[i]] = i;
        }

        return [0, 1];
    }
}
