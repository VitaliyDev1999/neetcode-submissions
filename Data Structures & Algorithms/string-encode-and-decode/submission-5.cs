public class Solution {

    public string Encode(IList<string> strs) {
        if(!strs.Any())
            return string.Empty;
        
        var sb = new StringBuilder();

        foreach(string str in strs) {
            sb.Append("Й");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length < 1)
            return new List<string>();

        return s.Split('Й').Skip(1).ToList();
   }
}
