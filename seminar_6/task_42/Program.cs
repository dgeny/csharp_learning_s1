/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

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


string IntToBinaryStr(int number)
{
    //Перевод в новую систему счисления столбиком
    if (number == 1) return "1";
    else return IntToBinaryStr(number / 2) + (number % 2);
}

System.Console.WriteLine($"{IntToBinaryStr(InputNumber("Введите число"))}");