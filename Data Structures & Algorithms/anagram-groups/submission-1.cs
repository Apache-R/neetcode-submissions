public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> dictStrs = new();


        foreach(string str in strs){
            // Sort string
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);
            
            // Find in hashmap
            if(!dictStrs.ContainsKey(sortedStr)) dictStrs[sortedStr] = new List<string>();
            dictStrs[sortedStr].Add(str);
        }

        // Format
        List<List<string>> res = new();
        foreach(var val in dictStrs.Values)
            res.Add(val);

        return res;
    }
}
