/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
using System;

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message + ": ");
        if (!(int.TryParse(Console.ReadLine(), out number)) && number > 0)
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}


int[,,] MakeArray(int x, int y, int z)
{
    bool[] usedNumbers = new bool[90];
    Random rnd = new Random();
    int[,,] returnArray = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int temp = 0;
                do
                {
                    temp = rnd.Next(10, 100);
                }
                while (usedNumbers[temp - 10]);
                returnArray[i, j, k] = temp;
                usedNumbers[temp - 10] = true;
            }
        }
    }
    return returnArray;
}

void PrettyPrintArray(int[,,] numbers)
{
    for (int x = 0; x < numbers.GetLength(0); x++)
    {
        for (int y = 0; y < numbers.GetLength(1); y++)
        {
            for (int z = 0; z < numbers.GetLength(2); z++)
            {
                System.Console.Write($"{numbers[x, y, z]}({x},{y},{z})" + "  ");
            }
        }
        System.Console.WriteLine();
    }
}

int x = 0, y = 0, z = 0;

do
{
    x = InputNumber("Введите количество элементов первой грани");
    y = InputNumber("Введите количество элементов второй грани");
    z = InputNumber("Введите количество элементов третьей грани");
    if (x * y * z > 90)
    {
        System.Console.WriteLine("Вводимые Вами измерения не удовлетворяют условию задачи(максимум 90 элементов).");
        System.Console.Write("Повторить ввод данных (r) или выйти (any other key / default action): ");
        string? userInput = System.Console.ReadLine();
        switch (userInput.ToLower())
        {
            case "r": continue;
            case "x":
                {
                    System.Environment.Exit(0);
                    break;
                }
            default:
                {
                    System.Environment.Exit(0);
                    break;
                }
        }

    }
    else break;
}
while (true);

PrettyPrintArray(MakeArray(x, y, z));