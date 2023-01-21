/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

*/

System.Console.Write("Введите число: ");
int first_point = int.Parse(System.Console.ReadLine());

for (int i = 1; i < first_point + 1; i++)
{
    double printed = Math.Pow(i, 2);
    System.Console.Write($"{printed} ");
}
System.Console.WriteLine("");