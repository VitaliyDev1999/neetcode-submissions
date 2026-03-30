public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while(i < j) {
            while (i < j && !char.IsLetterOrDigit(s[i])) {
                i++;
            }
            while (j > i && !char.IsLetterOrDigit(s[j])) {
                j--;
            }
                
            if (s[i].ToString().ToLower() != s[j].ToString().ToLower())
                return false;
            i++; j--;
        }
        return true;
    }
}
