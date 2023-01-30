/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да*/

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

bool IsNumberInArray(int[] numbers, int searchValue){
    foreach (var item in numbers)
    {
        if(item == searchValue)
            return true;
    }
    return false;
}


int arraySize = InputNumber("Введите размер генерируемого массива");
int leftRange = InputNumber("Введите наименьшее значение генерируемого массива");
int rightRange = InputNumber("Введите наибольшее значение генерируемого массива");
int[] numbers = new int[arraySize];
FillArray(numbers, leftRange, rightRange);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);
System.Console.WriteLine();
int searchValue = InputNumber("Введите число, которое мы ищем в массиве");
if(IsNumberInArray(numbers, searchValue))
    System.Console.WriteLine("Число присутствует в массиве");
else
    System.Console.WriteLine("Число отсутствует в массиве");
