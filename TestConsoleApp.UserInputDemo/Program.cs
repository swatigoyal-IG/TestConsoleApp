// See https://aka.ms/new-console-template for more information
//Declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

//Get Input
Console.WriteLine("Please enter firstName");
firstName = Console.ReadLine();
Console.WriteLine("Please enter lastName");
lastName = Console.ReadLine();

Console.WriteLine("Please enter Age");
age = Convert.ToInt32( Console.ReadLine());

//Process data
int workingYearsRemaining = retirementAge - age;

//Output data
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
