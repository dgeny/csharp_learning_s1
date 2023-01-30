/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/


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

int CountInRange(int[] numbers)
{
    int res = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(i < 100 && i > 10)
            res++;
    }
    return res;
}

int[] numbers = new int[123];

FillArray(numbers, -100, 100);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
int minValue = 10;
int maxValue = 99;
System.Console.WriteLine($"Число элементов в промежутке от 10 до 99: {CountInRange(numbers)}");
