public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];

        foreach (int num in nums)
        {
            count[num] = count.GetValueOrDefault(num) + 1;
        }

        foreach (var keyValue in count)
        {
            var freqList = freq[keyValue.Value];
            if(freqList == null)
            {
                freqList = new List<int>();
                freq[keyValue.Value] = freqList;
            }
            freq[keyValue.Value].Add(keyValue.Key);
        }

        var result = new List<int>(k);

        for (int i = freq.Length - 1; i >= 0 && k > 0; i--)
        {   
            if(freq[i] != null)
            {
                foreach (int num in freq[i])
                {                   
                    if(result.Count() == k)
                    {
                        break;
                    }
                    result.Add(num);
                }
            }
        }

        return result.ToArray();
    }
}
