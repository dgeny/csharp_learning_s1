/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/



System.Console.WriteLine("Программа, выводящая какое число большее");
System.Console.Write("Введите первое число: ");
int first_number = int.Parse(System.Console.ReadLine());

System.Console.Write("Введите второе число: ");
int two_number = int.Parse(System.Console.ReadLine());

int result = two_number % first_number;

if (result == 0)
{
    System.Console.WriteLine($"Число  {two_number} кратно {first_number}");
}
else
{
    System.Console.WriteLine($"Число {two_number} не кратно {first_number}, остаток {result}");
}