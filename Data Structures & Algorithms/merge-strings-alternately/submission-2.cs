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

        if(word1.Length == word2.Length)
        {
            return sBuilder.ToString();
        }

        if (word1.Length < word2.Length)
        {
            sBuilder.Append(word2.AsSpan(minLength, word2.Length - i));
        }
        else if (word1.Length > word2.Length)
        {
            sBuilder.Append(word1.AsSpan(minLength, word1.Length - i));
        }

        return sBuilder.ToString();
    }
}