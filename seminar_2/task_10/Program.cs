/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// Вариант 1.
int number = 0;
do
{
    System.Console.Write("Введите трехзначное число:");
}
while (!
        (int.TryParse(Console.ReadLine(), out number) &&
        (number > 99) && 
        (number < 1000))
);

System.Console.WriteLine(number  % 100 / 10 % 10); 

// Вариант 2.
string s_number = "";
while (s_number.Length != 3 && !int.TryParse(s_number, out number))
{
    System.Console.Write("Введите трехзначное число:");
    s_number = Console.ReadLine();
}


System.Console.WriteLine(s_number[1]);