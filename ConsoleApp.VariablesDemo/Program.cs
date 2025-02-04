// See https://aka.ms/new-console-template for more information
// there are different data type 

/*
    text - String 
    integers - int 
    decimal - double, float, decimal 
    logical- bool (true or false)
*/

//string
string name = "Lady Bug";

Console.WriteLine(name);
Console.WriteLine("I am " + name); // add one string to the other (concat)
Console.WriteLine($"they call me  {name}"); // string interpolation
Console.WriteLine("I was given the name {0}", name); // formatted string

//integers
int age = 25;
int retirementYearsLeft = 40;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is :" + retirementAge);

//Boolean
bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);




