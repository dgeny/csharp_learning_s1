/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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

int GetMinSumByRow(int[,] numbers, out int sum)
{
    int minStringNum = 0, minSum = int.MaxValue;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int tmpSum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            tmpSum += numbers[i,j];
        }
        if(tmpSum < minSum)
        {    
            minSum=tmpSum;
            minStringNum = i;
        }
    }
    sum = minSum;
    return minStringNum;
}


int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");

int leftRange = 0, rightRange = 9;
int[,] numbers = FillArray(M, N, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
int sum = 0;
System.Console.WriteLine($"Строка с минимальной суммой элементов:{GetMinSumByRow(numbers, out sum)+1} (нумерация строк в соответствии с примером начинается с 1, сумма = {sum} )");
