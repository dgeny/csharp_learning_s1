
/* 
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

int number;
do
{
    number = -1;
    System.Console.Write("Введите неотрицательное число: ");
}
while (!(int.TryParse(Console.ReadLine(), out number) && number > 0));

for (int i=1; i < number+1; i++)
{
    System.Console.Write($"{Math.Pow(i,3)}, ");
}
System.Console.WriteLine();