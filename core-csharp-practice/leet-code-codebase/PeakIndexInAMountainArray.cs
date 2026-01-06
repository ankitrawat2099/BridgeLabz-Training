public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int max=int.MinValue;
        for(int i=0;i<arr.Length;i++){
            if(arr[i]>max){
                max=arr[i];
            }
        }
        for(int i=0;i<arr.Length;i++){
            if(arr[i]==max){
                return i;
            }
        }
        return -1;
    }
}