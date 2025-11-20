// See https://aka.ms/new-console-template for more information
//Declare variables
public class Person
{
    public Person(DateOnly dob)
    {
        _age = DateTime.Now.Year - dob.Year;
        DateOfBirth = dob;
    }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public decimal Salary { get; set; }
    public char Gender { get; set; }
    public bool IsWorking { get; set; }
    private readonly int _age;
    public int GetnumberOfWorkingYearsRemaining()
    {
        return Constants.RetirementAge - _age;
    }
    public DateOnly GetEstimatedRetirementDate()
    {
        return DateOnly.FromDateTime(DateTime.Now.AddYears(GetnumberOfWorkingYearsRemaining()));  
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
    public int GetAge()
    {
        return _age;
    }
}
