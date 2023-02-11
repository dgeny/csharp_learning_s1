/* Задача 65: Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */


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

string Func(int funcArg, int exitCrit)
{
    if (funcArg == exitCrit)
    {

        return funcArg.ToString();
    }
    else
    {

        return string.Join(", ", new string[] { Func(funcArg - 1, exitCrit), funcArg.ToString() });
    }
}

int M = InputNumber("Введите число M");
int N = InputNumber("Введите число N");
System.Console.WriteLine(Func(N, M));