/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
        Частотный словарь содержит информацию о том, сколько раз встречается 
        элемент входных данных.
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

int[,] AddDictRow(int[,] dict, int item, int value)
{
    int[,] newDict = new int[dict.GetLength(0) + 1, 2];
    for (int i = 0; i < dict.GetLength(0); i++)
    {
        newDict[i, 0] = dict[i, 0];
        newDict[i, 1] = dict[i, 1];
    }
    newDict[dict.GetLength(0), 0] = item;
    newDict[dict.GetLength(0), 1] = value;
    return newDict;
}

int IsItemInDict(int[,] dict, int number)
{
    for (int i = 0; i < dict.GetLength(0); i++)
        if (dict[i, 0] == number)
            return i;

    return -1;
}

int[,] GenDictionary(int[,] numbers)
{
    int[,] dict = new int[,] { { numbers[0, 0], 1 } };

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (i == 0 && j == 0) continue;
            int idx = IsItemInDict(dict, numbers[i, j]);
            if (idx == -1)
                dict = AddDictRow(dict, numbers[i, j], 1);
            else
                dict[idx, 1]++;
        }
    }
    return dict;
}


int row = 1000, col = 1000, leftRange = 0, rightRange = 5;
int[,] numbers = FillArray(row, col, leftRange, rightRange);
//PrintArray(numbers);
System.Console.WriteLine("Array generated...");
PrintArray(GenDictionary(numbers));