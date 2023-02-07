/* Задача 53: Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива. */


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

void MixMatrix(int[, ] numbers){

    int temp = int.MinValue;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        temp = numbers[0, i];
        numbers[0, i] = numbers[numbers.GetLength(0)-1, i];
        numbers[numbers.GetLength(0)-1, i] = temp;
    }
}

int row = 3, col = 4, leftRange = -100, rightRange = 100;
int[,] numbers = FillArray(row, col, leftRange, rightRange);
PrintArray(numbers);
MixMatrix(numbers);
System.Console.WriteLine();
PrintArray(numbers);

