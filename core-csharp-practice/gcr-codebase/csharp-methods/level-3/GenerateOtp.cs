using System;

class GenerateOtp
{
    // method to generate otp
    public static int Generate()
    {
        Random rand = new Random();
        return rand.Next(100000, 1000000);
    }
    // nmethod to check unique
    public static bool IsUnique(int[] arr)
    {
        for (int i=0;i< arr.Length;i++)
            for (int j = i + 1;j<arr.Length;j++)
                if (arr[i]==arr[j]){
				return false;}
        return true;
    }

    static void Main()
    {
        int[] otp = new int[10];
        for (int i = 0;i<10; i++){
		otp[i] = Generate();}
        Console.WriteLine("otps: " + string.Join(", ", otp));
        Console.WriteLine("otps are unique: " + IsUnique(otp));
    }
}
