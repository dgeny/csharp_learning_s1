/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
        if (!(int.TryParse(Console.ReadLine(), out number)) && number > 0)
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}

void ArraySortDesc(int[] array)
{
    int left=0, right = array.Length -1;
    
    while(left != array.Length -1)
    {
        for (int i = left; i < array.Length-1; i++)
        {
            if(array[i] < array[i+1])
            {
                int l = array[i];
                array[i] = array[i+1];
                array[i+1] = l;
            }    
        }
        for (int i = right; i > 0; i--)
        {
            if(array[i] > array[i-1])
            {
                int l = array[i];
                array[i] = array[i-1];
                array[i-1] = l;
            }
        }
        
        left++;
        right--;
    }
}

void SortByRowDesc(int[,] numbers)
{
    int[] sorting = new int[numbers.GetLength(1)];
    for (int row = 0; row < numbers.GetLength(0); row++)
    {
        int temp =0;
        for (int col = 0; col < numbers.GetLength(1); col++)
        {
            sorting[col] = numbers[row,col];
        }
        ArraySortDesc(sorting);
        for (int col = 0; col < numbers.GetLength(1); col++)
        {
            numbers[row,col] = sorting[col];
        }
    }
    
}

int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");

int leftRange = 0, rightRange = 9;
int[,] numbers = FillArray(M, N, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив:");
SortByRowDesc(numbers);
PrintArray(numbers);