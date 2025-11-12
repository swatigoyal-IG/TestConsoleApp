// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
string numberEntered = Console.ReadLine();
int num2 = Convert.ToInt32(numberEntered);

/*
 * Math operations and operators 
 * */ 

//Add numbers
int sum = num1 + num2;

//multiply numbers
int product = num1 * num2;

//quotient
int quotient = num1/ num2;

//difference
int difference = num1 - num2;

//modulus
int modulus = num1 % num2;

//display results
Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
Console.WriteLine($"The product of {num1} and {num2} is: {product}");
Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}");
Console.WriteLine($"The difference of {num1} and {num2} is: {difference}");
Console.WriteLine($"The modulus of {num1} and {num2} is: {modulus}");

/*
 * Logic Operators
 */

var isGreater = num1 > num2;
var isLess = num1 < num2;
var isEqual = num1 == num2;
bool isGreaterOrEqual = num1 >= num2;
bool isLessOrEqual = num1 <= num2;
bool isNotEqual = num1 != num2;
Console.WriteLine($"{num1} is greater than {num2}: {isGreater}");
Console.WriteLine($"{num1} is less than {num2}: {isLess}");
Console.WriteLine($"{num1} is equal to {num2}: {isEqual}");
Console.WriteLine($"{num1} is greater than or equal to {num2}: {isGreaterOrEqual}");
Console.WriteLine($"{num1} is less than or equal to {num2}: {isLessOrEqual}");
Console.WriteLine($"{num1} is not equal to {num2}: {isNotEqual}");


/*
 * Assignment Operators
 */
num1 += 5;
num1 -= 3;
Console.WriteLine("Press any key to exit.");
