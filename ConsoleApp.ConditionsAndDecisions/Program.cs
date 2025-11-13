// See https://aka.ms/new-console-template for more information
//ConsoleApp.ConditionsAndDecisions
Console.Write("Please enter students grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
/* Beginning of comples if..else if...else example */
Console.WriteLine();
Console.WriteLine("Beginning of Complex if..else if...else example");
/*
 * Grade Logic:
 * F: < 50
 * C:50 - 64  (grade >= 50 && grade <=64)
 * B: 65 - 74 (grade >= 65 && grade <= 74)
 * B+: 75 - 84 (grade >= 75 && grade <= 84)
 * A: 85 - 100 (grade >= 85 && grade <= 100)
 */
if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Grade entered.");
}
else if (grade < 50)
{
    Console.WriteLine("Student has Failed - F.");
}
else if (grade >= 50 && grade <=64)
{
    Console.WriteLine("C");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("B");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B+");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A");
}

Console.WriteLine();
Console.WriteLine("End of Complex if..else if...else example");
Console.WriteLine();

/* Ternanry Operator */
Console.WriteLine("Beginning of Ternary Operator example");
Console.WriteLine();
string passedStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"passed Status = {passedStatus}");
Console.WriteLine();
Console.WriteLine("End of Ternary Operator example");
Console.WriteLine();
Console.WriteLine("End of Grading system.");

/* Switch case example */
Console.Write("Enter day of the week (1-7): ");
int dayOfTheWeek = Convert.ToInt32 (Console.ReadLine());
/*if (dayOfTheWeek < 1 || dayOfTheWeek > 7)
{
    Console.WriteLine("Invalid day entered.");
}
else if(dayOfTheWeek == 1)
{
    Console.WriteLine("Monday");
}
else if (dayOfTheWeek == 2)
{
    Console.WriteLine("Tuesday");
}
else if (dayOfTheWeek == 3)
{
    Console.WriteLine("Wednesday");
}
else if (dayOfTheWeek == 4)
{
    Console.WriteLine("Thursday");
}
else if (dayOfTheWeek == 5)
{
    Console.WriteLine("Friday");
}
else if (dayOfTheWeek == 6)
{
    Console.WriteLine("Saturday");
}
else if (dayOfTheWeek == 7)
{
    Console.WriteLine("Sunday");
}*/
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day entered.");
        break;
}
Console.WriteLine();
Console.WriteLine("End of the program");
