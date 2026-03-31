public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        int n = nums.Length;
        int limit = n / 3;

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        return dict.Where(kvp => kvp.Value > limit).Select(kvp => kvp.Key).ToList();
    }
}