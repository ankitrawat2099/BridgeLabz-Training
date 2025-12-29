public class Solution {
    public bool IsPalindrome(int x) {
         if(x<0){
            return false;
        }
        int rev=0;
        int xtemp=x;
        while(x!=0){
            int temp=x%10;
            x=x/10;
             rev=rev*10+temp;
        }
        if(xtemp==rev){
            return true;
        }
        return false;
    }

}