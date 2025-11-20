// See https://aka.ms/new-console-template for more information
//Declare variables
using System;
using System.Globalization;
using System.Xml.Serialization;

char choice = char.MinValue;
string? firstName = string.Empty;
string? lastName = string.Empty;
decimal salary = 0;
bool working = false;
char gender = char.MinValue;
DateOnly dob = new DateOnly();
List<Person> persons = new List<Person>();
while (choice != 'E')
{
    //Get Input
    Console.Write("Please enter firstName: ");
    firstName = Console.ReadLine();
    Console.Write("Please enter lastName: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Please enter your gender (M or F):");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you currently working? (true/false): ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new Person(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };
    persons.Add(person);

    //Process data
    //int workingYearsRemaining = person.GetnumberOfWorkingYearsRemaining();
    //DateOnly retirementYear = person.GetEstimatedRetirementDate();
    Console.WriteLine("C - continue | E - exit.");
    choice = Convert.ToChar(Console.ReadLine());
}

//Output data
foreach (Person person in persons)
{
    Console.WriteLine();
    Console.WriteLine($"Full Name: {person.ToString()}");
    Console.WriteLine($"Age: {person.GetAge()}");
    Console.WriteLine($"Salary: {person.Salary:C}");
    Console.WriteLine($"Gender: {person.Gender}");
    Console.WriteLine($"Currently Working: {person.IsWorking}");
    Console.WriteLine($"Working years remaining: {person.GetnumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"You will retire in {person.GetEstimatedRetirementDate().Year}");
}



