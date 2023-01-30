
void FillArray(int[] numbers, int leftRange, int rightRange)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(leftRange, rightRange + 1);
    }
}

void PrintArray(int[] numbers)
{
    System.Console.WriteLine("[ " + string.Join(", ", numbers) + " ]");
}

void SumPositiveOrNegative(int[] array, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP += array[i];
        }
        else
        {
            sumN += array[i];
        }
    }
}

int[] array = new int[12];
FillArray(array, -9, 9);
PrintArray(array);
SumPositiveOrNegative(array, out int sumPositive, out int sumNegative);
System.Console.WriteLine($"Сумма положительных = {sumPositive}, отрицательных = {sumNegative}");