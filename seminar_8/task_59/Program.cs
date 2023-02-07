/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */



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

int[] FindMinimum(int[,] numbers)
{
    int min = numbers[0, 0], minR = 0, minC = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] < min )
            {
                min = numbers[i, j];
                minR = i;
                minC = j;
            }
        }
    }
    return new int[] {minR, minC};
}


int[,] CutArray(int[,] numbers, int[] point){
    int[,] cuted = new int[numbers.GetLength(0)-1,numbers.GetLength(1)-1];
    int shiftX=0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        if(i == point[0]) {shiftX++; continue;}
        int shiftY=0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (j == point[1]) {shiftY++;continue;}
            cuted[i-shiftX,j-shiftY] = numbers[i,j]; 
        }
    }
    return cuted;
}

int row = 3, col = 5, leftRange = 0 , rightRange = 10;
int[,] numbers = FillArray(row, col, leftRange, rightRange);
PrintArray(numbers);
System.Console.WriteLine();
int[] point = FindMinimum(numbers);
System.Console.WriteLine("Position of minimal item: (" + string.Join(",",point) + ")");
PrintArray(CutArray(numbers, point));
