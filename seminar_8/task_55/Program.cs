/* 
Задача 55: Задайте двумерный массив. Напишите программу, 
            которая заменяет строки на столбцы.
*/



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
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}

int[,] TranponseMatrix(int[,] number){
    int[,] transposed = new int[number.GetLength(1) ,number.GetLength(0)];
    for (int i = 0; i < transposed.GetLength(0); i++)
    {
        for (int j = 0; j < transposed.GetLength(1); j++)
        {
            transposed[i,j] = number[j,i];
        }
    }
    return transposed;
}

int row = 13, col = 5, leftRange = -100, rightRange = 100;
int[,] numbers = FillArray(row, col, leftRange, rightRange);
PrintArray(numbers);
System.Console.WriteLine();
PrintArray( TranponseMatrix(numbers));