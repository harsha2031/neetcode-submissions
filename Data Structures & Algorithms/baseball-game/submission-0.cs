public class Solution {
    public int CalPoints(string[] operations) {
        int result = 0;
        Stack<int> stack = new Stack<int>();
        foreach(string s in operations){
            if(s == "+"){
                int top = stack.Pop();
                int sec = top + stack.Peek();
                stack.Push(top);
                stack.Push(sec);
            }
            else if(s == "D"){
                stack.Push(2 * stack.Peek());
            }
            else if(s == "C"){
                stack.Pop();
            }            
            else{
                stack.Push(int.Parse(s));
            }
        }
        foreach(var s in stack){
            result += s;
        }
        return result;
    }
}