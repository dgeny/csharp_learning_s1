/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

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


int Sum(int number)
{
    if (number / 10 == 0)
        return number % 10;
    return number % 10 + Sum(number / 10);
}

int number = InputNumber("Введите число");
int result = Func(number);
System.Console.WriteLine(result);