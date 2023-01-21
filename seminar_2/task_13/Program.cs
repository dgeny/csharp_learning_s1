/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

decimal number = 0;
do
{
    System.Console.Write("Введите произвольное число, начиная с 100:");
}
while (!
        (decimal.TryParse(Console.ReadLine(), out number))
);

number = Math.Abs(number);
UInt64 resulted = Convert.ToUInt64(number);
if(resulted < 100)
{
        System.Console.WriteLine("Третьей цифры нет.");
        return;
}


while(resulted  > 1000)
{
        resulted = resulted / 10;
}
System.Console.WriteLine($"Третья  цифра числа - {resulted % 10}");