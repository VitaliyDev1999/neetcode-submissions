public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int maxW = 0;

        while(l < r) {

            var localMaxW = (r - l) * Math.Min(heights[l], heights[r]);
            maxW = Math.Max(maxW, localMaxW);

            if(heights[l] < heights[r]) {
                l++;
            }
            else{
                r--;
            }
        }

        return maxW;
    }
}
