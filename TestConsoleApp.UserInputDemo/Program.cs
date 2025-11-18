// See https://aka.ms/new-console-template for more information
//Declare variables
using System.Globalization;

string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
const int retirementAge = 65;
DateOnly dob = new DateOnly();

//Get Input
Console.WriteLine("Please enter firstName");
firstName = Console.ReadLine();
Console.WriteLine("Please enter lastName");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your date of birth (dd/mm/yyyy): ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;
Console.WriteLine($"Your age is {age} years");

//Process data
int workingYearsRemaining = retirementAge - age;
DateTime retirementYear = DateTime.Now.AddYears(workingYearsRemaining);
//Output data
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");
Console.WriteLine($"You will retire in {retirementYear.Year}");
