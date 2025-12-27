public class ReverseInteger{
    public int Reverse(int x) {
        long num=0;
        while(x!=0){
            int rem=x%10;
            num=num*10+rem;
            x=x/10;
        }
        if(num>int.MaxValue || num<int.MinValue){
            return 0;
        }
        return (int)num;
    }
}