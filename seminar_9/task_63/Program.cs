/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
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


int N = InputNumber("Введите число N");
System.Console.WriteLine(Func(N, 1));