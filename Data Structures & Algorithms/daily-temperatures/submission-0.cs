public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] result = new int[temperatures.Length];
        for(int i=0; i<temperatures.Length; i++)
        {
            while(stack.Count() != 0 && temperatures[i] > temperatures[stack.Peek()])
            {             
                result[stack.Peek()] = i - stack.Peek();
                stack.Pop();     
            }
            stack.Push(i);
        }
        while(stack.Count() != 0)
        {
            result[stack.Peek()] = 0;
            stack.Pop(); 
        }
        return result;
    }
}
