/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

void InvertNumbersArray(int[] numbers){
    for (int i=0; i<numbers.Length; i++)
    {
        numbers[i] *=-1;
    }
}

int arraySize = 10;
int leftRange = -100;
int rightRange = 100;


int[] numbers = new int[arraySize];

FillArray(numbers, leftRange, rightRange);
PrintArray(numbers);
InvertNumbersArray(numbers);
PrintArray(numbers);