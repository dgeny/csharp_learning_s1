/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Int128 number = 0;
do
{
    System.Console.Write("Введите произвольное число, начиная с 100:");
}
while (!
        (Int128.TryParse(Console.ReadLine(), out number) &&
        (number > 99))
);

while(number  > 1000)
{
        number = number / 10;
}
System.Console.WriteLine($"Третья  цифра числа - {number % 10}");