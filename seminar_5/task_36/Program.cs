/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int SumOdd(int[] numbers){
    int result = 0;
    foreach (var item in numbers)
    {
        if(item %2 != 0)
            result += item;
    }
    return result;
}

int arraySize = InputNumber("Введите размер генерируемого массива");
int leftRange = InputNumber("Введите наименьшее значение генерируемого массива");
int rightRange = InputNumber("Введите наибольшее значение генерируемого массива");
int[] numbers = new int[arraySize];
FillArray(numbers, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных элементов массива: { SumOdd(numbers)}");