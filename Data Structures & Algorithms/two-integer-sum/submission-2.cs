public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++) {
            var diff= target - nums[i];
            if(dict.TryGetValue(nums[i], out int j))
                return new int [] {j,i};
            
            dict[diff] = i;
        }

        return new int[0];
    }
}
