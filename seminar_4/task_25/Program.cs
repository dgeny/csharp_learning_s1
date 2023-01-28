/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

string IntToBinaryStr(int number)
{
    //Перевод в новую систему счисления столбиком
    if (number == 1) return "1";
    else return IntToBinaryStr(number / 2) + (number % 2);
}

int[] IntToBitArray(int number)
{
    string bstr = IntToBinaryStr(number);
    int[] res = new int[bstr.Length];
    int counter = 0;
    //BigLittleEndian crunch XD
    foreach (var item in bstr.Reverse())
    {
        res[counter] = Convert.ToInt32(item.ToString());
        counter++;
    }

    return res;
}

double PowVer(int number, int power)
{
    //бинарный алгоритм возведения в степень
    double result = 1;
    int[] BitsOfPower = IntToBitArray(power);
    double helper = number;
    foreach (int bit in BitsOfPower)
    {
        if (bit == 1) result = result * helper;

        helper = helper * helper;
    }
    return result;
}

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}


System.Console.WriteLine("Программа возведения числа в степень, состоящая из 'великов' и 'костылей'.");
int num = InputNumber("Введите возводимое в степень число: ");
int pow = InputNumber("Введите степень, в которую возводится число: ");

System.Console.WriteLine($"{num} в степени {pow} = {PowVer(num, pow)}");

//Контроль
System.Console.WriteLine($"{num} в степени {pow} = {Math.Pow(num, pow)}");


//  Для длинной арифметики
/*
using System.Numerics;


string IntToBinaryStr(BigInteger number)
{
    //Перевод в новую систему счисления столбиком
    if (number == 1) return "1";
    else return IntToBinaryStr(number / 2) + (number % 2);
}

int[] IntToBitArray(BigInteger number)
{
    string bstr = IntToBinaryStr(number);
    int[] res = new int[bstr.Length];
    int counter = 0;
    //BigLittleEndian crunch XD
    foreach (var item in bstr.Reverse())
    {
        res[counter] = Convert.ToInt32(item.ToString());
        counter++;
    }

    return res;
}

BigInteger PowVer(BigInteger number, BigInteger power)
{
    //бинарный алгоритм возведения в степень
    BigInteger result = 1;
    int[] BitsOfPower = IntToBitArray(power);
    BigInteger helper = number;
    foreach (int bit in BitsOfPower)
    {
        if (bit == 1) result = result * helper;

        helper = helper * helper;
    }
    return result;
}

BigInteger PowSimple(BigInteger number, BigInteger power){
    
    BigInteger res = 1;
    for (int i = 0; i < power; i++)
    {
        res = res * number;
    } 
    
    return res;
} 

BigInteger num = 12345;
BigInteger pow = 1234567;


System.DateTime Res2Start = System.DateTime.Now;
BigInteger res2 = PowSimple(num,pow);
System.DateTime Res2End = System.DateTime.Now;

System.Console.WriteLine($"PowSimple: {res2.GetByteCount()} знаков за {Res2End-Res2Start}");

System.DateTime Res3Start = System.DateTime.Now;
BigInteger res3 = BigInteger.Pow(num,(int)pow);
System.DateTime Res3End = System.DateTime.Now;
System.Console.WriteLine($"Microsoft: {res3.GetByteCount()} знаков за {Res3End-Res3Start}");

System.DateTime Res1Start = System.DateTime.Now;
BigInteger res1 = PowVer(num,pow);
System.DateTime Res1End = System.DateTime.Now;
System.Console.WriteLine($"PowVer:  {res1.GetByteCount()} знаков за {Res1End-Res1Start}");
*/

/*➤ dotnet run
Microsoft: 2097474 знаков за 00:00:49.5876566
PowVer:  2097474 знаков за 00:00:53.1542150
PowSimple: 2097474 знаков за 00:13:43.4507449

➤ dotnet run
PowSimple: 2097474 знаков за 00:15:23.1643146
Microsoft: 2097474 знаков за 00:00:49.7787553
PowVer:  2097474 знаков за 00:00:53.99788898
*/