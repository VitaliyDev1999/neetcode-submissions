public class Solution {
    public bool ValidPalindrome(string s) {
        bool IsPalindrom(int l, int r) {
            while(l < r) {
                if(s[l] != s[r]) 
                    return false;
                l++;
                r--;          
            }
            return true;
        }
        
        
        int left = 0;
        int right = s.Length - 1;

        while(left < right) {
            if(s[left] != s[right]){
                return IsPalindrom(left+1,right) || IsPalindrom(left,right-1);
            }
            left++;
            right--;
        }

        return true;
    }
}