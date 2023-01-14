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


// Задача на проверку того, является ли первое число квадратом второго
System.Console.WriteLine("Задача на проверку того, является ли первое число квадратом второго");
System.Console.WriteLine();

int first_number=0, two_number = 0;
System.Console.WriteLine("Enter first number: ");
first_number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter next number: ");
two_number = int.Parse(Console.ReadLine());

if (first_number == two_number*two_number)
{
    System.Console.WriteLine($"Число {first_number} является квадратом числа {two_number}");
}
else{
    System.Console.WriteLine($"Число {first_number} не является квадратом числа {two_number}");
}
