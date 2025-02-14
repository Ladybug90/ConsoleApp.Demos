//Declare Variables 

string? firstname = string.Empty;
string lastname = string.Empty;
int age;
int retirementAge = 65;
decimal salary;
char gender;
bool working = true;

// Prompt user for input 
Console.Write("Please enter your first name: ");
firstname = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastname = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary: "); // int = 2 / decimal = 2.50
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());



//Process the data 
int workingYearsRemaining = retirementAge - age;

//Output the results to the user 
Console.WriteLine($"Full name: {firstname} {lastname}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"Are you employed: {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
