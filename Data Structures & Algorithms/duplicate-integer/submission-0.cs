public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> h = new  Dictionary<int, bool>();

        foreach(int a in nums)
        {
            if (h.ContainsKey(a)){
                return true;
            }

            h[a] = true;
        }

        return false;
    }
}