public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach(string str in strs) {
            int[] count = new int[26];

            foreach(char c in str){
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if(!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }

            dict[key].Add(str);
        }

        return dict.Values.ToList<List<string>>();
    }
}
