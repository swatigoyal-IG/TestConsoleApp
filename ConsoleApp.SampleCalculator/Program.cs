// See https://aka.ms/new-console-template for more information
int choice = 0;
int num1, num2, result = 0;
while (choice != -1)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Welcome to the sample calculator");
        //Show calculator menu
        Console.WriteLine("Select operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter choice (1-4 & -1 to exit): ");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == -1)
        {
            break;
        }
        Console.WriteLine();
        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        result = 0;

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
               
                result = num1 / num2;
                break;
            default:
                {
                    throw new Exception("Invalid operation choice");
                }
        }
        //Print Output
        Console.WriteLine("Result: " + result);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: Division by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    } 
    finally
    {
        Console.WriteLine("Press Enter to Continue ");
        Console.ReadLine();
    }
}

Console.WriteLine("End of program");


