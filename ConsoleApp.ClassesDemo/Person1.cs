// See https://aka.ms/new-console-template for more information
// Define a class
using ConsoleApp.ClassesDemo;
using System.Drawing;
using System.Security.Cryptography;

public class Person
{
    //Constructor
    public Person()
    {
        FirstName = null;
        LastName = null;
    }
    public Person(string firstName, string lastName, DateOnly dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }
    //Properties/Data Members
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    private string _taxNumber;
    protected string _idNumber = "N/A";
    public void printFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
    public void PrintInitial()
    {
        var firstNameInitial = FirstName[0];
        var lastNameInitial = LastName[0];
        Console.WriteLine($"Initials are: {firstNameInitial}.{lastNameInitial}.");
    }
    public void GenerateTaxNumber()
    {
        if(string.IsNullOrEmpty(_taxNumber))
        {
        _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine("Tax number already exists.");
        }
    }
    public void GenerateIdNumber()
    {
        if (string.IsNullOrEmpty(_idNumber))
        {
            _idNumber = getRandomNumber();
        }
        else
        {
            Console.WriteLine("ID number already exists.");
        }
    }
    protected string getRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
    }
    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }
    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }
    public int GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age;
    }
}


