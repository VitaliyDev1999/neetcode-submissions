public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if(int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();
                int res = 0;

                res += token switch
                {
                    "+" => num2 + num1,
                    "-" => num2 - num1,
                    "*" => num2 * num1,
                    "/" => num2 / num1,
                };

                stack.Push(res);
            }
        }

        return stack.Pop();
    }
}
