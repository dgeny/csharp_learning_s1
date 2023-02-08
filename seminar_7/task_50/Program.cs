/* Задача 50. Напишите программу, которая на вход принимает число,
возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
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

int[,] AddPositionRow(int[,] pos, int item, int value)
{
    int[,] newPositions = new int[pos.GetLength(0) + 1, 2];
    for (int i = 0; i < pos.GetLength(0); i++)
    {
        newPositions[i, 0] = pos[i, 0];
        newPositions[i, 1] = pos[i, 1];
    }
    newPositions[pos.GetLength(0), 0] = item;
    newPositions[pos.GetLength(0), 1] = value;
    return newPositions;
}

int[,] IndexOfTwoDimArray(int criteria, int[,] numbers)
{
    int[,] positions = new int[1, 2];
    positions[0, 0] = -1;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == criteria && positions[0, 0] != -1)
            { positions = AddPositionRow(positions, i, j); }
            else if (numbers[i, j] == criteria)
            {
                positions[0, 0] = i;
                positions[0, 1] = j;
            }
        }
    }
    return positions;
}

void PrettyPrintPositions(int[,] positions)
{
    string[] positionStrings = new string[positions.GetLength(0)];
    for (int i = 0; i < positions.GetLength(0); i++)
    {
        positionStrings[i] = $"({positions[i, 0]},{positions[i, 1]})";
    }
    System.Console.WriteLine(string.Join(", ", positionStrings));
}


int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");
int searchV = InputNumber("Введите искомое число");
int leftRange = 0, rightRange = 9;
int[,] numbers = FillArray(M, N, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
int[,] positions = IndexOfTwoDimArray(searchV, numbers);
if (positions[0, 0] != -1)
{
    System.Console.Write($"Число {searchV} находится в позициях:");
    PrettyPrintPositions(positions);
}
else
    System.Console.WriteLine($"Числа {searchV} в массиве нет.");
