public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        while(l < r) {
            if(s[l] != s[r]){
                string skipL = s.Substring(l + 1, r - l);
                string skipR = s.Substring(l, r - l);
                return IsPalindrome(skipL) || IsPalindrome(skipR);
            }
                
            l++;
            r--;
        }

        return true;
    }

    private bool IsPalindrome(string str) {
        int left = 0, right = str.Length - 1;
        while (left < right) {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}