/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] MultiplyPairs(int[] nums)
{
    int[] result = new int[nums.Length % 2 == 0 ? nums.Length / 2 : nums.Length / 2 + 1];

    for (int i = 0; i < nums.Length / 2; i++)
    {
        result[i] = nums[i] * nums[nums.Length - 1 - i];
    }

    if (nums.Length % 2 != 0)
        result[nums.Length / 2] = nums[nums.Length / 2];

    return result;
}

int[] numbers = new int[5];
FillArray(numbers, 1, 10);
System.Console.WriteLine("Исходный массив:");
PrintArray(numbers);
System.Console.WriteLine("результирующий массив:");
PrintArray(MultiplyPairs(numbers));