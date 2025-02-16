// See https://aka.ms/new-console-template for more information

//option 1 
using System.Linq.Expressions;

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());


//Option 2 
int num2 = 0;

Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
 * 
 * Maths Operations and Operators 
 * 
 * */

//Add number
int sum = num1 + num2;

//multiply 
int product = num1 * num2;

//division
int quotient = num1 / num2;

//Subtraction 
int difference = num1 - num2;

//Modolus 
int mod = num1 % num2;
Console.WriteLine("*************** Math Results ****************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine("**************** End Math Results ***************");
Console.WriteLine();

/*
 * Logical Operations and Operators 
 * 
 */

//new way to define a variable by usung var (wildcard)

bool isGreaterthan = num1 > num2;
bool isLessthan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterthanOrEqualto = num1 >= num2;
bool isLessthanOrEqualto = num1 <= num2;
bool isNotEqualto = num1 != num2;


Console.WriteLine("************* Logical Results **********");
Console.WriteLine($"Is Greter Than : {isGreaterthan}");
Console.WriteLine($"isLessthan: {isLessthan}");
Console.WriteLine($"is Equal to: {isEqualTo}");
Console.WriteLine($"is Greater than or Equal to: {isGreaterthanOrEqualto}");    
Console.WriteLine($"is Less than or Equal to: {isLessthanOrEqualto}");  
Console.WriteLine($"is Not equal to: {isNotEqualto}");
Console.WriteLine("************** End of Logical Results ******");


/*
    Assignment Operations and Operators 
 */
// randomValue = 5;
//int increasedValue = num1 + 5;

//Mixing the operator with the output 

Console.Write("Enter Random Value for Assignemt Operations:  ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("************** Assignments Results ******");
Console.WriteLine();
//num1 += 5;
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}:  {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}:{num1}");
//num1 %= 2;
num1 /= randomValue;
Console.WriteLine($"Num 1 divide by {randomValue}: {num1}");
//num1 /= 2;
num1 %= randomValue;
Console.WriteLine($" Num 1 mod by {randomValue}: {num1}");
//num1 *= 10;
num1 *= randomValue;
Console.WriteLine($"Num 1 multiply by {randomValue}: {num1}");
Console.WriteLine() ;   
Console.WriteLine("************** End of Assignment Results ******");

// Ask for the input and used it as an assignment operator for the print out 





