// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the sample calculator");

//Show calculator menu
Console.WriteLine("Select operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.Write("Enter choice (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = 0;
switch (choice)
{
    case 1:
        result = num1 + num2;
        break;
    case 2:
        result = num1 - num2;
        break;
    case 3:
        result = num1 * num2;
        break;
    case 4:
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero");
            return;
        }
        break;
    default:
        {
            Console.WriteLine("Invalid choice");
            return;
        }
}
Console.WriteLine("Result: " + result);
Console.WriteLine("End of program");


