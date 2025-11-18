// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** -Arrays - *******");
Console.WriteLine("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());
// Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// Add values to Fixed Size Array
//grades[0] = 45;
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Please enter name for student {i + 1}: ");
    students[i] = Console.ReadLine();
    Console.Write($"Please enter grade for student {i + 1}: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
// Print values in Fixed Size Array
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Grade for {students[i]} is: {grades[i]}");
}
// Declare Variable Sized Array
//String[] names = {"John", "Jane", "Jim", "Jill" };
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine($"Name of student {i + 1} is: {names[i]}");
//}
// Add values to Variable Sized Array

//Print values in Variable Sized Array
