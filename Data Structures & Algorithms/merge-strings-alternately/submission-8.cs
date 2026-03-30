public class Solution {
    public string MergeAlternately(string word1, string word2) {
        if(string.IsNullOrEmpty(word1))
        {
            return word2;
        }

        if(string.IsNullOrEmpty(word2))
        {
            return word1;
        }
        int n = word1.Length, m = word2.Length;
        string result = string.Empty;
        for(int i = 0; i < Math.Max(n,m); i++)
        {
            if(i < n)
            {
                result += word1[i];
            }
            if(i < m)
            {
                result += word2[i];
            }
        }
        
        return result;
    }
}