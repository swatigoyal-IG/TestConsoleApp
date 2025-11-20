// See https://aka.ms/new-console-template for more information
using ConsoleApp.ClassesDemo;

Console.WriteLine("*******- Classes -*********");
Person person; // this will be null by default

Person baby = new Person();
baby.FirstName = "Swati";
baby.LastName = "Goyal";
baby.DateOfBirth = new DateOnly(1978, 5, 3);
//Console.WriteLine($"{baby.FirstName} {baby.LastName} was born on {baby.DateOfBirth.ToLongDateString()}.");
baby.printFullName();
baby.PrintInitial();
baby.GenerateTaxNumber();
Console.WriteLine($"{baby.GetTaxNumber()}");

var person1 = new Person("Amit", "Gupta", new DateOnly(1976, 05, 25));
person1.printFullName();
person1.PrintInitial();
var person2 = new Person("Neha", "Shah", "TX12345");
person2.printFullName();
person2.PrintInitial();
person2.GenerateTaxNumber();

var teacher = new Teacher();
var student = new Student();
teacher.FirstName = "Rahul";
teacher.LastName = "Dravid";
teacher.printFullName();
teacher.PrintInitial();
teacher.GenerateTeacherIdNumber();
Console.WriteLine($"{teacher.GetIdNumber()}");

student.FirstName = "Sourav";
student.LastName = "Ganguly";
student.printFullName();
student.PrintInitial();
student.GenerateStudentIdNumber();
Console.WriteLine($"{student.GetIdNumber()}");

Rectangle rectange = new(10, 20);
Console.WriteLine($"Area of rectangle is: {rectange.Area()}");

Square square = new(10);
Console.WriteLine($"Area of square is: {square.Area()}");