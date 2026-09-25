public class Solution {
    public bool CanJump(int[] nums) {
        int maxReach = 0;
        for(int i = 0;i < nums.Length;i++) {
            if(i > maxReach)
                return false;
            if(i + nums[i] > maxReach)
                maxReach = i + nums[i];
            if (maxReach >= nums.Length - 1) {
                return true;
            }
        }
        return true;
    }
}
