/*
Задача 49: Задайте двумерный массив.
 Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
*/


int[,]  FillArray(int Row, int Col, int leftRange, int rightRange)
{
    int[,] numbers = new int[Row,Col];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(leftRange, rightRange + 1);
        }
    }
    return numbers;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        
        for (int j = 0; j < numbers.GetLength(1); j++)
            System.Console.Write(numbers[i, j] + "\t");

        System.Console.WriteLine();
    }
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

void ProcessArray(int[, ] numbers){
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if(i%2 == 1 && j%2 == 1)
                numbers[i,j] = Convert.ToInt32(Math.Pow(numbers[i,j],2));
        }
    }
}



int M = InputNumber("Введите количество строк");
int N = InputNumber("Введите количество столбцов");
int leftRange = 0, rightRange = 99;
int[,] numbers = FillArray(M,N, leftRange, rightRange);
PrintArray(numbers);
ProcessArray(numbers);
System.Console.WriteLine("------------------------------------------------");
PrintArray(numbers);