/*
На вход координаты X и Y(X!=0 и Y!=0), на выходе номер четверти плоскости,
в которой находится эта точка
*/
int[] coords = new int[2];

Console.Write("Введите Х: ");
coords[0] = Int32.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
coords[1] = Int32.Parse(Console.ReadLine());

if (coords[0] > 0 && coords[1] > 0)
{
    System.Console.WriteLine("Номер четверти - 1");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти - 4");
}
else if (coords[0] < 0 && coords[1] > 0)
{
    System.Console.WriteLine("Номер четверти - 2");
}
else if (coords[0] < 0 && coords[1] < 0)
{
    System.Console.WriteLine("Номер четверти - 3");
}
else 
{
    System.Console.WriteLine("Точка в центре коодрдинат");
}