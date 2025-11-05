// See https://aka.ms/new-console-template for more information
//Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

//Get Input
Console.WriteLine("Please enter Name");
name = Console.ReadLine();
Console.WriteLine("Please enter Age");
age = Convert.ToInt32( Console.ReadLine());

//Process data
int workingYearsRemaining = retirementAge - age;

//Output data
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
