public class Solution {
    public bool IsPalindrome(string s) {
        char[] chars = s.ToLower().ToCharArray();
        int j = chars.Length - 1;

        for(int i = 0; i < j; i++){
            if(!char.IsLetterOrDigit(chars[i])){
                continue;
            }

            if(!char.IsLetterOrDigit(chars[j])){
                j--;
                i--;
                continue;
            }

            if (chars[i] != chars[j]) return false;
            j--;
        }

        return true;
    }
}
