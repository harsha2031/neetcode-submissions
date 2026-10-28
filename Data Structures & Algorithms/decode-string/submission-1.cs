public class Solution {
    public string DecodeString(string s) {
        Stack<string> stack = new Stack<string>();
        for(int i = 0;i<s.Length;i++){
            if(s[i] != ']'){
                stack.Push(s[i].ToString());
            }
            else{
                string substr = "";
                while(stack.Peek() != "["){
                    substr = stack.Pop() + substr;
                }
                stack.Pop();
                string k = "";
                while(stack.Count > 0 && char.IsDigit(stack.Peek()[0])){
                    k = stack.Pop() + k;
                }
                int repeat = int.Parse(k);
                string expanded = new StringBuilder().Insert(0, substr, repeat).ToString();
                stack.Push(expanded);
            }
        }
        var result = new StringBuilder();
        foreach(string part in stack){
            result.Insert(0,part);
        }
        return result.ToString();
    }
}