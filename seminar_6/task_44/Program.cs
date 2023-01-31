/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
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


void PrintVibo(int number)
{
    int prev = 1;
    int prevPrev = 0;
    if(number == 1){
        System.Console.Write("0");
    }
    else if(number == 2)
    {
        System.Console.Write("0 1");
    }
    else{
        System.Console.Write("0 1 ");
        for (int i = 2; i < number; i++)
        {
            int current = prev + prevPrev;
            System.Console.Write($"{current} ");
            prevPrev = prev;
            prev = current;
        }
    }
    System.Console.WriteLine();
}

int CalcFibonacci(int number)
{
    if(number == 0 )  return 0;
    else if(number == 1) return 1;
    else return CalcFibonacci(number-2) + CalcFibonacci(number-1);
}

void PrintVibonacci(int number)
{
    // через рекурсию
    for (int i = 0; i < number; i++)
    {
        System.Console.Write($"{CalcFibonacci(i)} ");
    }
    System.Console.WriteLine();
}

int N = InputNumber("введите число");   
PrintVibo(N);
PrintVibonacci(N);