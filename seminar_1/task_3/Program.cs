// Программа, которая будет выдавать название дня недели по заданному номеру

int NumberOfWeek = 5;
Console.WriteLine("Программа, которая будет выдавать название дня недели по заданному номеру");
System.Console.WriteLine();

do {
    System.Console.Write("Введите номер дня недели:\t");
}
while (!Int32.TryParse(System.Console.ReadLine(), out NumberOfWeek));

switch (NumberOfWeek)
{
    case 1: 
        System.Console.WriteLine("Это понедельник");
        break;
    case 2: 
        System.Console.WriteLine("Это вторник");
        break;
    case 3: 
        System.Console.WriteLine("Это среда");
        break;
    case 4: 
        System.Console.WriteLine("Это четверг");
        break;
    case 5: 
        System.Console.WriteLine("Это пятница");
        break;
    case 6: 
        System.Console.WriteLine("Это суббота");
        break;
    case 7: 
        System.Console.WriteLine("Это воскресенье");
        break;
    default:
        System.Console.WriteLine("Ты ввел неподходящий день, значит сегодня пятница"); break;
}
