// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** - Methods - ******");
// void methods - completes a task without returning a value
void PrintName()
{
    //Method code
    Console.WriteLine("My name is Swati");
}

// Value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}
// methods with parameters
void PrintNameWithParams(string name)
{
    //Method code
    Console.WriteLine($"My name is {name}");
}
int GetYearDifferenceWithParams(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}
// methods with optional parameters
int GetFutureOrPastYear(int numberOfYears = 0)
{    
    int year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}
// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count)
{
    //if(string.IsNullOrEmpty(name))
    //{
    //    name = "Default Name";
    //}
    //if(!count.HasValue)
    //{
    //    count = 1;
    //}
    name ??= "Default Name";
    count ??= 1;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }   
}
/* Function Calls */
PrintName();
PrintName();
PrintName();
PrintName();
PrintName();
int fiveYearsAgo = GetFiveYearsAgo();
Console.WriteLine($"5 Years ago from current year is: {fiveYearsAgo}");
PrintNameWithParams("Swati");
int ageYears = GetYearDifferenceWithParams(1979);
Console.WriteLine($"My age is: {ageYears} years");
Console.WriteLine("Enter number of years in the future or past.");
int numberOfYears = Convert.ToInt32(Console.ReadLine());
var pastYear1 = GetFutureOrPastYear();
Console.WriteLine("The year is: " + pastYear1);

int pastYear2 = GetFutureOrPastYear(numberOfYears);
Console.WriteLine("The year is: " + pastYear2);
PrintNameNullableParam(null, null);
PrintNameNullableParam("Chester", 5);