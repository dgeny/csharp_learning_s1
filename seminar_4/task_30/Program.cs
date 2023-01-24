/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void FillArray(int[] numbers){
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0,2);
    }
}

void PrintArray(int[] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    System.Console.Write("]");
}

int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);
System.Console.WriteLine();