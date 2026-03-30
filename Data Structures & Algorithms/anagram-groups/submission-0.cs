public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if (dict.TryGetValue(sortedStr, out var list))
            {
                list.Add(str);
            }
            else
            {
                dict[sortedStr] = new List<string>() { str };
            }
        }

        return dict.OrderBy(x => x.Value.Count).Select(x => x.Value).ToList();
    }
}
