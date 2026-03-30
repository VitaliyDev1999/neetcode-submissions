public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int r = s.Length - 1;

        while(l < r) {
            char charL = s[l];
            char charR = s[r];

            s[l] = charR;
            s[r] = charL;

            l++;
            r--;
        }
    }
}