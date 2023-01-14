// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

int number;

do
{
    number = 0;
    Console.Write("Enter integer number: ");    
} while (!Int32.TryParse(Console.ReadLine(),out number));

int squre = number*number;

System.Console.WriteLine($"Квадрат числа: {squre}");
