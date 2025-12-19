class Operators{
static void Main(String[] args){

		int a = 5;
		int b = 4;
		//Arithmetic Operators

		
		 // Addition
        int add = a + b;  
		// Subtraction		
        int sub = a - b;    
		// Multiplication
        int mul = a * b;   
		// Division		
        int div = a / b;  
		// Modulus		
        int mod = a % b;  
		Console.WriteLine(add+" "+sub+" "+mul+" "+div+" "+mod);		
		
		
		//Relational Operators
		bool equal  = a == b;  // Equal to
        bool notequal = a != b;  // Not equal to
        bool greaterThan  = a > b;   // Greater than
        bool lessThan  = a < b;   // Less than
        bool greaterThanEqual = a >= b;  // Greater than or equal to
        bool lessThanEqual = a <= b;  // Less than or equal to
		Console.WriteLine(equal+" "+notequal+" "+greaterThan+" "+lessThan+" "+greaterThanEqual+" "+lessThanEqual);

		//Logical Operators
		bool logicalAnd = (a > 5) && (b > 1); // Logical AND
        bool logicalOr  = (a > 20) || (b > 1); // Logical OR
        bool logicalNot = !(a < b); //Logical NOT
		Console.WriteLine(logicalAnd+" "+logicalOr+" "+logicalNot);
		
		//Assignment Operators
		int c=7;
		c+=1; //c=c+1
		Console.WriteLine(c);
		c-=2; //c=c-2;
		Console.WriteLine(c);
		c*=3; //c=c*3
		Console.WriteLine(c);
		c/=4; //c=c/4;
		Console.WriteLine(c);
		c%=5; //c=c%5
		Console.WriteLine(c);
		
		//Unary Operators
		int d = 10;
        d++;        // Increment
		Console.Write(d+" ");
        d--;        // Decrement
		Console.Write(d+" ");
        int pos = +d; // Unary plus
		Console.Write(d+" ");
        int neg = -d; // Unary minus
		Console.WriteLine(d+" ");
		
		
		//Ternary Operator
		 string res;
		 res = (c > d) ? "c is greater" : "d is greater";
		 Console.WriteLine(res);
		 
		 
		 // is Operator
		String str = "Dog";
        bool isOperator = str is int; // is operator
		Console.WriteLine(isOperator);
        
		
}
}