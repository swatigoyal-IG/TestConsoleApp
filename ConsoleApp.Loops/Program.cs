// See https://aka.ms/new-console-template for more information

//Simple loop program to print Hello World 10 times
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Hello, World!- {i}");
//}
//Ask the user how many times to print Hello world, and print it that many times.
Console.Write("How many times you want to print Hello World?:  ");
int count = Convert.ToInt32(Console.ReadLine());
int i = 0;
//for (int i = 0; i < count; i++)
//{
//    Console.WriteLine($"Hello, World!- {i + 1}");
//}
while(i < count)
{
    Console.WriteLine($"Hello, World!- {i + 1}");
    i++;
}

