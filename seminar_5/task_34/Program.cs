/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int CountEven(int[] numbers)
{
    int result = 0;
    foreach (var item in numbers)
    {
        if (item % 2 == 0)
            result++;
    }
    return result;
}

int arraySize = InputNumber("Введите размер генерируемого массива");
int leftRange = 100;
int rightRange = 999;
int[] numbers = new int[arraySize];
FillArray(numbers, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов массива: { CountEven(numbers)}");