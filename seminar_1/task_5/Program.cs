// Программа, которая выдает все числа в промежутке от -N до N, где N - число, вводимое пользователем

Console.WriteLine("Программа, которая выдает все числа в промежутке от -N до N, где N - число, вводимое пользователем");
System.Console.WriteLine();

int counter = 0;

do
{
    System.Console.Write("Введите целое число:\t");
}
while (!Int32.TryParse(System.Console.ReadLine(), out counter));

for (int i = -counter; i < counter + 1; i++)
{
    System.Console.Write($"{i} ");
}
System.Console.WriteLine();
