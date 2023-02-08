/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] FillArray(int Row, int Col, int leftRange, int rightRange)
{
    int[,] numbers = new int[Row, Col];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(leftRange, rightRange + 1);
        }
    }
    return numbers;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1); j++)
            System.Console.Write(numbers[i, j] + "\t");

        System.Console.WriteLine();
    }
}

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


double[] AverageByColumns(int[,] numbers)
{
    double[] averages = new double[numbers.GetLength(1)];
    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        int tempsum = 0;
        for (int row = 0; row < numbers.GetLength(0); row++)
        {
            tempsum += numbers[row, col];
        }
        averages[col] = System.Math.Round((double)tempsum/numbers.GetLength(0), 3);
    }
    return averages;
}

int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");

int leftRange = 0, rightRange = 9;
int[,] numbers = FillArray(M, N, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine("Средние значения по столбцам:");
System.Console.WriteLine(string.Join("\t", AverageByColumns(numbers)));