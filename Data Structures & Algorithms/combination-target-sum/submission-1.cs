public class Solution {

    List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int> cur = new List<int>();
        Backtrack(0, cur, 0, nums, target);
        return res;
    }

    void Backtrack(int i, List<int> cur, int total, int[] nums, int target){
        if(total == target) {
            res.Add(new List<int>(cur));
            return;
        }

        if(total > target || i >= nums.Length) return;

        cur.Add(nums[i]);

        Backtrack(i, cur, total + nums[i], nums, target);
        cur.Remove(cur.Last());

        Backtrack(i + 1, cur, total, nums, target);
    }
}
