public class Solution {

    public string Encode(IList<string> strs) {
        if (!strs.Any())
            return string.Empty;

        var sb = new StringBuilder();

        foreach (string str in strs)
        {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        if (s.Length < 1)
            return result;

        int i = 0;
        while (i < s.Length) { 
            int j = i;

            while (s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, length);
            result.Add(str);
            i = j + 1 + length;

        }

        return result;
   }
}
