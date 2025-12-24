using System;
class Armstong{
static void Main(){
Console.Write("enter the number: ");
int n=Convert.ToInt32(Console.ReadLine());
int count=0;
int temp=n;
int originalNum=n;
while(n!=0){
count++;
n=n/10;
}
int sum=0;
while(temp!=0){
	int rem=temp%10;
	sum=(int)(sum+Math.Pow(rem,count));
	temp=temp/10;
}
if(sum==originalNum){
	Console.Write("yes,number is armstong");
}
else
Console.Write("not a armstong number");
}}