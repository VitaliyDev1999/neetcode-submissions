public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>() {
            {')','('},
            {'}','{'},
            {']','['}
        };

        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Any() && dict[s[i]] != stack.Peek())
                {
                    return false;
                }
                else if (!stack.Any())
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            } 
            
        }

        return !stack.Any();
    }
}
