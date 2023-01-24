int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}

int numberA = InputNumber("Введите число А:");
int numberB = InputNumber("Введите число B:"); ;


System.Console.WriteLine($"Сумма чисел от 1 до {numberA}: {Sum(numberA)}");
System.Console.WriteLine($"Сумма чисел от 1 до {numberB}: {Sum(numberB)}");