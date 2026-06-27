public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();
        int a;
        int b;
        foreach(string s in tokens)
        {
            if(s == "+" || s == "-" || s == "*" || s == "/")
            {
                 b = int.Parse(stack.Pop());
                 a = int.Parse(stack.Pop());

                switch(s)
                {
                    case "+" :
                    stack.Push((a+b).ToString());
                    break;
                    case "-" :
                    stack.Push((a-b).ToString());
                    break;
                    case "*" :
                    stack.Push((a*b).ToString());
                    break;
                    case "/" :
                    stack.Push((a/b).ToString());
                    break;
                }                
            }
            else
            {
                stack.Push(s);
            }
        }
        return int.Parse(stack.Pop());
    }
}
