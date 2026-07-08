public class MinStack {

    Stack<int> stack;
    Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || minStack.Peek() >= val)
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        int val = stack.Pop();
        if(minStack.Count != 0 && minStack.Peek() == val)
        {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();      
    }
    
    public int GetMin() {
        
        return minStack.Peek();
        
    }
}
