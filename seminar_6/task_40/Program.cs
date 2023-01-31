/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

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

bool TriangleExists(int A, int B, int C)
{

    return (A < B + C) & (B < A + C) & (C < A + B);
}

int first = InputNumber("Введите первое число");
int second = InputNumber("Введите первое число");
int third = InputNumber("Введите первое число");

if (TriangleExists(first, second, third))
    System.Console.WriteLine("Треугольник существует");
else
    System.Console.WriteLine("Треугольник не существует");


