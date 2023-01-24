/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

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

int Fact(int number){
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    } 
    return result;
}

string text = "Введите число: ";
System.Console.WriteLine(Fact(InputNumber(text)));