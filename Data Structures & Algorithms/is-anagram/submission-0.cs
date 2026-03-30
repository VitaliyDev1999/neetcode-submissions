public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var orderedS = s.OrderByDescending(c => c).ToArray();
        var orderedT = t.OrderByDescending(c => c).ToArray();

        for(int i = 0; i < s.Length; i++) {

            if(orderedS[i] != orderedT[i])
                return false;
        }

        return true;
    }
}
