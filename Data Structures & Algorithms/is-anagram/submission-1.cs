public class Solution {
    public bool IsAnagram(string s, string t) {
        
        int sL = s.Length;
        if (sL != t.Length) return false;
        
        Dictionary<char, int> hS = new Dictionary<char, int>();
        Dictionary<char, int> hT = new Dictionary<char, int>();
        
        for (int i = 0; i < sL; i++){
            if (!hS.ContainsKey(s[i])) hS[s[i]] = 0;
            if (!hT.ContainsKey(t[i])) hT[t[i]] = 0;

            hS[s[i]] += 1;
            hT[t[i]] += 1;
        }

        if (hS.Count == hT.Count && hS.All(kvp => hT.TryGetValue(kvp.Key, out var val) && Equals(kvp.Value, val))) return true;

        return false;
    }
}
