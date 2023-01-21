/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Вычисляем расстояние в 3D пространстве");
System.Console.Write("Введите координаты первой точки (через пробел): ");
string first_point = System.Console.ReadLine();
string[] A = first_point.Split(" ");


System.Console.Write("Введите координаты второй   точки (через пробел): ");
string second_point = System.Console.ReadLine();
string[] B = second_point.Split(" ");

if (A.Length != B.Length || A.Length != 3)
{
    System.Console.WriteLine("Исходные данные введены неверно!");
}
else
{

    double result = Math.Sqrt(
        Math.Pow(int.Parse(A[0]) - int.Parse(B[0]), 2) +
        Math.Pow(int.Parse(A[1]) - int.Parse(B[1]), 2) +
        Math.Pow(int.Parse(A[2]) - int.Parse(B[2]), 2)
        );
    System.Console.WriteLine($"Расстояние составляет {Math.Round(result,2)}");
}
