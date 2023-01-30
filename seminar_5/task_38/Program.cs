/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

void FillArray(double[] numbers, int leftRange, int rightRange)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(leftRange, rightRange + 1) + rnd.NextDouble();
    }
}

void PrintArray(double[] numbers)
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

// Рисуем велик, т.к. double[].Max() уже реализован
int IndexOfMaxInArray(double[] numbers)
{
    int result = 0;
    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i] > numbers[result])
            result = i;
    return result;
}

// Рисуем велик, т.к. double[].Min() опять же реализован
int IndexOfMinInArray(double[] numbers)
{
    int result = 0;
    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i] < numbers[result])
            result = i;
    return result;
}

double DiffMinMax(double[] numbers)
{
    return numbers[IndexOfMaxInArray(numbers)] - numbers[IndexOfMinInArray(numbers)];
}
int arraySize = InputNumber("Введите размер генерируемого массива");
int leftRange = InputNumber("Введите наименьшее значение генерируемого массива");
int rightRange = InputNumber("Введите наибольшее значение генерируемого массива");
double[] numbers = new double[arraySize];
FillArray(numbers, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine(
    $"Разница между максимальным и минимальным элементов массива: {Math.Round(DiffMinMax(numbers), 3)}");
