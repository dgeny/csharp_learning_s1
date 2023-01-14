// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Программа, выводящая какое число большее");
System.Console.Write("Введите первое число: ");
int first_number = int.Parse(System.Console.ReadLine());

System.Console.Write("Введите второе число: ");
int two_number = int.Parse(System.Console.ReadLine());

// Решение 1.
if (first_number > two_number){
    System.Console.WriteLine($"Первое введенное число ({first_number}) больше второго ({two_number})\nmax = {first_number}");
}
else if(first_number < two_number){
    System.Console.WriteLine($"Второе введенное число ({two_number}) больше первого ({first_number})\nmax = {two_number}");
}
else {
    System.Console.WriteLine("Введенные числа одинаковы");
}

// Решение 2.
System.Console.WriteLine($"max = {Int32.Max(first_number, two_number)}");