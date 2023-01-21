// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Проверка числа на четность");
System.Console.WriteLine();

System.Console.Write("Введите число: ");
int number = int.Parse(System.Console.ReadLine());

System.Console.Write("Это число ");
if (number % 2 == 0)
{
    System.Console.Write(" четное");
}
else
{
    System.Console.Write(" нечетное");
}

