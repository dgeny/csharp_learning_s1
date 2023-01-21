/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

*/

System.Console.WriteLine("Задача на проверку того, является ли первое число квадратом второго");
System.Console.WriteLine();

int first_number = 0, two_number = 0;
System.Console.WriteLine("Enter first number: ");
first_number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter next number: ");
two_number = int.Parse(Console.ReadLine());

if (first_number == two_number * two_number ||
    two_number == first_number * first_number)
{
    System.Console.WriteLine($"Да");
}
else
{
    System.Console.WriteLine($"Нет");
}