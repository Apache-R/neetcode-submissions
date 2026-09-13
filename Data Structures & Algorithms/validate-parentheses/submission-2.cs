public class Solution {
    public bool IsValid(string s) {
        if (s.Length < 2) return false;
        Stack<char> opened = new();

        foreach(char c in s){
            if("{[(".Contains(c)) opened.Push(c);
            else{
                if (opened.Count < 1) return false;

                switch(c){
                    case '}':
                        if(opened.Pop() != '{') return false;
                        break;
                    case ']':
                        if(opened.Pop() != '[') return false;
                        break;
                    case ')':
                        if(opened.Pop() != '(') return false;
                        break;
                }
            }
        }

        return opened.Count == 0;
    }
}
