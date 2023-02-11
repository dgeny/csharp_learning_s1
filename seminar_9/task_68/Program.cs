/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int InputNumber(string message)
{
    int number = -1;
    while (true)
    {
        System.Console.Write(message + ":");
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else break;
    }
    return number;
}


int Akkerman(int m, int n){
    if (m==0)
    {
        return n+1;
    }
    else if(m>0 && n==0)
    {
        return Akkerman(m-1,1);
    }
    else //if(m>0 && n>0)
    {
        return Akkerman(m-1, Akkerman(m,n-1));
    } 
}

int m = InputNumber("Введите число M");
int n = InputNumber("Введите число N");
System.Console.WriteLine(Akkerman(m,n));