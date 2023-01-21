/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/


System.Console.Write("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

if (number % 7 == 0 && number == 23)
    System.Console.WriteLine($"Число {number} одновременно кратно 7 и 23");
else
    System.Console.WriteLine("Число {number} не кратно одновременно 7 и 23");