// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Программа, выдающая максимальное из 3-х чисел");

System.Console.Write("Введите первое число: ");
int first_number = int.Parse(System.Console.ReadLine());

System.Console.Write("Введите второе число: ");
int two_number = int.Parse(System.Console.ReadLine());

System.Console.Write("Введите третье число: ");
int third_number = int.Parse(System.Console.ReadLine());
int max_number = first_number;

if(two_number>max_number){
    max_number = two_number;
}
if(third_number > max_number){
    max_number = third_number;
}
System.Console.WriteLine(
    $"Из трех введенных чисел ({first_number},{two_number},{third_number}) наибольшим является {max_number}"
    );
