public class Solution {
    public bool IsValid(string s) {
        Stack<char> so = new();
        Dictionary<char, char> dc = new Dictionary<char, char> {
            {'}', '{'},
            {']', '['},
            {')', '('}
        };

        foreach(char c in s){
            if(dc.ContainsValue(c)) so.Push(c);
            else {
                if(so.TryPeek(out char top)){
                    if(top != dc[c])
                        return false;

                    so.Pop();
                } else {
                    return false;
                }
            }
        }

        return so.Count == 0;
    }
}
