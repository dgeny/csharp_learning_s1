/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/


// Вариант 1
System.Console.WriteLine("Проверка пятизначного числа на палиндром");
int number = -1;
do
{
    System.Console.Write("Введите пятизначное неотрицательное число:");
}
while (!(int.TryParse(Console.ReadLine(), out number) && number.ToString().Length == 5));


if ((number / 10000 == number % 10)
    && (number / 1000 % 10 == number / 10 % 10))
{

    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// Вариант 2
string entered = "";
do
{
    System.Console.Write("Введите пятизначное неотрицательное число:");
    entered = Console.ReadLine();
}
//Если не проверять введут 00100 и будут правы :)
while (!(int.TryParse(entered, out number) && number.ToString().Length == 5));

if (entered[0] == entered[4] && entered[1] == entered[3])
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// Вариант 3 - для любых int32 
number = -1;
do
{
    System.Console.Write("Введите неотрицательное число больше 10:");
}
while (!(int.TryParse(Console.ReadLine(), out number) && number > 10));
double count = 1;
int store_number = number;
// Определим порядок числа
while (store_number / 10 > 0)
{
    count++;
    store_number = store_number / 10;

}
Console.WriteLine($"Десятичный порядок введенного числа: {count}");

//Развернем число
store_number = 0;
for (double i = count - 1; i > -1; i--)
{
    store_number += (number / Convert.ToInt32(Math.Pow(10, i)) % 10) * Convert.ToInt32(Math.Pow(10, count - i - 1));
}
// Сравним введенное и развернутое
if (number == store_number)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}