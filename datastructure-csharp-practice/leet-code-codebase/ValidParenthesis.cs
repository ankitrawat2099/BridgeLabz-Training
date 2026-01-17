public class Solution {
    public bool IsValid(string s) {
        Stack<char> st=new Stack<char>();
        for(int i=0;i<s.Length;i++){
            char ch=s[i];
            if(ch=='(' || ch=='{' || ch=='['){
                st.Push(ch);
            }
            else{
                if(st.Count==0){
                    return false;
                }
                else if(ch==')' && st.Peek()=='(' || ch=='}' && st.Peek()=='{' || ch==']' && st.Peek()=='['){
                    st.Pop();
                }
                else{
                    return false;
                }
            }
            
            
            
        }
        if(st.Count==0){
            return true;
        }
        return false;
    }
}