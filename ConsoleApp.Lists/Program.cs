// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** - Lists - ******");

// Declare a List
int grade = 0;
string name;
int @continue = 0;
List<int> grades = new List<int>();
List<string> students = new List<string>();
//var grades1 = new List<int>();
//List<int> grades2 = new();
// Add values to list
//grades.Add(45);
//Console.WriteLine(grades[0]);
do
{
    Console.Write($"Please enter name for student: ");
    name = Console.ReadLine();
    students.Add(name);
    Console.Write($"Please enter grade for a student: ");
    grade= Convert.ToInt32(Console.ReadLine());
    if(grade != -1)
    {
        grades.Add(grade);
    }
    Console.Write("Do you want to continue? (1-Yes / 2-No): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} while (@continue == 1);
// Print values in list -for
Console.WriteLine("Printing grades using for loop:");
for(int i = 0; i < grades.Count; i++)
{
    Console.WriteLine($"Grade for {students[i]} is: {grades[i]}");
}
// Print values in list - foreach
Console.WriteLine("Printing grades using foreach loop:");
foreach (int g in grades)
{
    Console.WriteLine(g);
}
grades.Remove(45);