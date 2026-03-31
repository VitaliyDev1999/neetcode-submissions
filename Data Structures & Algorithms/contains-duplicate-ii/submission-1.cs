public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        int l = 0;

        for(int r = 0; r < nums.Length; r++){
            if(r - l > k) {
                set.Remove(nums[l]);
                l++;
            }
                
            if(set.Contains(nums[r])){
                return true;
            }

            set.Add(nums[r]);
        }

        return false;
    }
}