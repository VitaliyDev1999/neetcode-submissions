public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int maxLength = Math.Max(word1.Length, word2.Length);

        var sBuilder = new StringBuilder();

        for(int i = 0; i < maxLength;i++) {
            if(i < word1.Length)
                sBuilder.Append(word1[i].ToString());
            
            if(i < word2.Length)
                sBuilder.Append(word2[i].ToString());
        }

        return sBuilder.ToString();
    }
}