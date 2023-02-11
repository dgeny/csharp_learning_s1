/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

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

int Pow(int number, int power)
{
    if (power == 0)
        return 1;
    return number * Pow(number, power - 1);
}

int number = InputNumber("Введите число");
int power = InputNumber("Введите степень");
int result = Pow(number, power);
System.Console.WriteLine(result);