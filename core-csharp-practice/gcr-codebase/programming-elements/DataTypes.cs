class DataTypes{
static void Main(){
	
	//Byte
	byte byteNum=2;
	Console.WriteLine("Byte: "+byteNum);
	
	
	// Short
      
        int ShortNum = 10;
        Console.WriteLine("Integer: " +ShortNum);
	 // Integer 
      
        int num = 100;
        Console.WriteLine("Integer: " +num);

	   // Long
      
        int LongNum = 10000;
        Console.WriteLine("Integer: " +LongNum);
      //Float
        
        float floatNum = 12.5f;
        Console.WriteLine("Float: " + floatNum);

        // Double
        double doubleNum = 123.456;
        Console.WriteLine("Double: " +doubleNum);

        // Char
        char ch = 'A';
        Console.WriteLine("Char: " +ch);

        // Boolean
      
        bool isTrue = true;
        Console.WriteLine("Boolean: " + isTrue);      
 
    

	//Type Casting
	int a=100;
	double b=a;//implicit
	Console.WriteLine("int to Double: "+b);
	 double d= 123.45;
     int i = (int)d;  // Explicit casting
     Console.WriteLine("Explicit Casting (double to int): " + i);
	 
	 
	 
	//String to int 
	 
	 string str = "688";
        int numFromString = Convert.ToInt32(str);
        Console.WriteLine(numFromString);
// string to double
        double doubleFromString = Convert.ToDouble("123.45");
        Console.WriteLine(doubleFromString);

     
        // Number to string
        int n = 1090;
        string strToNum = n.ToString();
        Console.WriteLine(strToNum);
	 
}}