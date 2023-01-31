/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 
 y = k1 * x + b1, 
 y = k2 * x + b2; 
 
 значения b1, k1, b2 и k2 задаются пользователем.


b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message + ": ");
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}

void CalcPoint(double K1, double K2, double B1, double B2)
{
    // k1*x+b1 = k2*x+b2 => k1*x-k2*x=b2-b1 => x(k1-k2)=b2-b1 => x=(b2-b1)/(k1-k2)
    double x = (B2 - B1) / (K1 - K2);
    double y = K2 * x + B2;
    double y1 = K1 * x + B1;// => контрольный
    System.Console.WriteLine($"Точка пересечения прямых: ({Math.Round(x,3)},{Math.Round(y,3)})");
}

System.Console.WriteLine("Программа, вычисляющая точки пересечения двух прямых.");
int k1 = InputNumber("Введете коэффициент K1");
int b1 = InputNumber("Введете коэффициент B1");
int k2 = InputNumber("Введете коэффициент K2");
int b2 = InputNumber("Введете коэффициент B2");
CalcPoint(k1, k2, b1, b2);