public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        var list = new List<int>();
        int n = nums.Length;
        int limit = n / 3;

        foreach (int num in nums)
        {
           if (!dict.ContainsKey(num)) {
                dict[num] = 0;
            }
            dict[num]++;
        }

        foreach(var kvp in dict){
            if(kvp.Value > limit)
                list.Add(kvp.Key);
        }

        return list;
    }
}