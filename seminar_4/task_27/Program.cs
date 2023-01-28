/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}

int SumDigits(int number)
{
    if (number < 10) return number;
    else return SumDigits(number / 10) + (number % 10);
}

System.Console.WriteLine($"Сумма цифр числа составляет: {SumDigits(InputNumber("Введите число: "))}");