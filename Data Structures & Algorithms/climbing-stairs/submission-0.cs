public class Solution {
    public int ClimbStairs(int n) {
        // <(Depth, Total), num ways>
        Dictionary<(int, int), int> dict = new();

        int back(int depth, int total){
            if(dict.ContainsKey((depth, total))) return dict[(depth, total)];
            
            if(total > n) return 0;
            if(total == n) return 1;

            dict[(depth, total)] = back(depth + 1, total + 1) + back(depth +1, total + 2);
            return dict[(depth, total)];
        }

        return back(0,0);
    }
}