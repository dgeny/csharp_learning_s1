/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/


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

int CalcPositive(string[] parsingStrings, out int numCount)
{
    int count = 0;
    numCount = 0;
    foreach (var item in parsingStrings)
    {
        int num = 0;
        if (int.TryParse(item, out num))
        {
            numCount++;
            if (num > 0)
                count++;
        }
    }
    return count;
}

/*
int arraySize = InputNumber("Введите количество чисел");
int[] numbers = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
   numbers[i] = InputNumber("Введите следующее число");
}
*/

System.Console.Write("Введите произвольное количество чисел (через пробел):");
string[] userInput = Console.ReadLine().Split(" ");
int numbersCount = 0;
int posCount = CalcPositive(userInput, out numbersCount);
System.Console.WriteLine($"Вы ввели {numbersCount} чисел, положительных из них - {posCount} ");