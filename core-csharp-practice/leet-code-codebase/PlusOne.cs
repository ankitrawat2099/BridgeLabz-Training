public class Solution {
    public int[] PlusOne(int[] digits) {
        int n=digits.Length;
        for(int i=n-1;i>=0;i--){
            if(digits[i]<9){
                digits[i]=digits[i]+1;
                return digits;
            }
            digits[i]=0;
        }
        int[] newArray=new int[n+1];
        newArray[0]=1;
        return newArray;
    }
}