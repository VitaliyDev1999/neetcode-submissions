public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var subset = new List<int>();
        Backtracking(0, nums, subset, result);
        return result;
    }

    void Backtracking(int i, int[] nums, List<int> subset, List<List<int>> result){
        if(i >= nums.Length) {
            result.Add(new List<int>(subset));
            return;
        }
            
        subset.Add(nums[i]);
        Backtracking(i + 1, nums, subset, result);

        subset.RemoveAt(subset.Count - 1);
        Backtracking(i + 1, nums, subset, result);
    }
}
