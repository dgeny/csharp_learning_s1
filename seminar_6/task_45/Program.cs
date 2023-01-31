/* Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования. */


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

int[] ArrayCopy(int[] baseArray)
{
    int[] returnArray = new int[baseArray.Length];
    for (int i = 0; i < baseArray.Length; i++)
    {
        returnArray[i] = baseArray[i];
    }
    return returnArray;
}


int arraySize = InputNumber("Введите размер генерируемого массива");
int leftRange = InputNumber("Введите наименьшее значение генерируемого массива");
int rightRange = InputNumber("Введите наибольшее значение генерируемого массива");
int[] numbers = new int[arraySize];
FillArray(numbers, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine("Скопированый массив:");
PrintArray(ArrayCopy(numbers));