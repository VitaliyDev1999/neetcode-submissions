public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0)
            return 0;

        int res = 0;
        int l = 0;
        int r = n -1;
        int lMax = height[l];
        int rMax = height[r];

        while(l < r) {
            if(lMax < rMax) {
                l++;
                lMax = Math.Max(lMax,height[l]);
                res += lMax - height[l];
               
            }
            else {
                r--;
                rMax = Math.Max(rMax, height[r]);
                res += rMax - height[r];
            }
        }

        return res;
    }
}
