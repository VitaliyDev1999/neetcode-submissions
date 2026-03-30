public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int minLength = Math.Min(word1.Length, word2.Length);
        int i = 0;
        var sBuilder = new StringBuilder();

        while (i < minLength)
        {
            sBuilder.Append(word1[i]);
            sBuilder.Append(word2[i]);
            i++;
        }

        if (word1.Length < word2.Length)
        {
            for(int j = minLength; j < word2.Length; j++) {
                sBuilder.Append(word2[j]);
            }
        }
        else if (word1.Length > word2.Length)
        {
            for(int j = minLength; j < word1.Length; j++) {
                sBuilder.Append(word1[j]);
            }
        }

        return sBuilder.ToString();
    }
}