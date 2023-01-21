/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number = 0;
do
{
    System.Console.Write("Введите номер дня недели (число от 1 до 7):");
}
while (!
        (int.TryParse(Console.ReadLine(), out number) &&
        (number > 0) &&
        (number < 8))
);

if (number == 6 || number == 7)
{
    System.Console.WriteLine("Это - выходной день!");
}
else
{
    System.Console.WriteLine("Этот день НЕ выходной :'( ");
}

//вариант switch-case
switch (number)
{
    case 6:
        {
            System.Console.WriteLine("Это - выходной день!");
            break;
        }
    case 7:
        {
            System.Console.WriteLine("Это - выходной день!");
            break;
        }
    default:
        {
            System.Console.WriteLine("Этот день НЕ выходной :'( ");
            break;
        }
}