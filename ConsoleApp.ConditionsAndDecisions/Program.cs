// See https://aka.ms/new-console-template for more information

//Prompt for Input 
Console.Write("Please enter student grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

//Simple If .....Else .....Statement - decide to print pass or fail based on input
Console.WriteLine("************ Simple If Results **********");

if(grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affairs office");
}
Console.WriteLine("************ Simple If Results End **********");

//Complex IF.....Else if Statement - Decide to print letter based on grade value 
Console.WriteLine("************ Complex If...Else IF Results **********");
/*
 * A: 86 - 100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64
 * F: less than 50
 * AND operator both sides have to be true &&
 * OR operator one side have to be true ||
 */
if(grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <=64)
{
    Console.WriteLine("C-");
}
else if (grade >=65 && grade <=74 )
{
    Console.WriteLine("C");
    }
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >=85 && grade <=100)
{
    Console.WriteLine("A - Good Job");
}
Console.WriteLine("************ Complex If...Else IF Results End **********");

//Ternary Operators 
Console.WriteLine("                                                 ");
Console.WriteLine("******* Ternary Operator Result*******");

String passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("******* Ternary Operator Result End*******");

//the rest of the application 
Console.WriteLine("thank you for using this program");

