public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int res = right;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            long  hRequired = 0;

            foreach (int pile in piles) {
                hRequired += (int)Math.Ceiling((double)pile / mid); 
                if(hRequired > h){
                    break;
                }
            }

            if (hRequired <= h)
            {   
                res = mid;
                right = mid - 1;
                
            }
            else
            {
                left = mid + 1;
            }
        }
        return res;
    }
}
