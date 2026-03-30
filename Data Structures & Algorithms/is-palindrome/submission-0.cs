public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while(i <= j) {
            if(!char.IsLetterOrDigit(s[i])) {
                i++;
                continue;
            }
                
            if(!char.IsLetterOrDigit(s[j])) {
                j--;
                continue;
            }
                
            if (!(s[i].ToString().ToLower() == s[j].ToString().ToLower()))
                return false;
            i++;
            j--;
        }

        return true;
    }
}
