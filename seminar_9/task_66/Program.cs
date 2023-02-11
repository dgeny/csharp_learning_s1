/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

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

int Sum(int M, int N)
{
    if (M == N)
        return N;
    return M + Sum(M + 1, N);
}

int m = InputNumber("Введите число M");
int n = InputNumber("Введите число N");
System.Console.WriteLine($"Сумма чисел от M до N = {Sum(m,n)}");