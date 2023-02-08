/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using System;

double[,] FillArray(int Row, int Col, int leftRange, int rightRange)
{
    double[,] numbers = new double[Row, Col];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(leftRange, rightRange) + rnd.NextDouble();
        }
    }
    return numbers;
}

void PrintDoubleArray(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1); j++)
            System.Console.Write(Math.Round(numbers[i, j], 2) + "\t");

        System.Console.WriteLine();
    }
}

int InputNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message + ": ");
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}


int leftRange = Int32.MinValue, rightRange = Int32.MaxValue;

int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");

double[,] numbers = FillArray(M, N, leftRange, rightRange);
PrintDoubleArray(numbers);