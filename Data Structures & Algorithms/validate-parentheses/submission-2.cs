public class Solution {
    public bool IsValid(string s) {
        Stack<char> validParen = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
                validParen.Push(c);
            }
            else
            {
                if(validParen.Count == 0) return false;

                if((c == ')' && validParen.Peek() != '(') 
                    || (c == '}' && validParen.Peek() != '{') 
                    || (c == ']' && validParen.Peek() != '['))
                {
                    return false;
                }
                validParen.Pop(); 
            }
        }
        return validParen.Count == 0;
        
    }
}
