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