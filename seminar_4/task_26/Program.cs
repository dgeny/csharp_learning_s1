/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

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

int CalcLength(int number)
{

    int count = 1;
    int store_number = number;
    // Определим порядок числа
    while (store_number / 10 > 0)
    {
        count++;
        store_number = store_number / 10;

    }
    return count;
}

string text = "Введите число";
System.Console.WriteLine(CalcLength(InputNumber(text)));