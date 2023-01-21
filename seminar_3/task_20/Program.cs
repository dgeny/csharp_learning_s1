// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

System.Console.WriteLine("Расстояние между 2мя точками в 2D пространстве");
System.Console.Write("Введите координаты первой точки (через пробел): ");
string first_point = System.Console.ReadLine();
string[] A = first_point.Split(" ");


System.Console.Write("Введите координаты второй   точки (через пробел): ");
string second_point = System.Console.ReadLine();
string[] B = second_point.Split(" ");

double result = Math.Sqrt(
    Math.Pow(int.Parse(A[0]) - int.Parse(B[0]), 2) +
    Math.Pow(int.Parse(A[1]) - int.Parse(B[1]), 2)
);

System.Console.WriteLine($"Расстояние составляет: {result}");