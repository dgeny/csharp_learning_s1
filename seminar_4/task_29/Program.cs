/*Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/



void FillArray(int[] numbers){
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        // В условии не четко сформулированы границы задаваемых чисел
        // поэтому примем их от 0 до 100
        numbers[i] = rnd.Next(0,100);
    }
}

void PrintArray(int[] numbers){
    /*
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    System.Console.Write("]");*/
    System.Console.WriteLine("[ "+ string.Join(", ", numbers) + " ]");
}

int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);
System.Console.WriteLine();