public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        bool res = false;
        int s1Length = s1.Length;
        string str;

        for(int i = 0; i < s2.Length; i++) {
            str = string.Empty;
            int j = i;
            while(j < s2.Length && j < i+s1Length){
                str+=s2[j];
                j++;
            }
            
            if (s1.OrderBy(x => x).SequenceEqual(str.OrderBy(x => x)))
                return true;
            
        }

        return res;
    }
}
