// See https://aka.ms/new-console-template for more information

//Different datatypes
/*
 * text - String
 * integers - int
 * decimal - double, float, decimal
 * logical - bool
 */
string name = "Swati Goyal";

Console.WriteLine("I am " + name);//String concatenation
Console.WriteLine($"They call me {name}");//String interpolation
Console.WriteLine("I was given the name {0}", name);//Formatted string

int age = 48;
int retirementAgeLeft = 12;
int retirementAge = age + retirementAgeLeft;
Console.WriteLine("My age is: " + age);
Console.WriteLine($"My age is: {age}");
Console.WriteLine("My retirement age is: {0}", retirementAge);
bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);